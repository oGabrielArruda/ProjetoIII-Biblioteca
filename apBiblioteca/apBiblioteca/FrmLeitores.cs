using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apBiblioteca
{
  public partial class FrmLeitores : Form
  {
    VetorDados<Livro>  osLivros; // osLivros armazenará os dados lidos e terá os métodos de manutenção para os livros
    VetorDados<Leitor> osLeitores; // osLeitores armazenará os dados lidos e terá os métodos de manutenção para os leitores
        int ondeIncluir = 0;        // variável para a posição de inclusão acessível na classe toda

    string nomeArquivoLeitores, nomeArquivoLivros;
    
    public FrmLeitores()
    {
      InitializeComponent();
    }

    private void FrmFunc_Load(object sender, EventArgs e)
    {
     //-- para exibir as imagens nos botçoes //
      int indice = 0;
      barraDeFerramentas.ImageList = imlBotoes;
      foreach (ToolStripItem item in barraDeFerramentas.Items)
        if (item is ToolStripButton) // se não é separador:
          (item as ToolStripButton).ImageIndex = indice++;
       
      // ------------------------------------ //


      osLeitores = new VetorDados<Leitor>(50); // instancia o objeto osLeitores com a classe VetorDados 
      dlgAbrir.Title = "Selecione o arquivo com os dados de leitores"; // mudamos o título do OpenFileDialog para o usuário saber qual arquivo deve ser aberto
      if (dlgAbrir.ShowDialog() == DialogResult.OK)  // se abriu o arquivo
      {
        nomeArquivoLeitores = dlgAbrir.FileName; // string do nome do arquivo dos leitores recebe o nome do arquivo aberto
                osLeitores.LerDados(nomeArquivoLeitores); // lemos os dados do arquivo aberto
      }

      osLivros = new VetorDados<Livro>(50); // instancia o objeto osLivros com a classe VetorDados 
            dlgAbrir.Title = "Selecione o arquivo com os dados de livros";   // mudamos o título do OpenFileDialog para o usuário saber qual arquivo deve ser aberto
            if (dlgAbrir.ShowDialog() == DialogResult.OK)  // se abriu o arquivo
            {
                nomeArquivoLivros = dlgAbrir.FileName; // string do nome do arquivo dos livros recebe o nome do arquivo aberto
                osLivros.LerDados(nomeArquivoLivros); // lemos os dados do arquivo aberto
                btnInicio.PerformClick(); // chamamos o método no click do botão início
            }

            if (FrmBiblioteca.Consulta) // se for aberto uma consulta
            {
                tabControl1.SelectedIndex = 1; // mudamos a tabPage para a lista
                FrmBiblioteca.Consulta = false; // deixamos a variável de Consulta falsa
            }
    }

    private void btnInicio_Click(object sender, EventArgs e) // click do botão de início
    {
      osLeitores.PosicionarNoPrimeiro(); // deixa a posição atual no primeiro índice do vetor
      AtualizarTela(); // atualiza a tela para o usuário
    }
    private void btnAnterior_Click(object sender, EventArgs e) // click do botão de voltar um
    {
      osLeitores.RetrocederPosicao(); // deixa a posição atual no índice anterior ao exibido na tela
      AtualizarTela(); // atualiza a tela para o usuário
    }
    private void btnProximo_Click(object sender, EventArgs e) // click no botão de próximo
    {
        osLeitores.AvancarPosicao(); // deixa a posição atual no indíce posterior ao exibido na tela
        AtualizarTela(); // atualiza a tela para o usuário
    } 
    private void btnUltimo_Click(object sender, EventArgs e) // click no botão de "último"
    {
      osLeitores.PosicionarNoUltimo(); // deixa a posição atual no último índice do vetor
      AtualizarTela(); // atualiza a tela para o usuário
    }

    private void btnSair_Click(object sender, EventArgs e) // click no botão fechar
    {
       // fecha o formulário mas antes dispara o evento FormClosing
       Close();
    }

    private void AtualizarTela() // função que atualiza a tela e exibe os campos para o usuário
    {
      if (!osLeitores.EstaVazio) // se o vetor de leitores NÃO está vazio
      {
        Leitor oLeitor = osLeitores[osLeitores.PosicaoAtual]; // objeto 'oLeitor' é igual o valor da posição atual da PosiçãoAtual de osLeitores
        txtCodigoLeitor.Text = oLeitor.CodigoLeitor + ""; // alteramos o campo de código do leitor para o seu respectivo código
        txtNomeLeitor.Text   = oLeitor.NomeLeitor; // alteramos também os campos de nome
        txtEndereco.Text     = oLeitor.EnderecoLeitor; //                           &endereço
        dgvLivros.RowCount   = oLeitor.QuantosLivrosComLeitor+1; // a quantidade de colunas do DataGridView é igual a quantidade de livros que o leitor tem emprestado

        for (int umLivro = 0; 
                 umLivro < oLeitor.QuantosLivrosComLeitor; umLivro++) // enquanto o índice for menor que a quantidade de livros com o leitor
        {
          int ondeLivro = -1; // índice de onde encontraremos o livro
          var livroProcurado = 
              new Livro(oLeitor.CodigoLivroComLeitor[umLivro]); // instanciamos o objeto livroProcurado como um novo Livro com seu código passado como parâmetro
          if (osLivros.Existe(livroProcurado, ref ondeLivro)) // se o livro procurado existe
          {
            Livro oLivro = osLivros[ondeLivro]; // a variável oLivro fica com o valor do livro encontrado (que está na posição 'ondeLivro')
            dgvLivros.Rows[umLivro].Cells[0].Value = oLivro.CodigoLivro; // mudamos a primeira célula na coluna do indíce com o respectivo código
            dgvLivros.Rows[umLivro].Cells[1].Value = oLivro.TituloLivro; //                                                                título
            dgvLivros.Rows[umLivro].Cells[2].Value = oLivro.DataDevolucao.ToShortDateString(); //                                          data de devolução
            if (oLivro.DataDevolucao < DateTime.Now.Date) // se a data de devolução for menor que a data atual
               dgvLivros.Rows[umLivro].Cells[3].Value = "S"; // a devolução do livro está atrasada, e escrevemos 'S' no campo de atraso
            else // se a data de devolução for maior que a data atual
              dgvLivros.Rows[umLivro].Cells[3].Value = "N"; // a devolução não está atrasad, e escrevemos 'N' no campo de atraso
          }
        }

        TestarBotoes(); // chamamos a função que verifica a validade dos botões
        stlbMensagem.Text = // mudamos a mensagem exibida
          "Registro " + (osLeitores.PosicaoAtual + 1) +
                     "/" + osLeitores.Tamanho;
      }
    }
    private void LimparTela() // função que limpa todos os campos
    {
      txtCodigoLeitor.Clear(); // limpa o textbox do código do leitor
      txtNomeLeitor.Clear(); // limpa o textbox do nome do leitor
      txtEndereco.Text = ""; // limpa o textbox do endereço do leitor
      dgvLivros.RowCount = 1; // deixa o DataGridView com apenas uma coluna
    }

    private void TestarBotoes() // função que verifica a validade dos botões
    {
      btnInicio.Enabled = true; // habilita todos os botões
      btnAnterior.Enabled = true; // ^^
      btnProximo.Enabled = true; // ^^
      btnUltimo.Enabled = true; // ^^
      if (osLeitores.EstaNoInicio) // se a posição atual do objeto 'osLeitores' está no primeiro índice
      {
        btnInicio.Enabled = false; //  é impossível ir para o anterior, e inútil a utilização do botão de início, por isso desabilitamos os dois
        btnAnterior.Enabled = false; // ^^
      }
      if (osLeitores.EstaNoFim) // se a posição atual do objeto 'osLeitores' está no primeiro índice
      {
        btnProximo.Enabled = false; //  é impossível ir para o próximo, e inútil a utilização do botão de último, por isso desabilitamos os dois
        btnUltimo.Enabled = false; // ^^
      }
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
      // saímos do modo de navegação e entramos no modo de inclusão:
      osLeitores.SituacaoAtual = Situacao.incluindo;

      // preparamos a tela para que seja possível digitar dados do novo livro
      LimparTela();

      // colocamos o cursor no campo chave
      txtCodigoLeitor.Focus();

      // Exibimos mensagem no statusStrip para instruir o usuário a digitar dados
      stlbMensagem.Text = "Digite o código do novo leitor";

      btnSalvar.Enabled = true; // habilitamos o botão salvar
    }

    private void txtMatricula_Leave(object sender, EventArgs e) // evento disparado ao sair do campo da digitação do código do leitor
    {
      if (txtCodigoLeitor.Text == "") // se o campo está vazio      
        MessageBox.Show("Digite um código válido!"); // alertamos o usuário
      else // se não está vazio
      {
        var procurado = new Leitor(txtCodigoLeitor.Text); // instanciamos um objeto da classe Leitor passando o código digitado como parâmetro
        switch (osLeitores.SituacaoAtual) // prosseguimos diferentemente para cada situação, por isso o uso do switch
        {
          case Situacao.incluindo: // se for uma inclusão
            if (osLeitores.Existe(procurado, ref ondeIncluir))   // se já existe o código
            {
              MessageBox.Show("Código repetido; inclusão cancelada."); // alertamos o usuário
              osLeitores.SituacaoAtual = Situacao.navegando; // voltamos para a situação normal ( navegando )
              AtualizarTela(); // restaura o registro visível anteriormente
            }
            else // o código ainda não existe no vetor dados
            {
              txtNomeLeitor.Focus(); // focamos no outro campo, o de nome
              stlbMensagem.Text = "Digite os demais dados. Após isso pressione [Salvar]"; // alteramos a mensagem para o usuário
            }
            break; // saímos do switch
          case Situacao.pesquisando: // se for uma pesquisa
            int ondeAchou = 0;  // variável inteira para alterar a posição do vetordados futuramente
            if (!osLeitores.Existe(procurado, ref ondeAchou)) // se o código digitado não existe
            {
              MessageBox.Show("Código não foi cadastrado ainda."); // alertamos o usuário
              AtualizarTela(); // atualizamos a tela
              osLeitores.SituacaoAtual = Situacao.navegando; // voltamos para a situação normal ( navegando )
            }
            else  // encontrou o código procurado na posição ondeAchou
            {
              osLeitores.PosicaoAtual = ondeAchou; // alteramos a posição atual para o indíce de onde o código encontrado está
              AtualizarTela(); // atualizamos a tela
              osLeitores.SituacaoAtual = Situacao.navegando; // voltamos para a situação normal ( navegando )
            }
            break; // saímos do switch
        } 
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e) // click do botão salvar
    {
      if (osLeitores.SituacaoAtual == Situacao.incluindo) // está no modo de inclusão
      {
        var novoDado = new Leitor(txtCodigoLeitor.Text, // instanciamos um objeto da classe Leitor com os campos passados como paramêtro
                               txtNomeLeitor.Text,
                               txtEndereco.Text,
                               0,    // --> 0 é o número de livros emprestados
                               new string[5]);  // vetor com 5 códigos de livro vazios
        osLeitores.Incluir(novoDado, ondeIncluir); // incluímos o novo leitor
        // para mudar o registro com o qual trabalhamos no momento
        osLeitores.PosicaoAtual = ondeIncluir; // alteramos a posição atual para o índice de onde o dado foi incluido
        AtualizarTela(); // atualizamos a tela mostrando o registro incluído
        osLeitores.SituacaoAtual = Situacao.navegando; // termina o modo de inclusão
      }
      else  // verificar se está editando
        if (osLeitores.SituacaoAtual == Situacao.editando) // se for uma edição
        {
          osLeitores[osLeitores.PosicaoAtual] = // alteramos o registro de leitores da posição atual ( a que está sendo exibida na tela ),
            new Leitor(                         // onde os novas informações serão as que o usuário digitar nos campos
                osLeitores[osLeitores.PosicaoAtual].CodigoLeitor, // o código não poderá ser alterado
                txtNomeLeitor.Text,
                txtEndereco.Text,
                osLeitores[osLeitores.PosicaoAtual].QuantosLivrosComLeitor, // a quantidade de livros com o Leitor, bem como os respectivos códigos
                osLeitores[osLeitores.PosicaoAtual].CodigoLivroComLeitor // não poderão ser alterados
              );

          osLeitores.SituacaoAtual = Situacao.navegando; // voltamos para a situação original
          txtCodigoLeitor.ReadOnly = false; // deixamos o código do leitor habilitado 
          AtualizarTela(); // atualizamos a tela para o novo registro editado
        } 
      btnSalvar.Enabled = false; // desabilitamos o botão salvar
    }

    private void FrmFunc_FormClosing(object sender, FormClosingEventArgs e) // evento disparado quando o formulário de manutenção de leitores está fechando
    {
      osLeitores.GravarDados(nomeArquivoLeitores); // gravamos os dados alterados no arquivo texto de leitores, que foi escolhido pelo usuário
    }

    private void btnExcluir_Click(object sender, EventArgs e) // click do botão excluir
    {
      if(osLeitores[osLeitores.PosicaoAtual].QuantosLivrosComLeitor == 0) // se o leitor não está com nenhum livro emprestado
      {
          if (MessageBox.Show( "Deseja realmente excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // perguntamos se o usuário realmente quer excluir
          {
              osLeitores.Excluir(osLeitores.PosicaoAtual); // se sim, excluímos o registro exibido na tela
              if (osLeitores.PosicaoAtual >= osLeitores.Tamanho) // se a posição atual for maior ou igual a quantidade de registros
                  osLeitores.PosicionarNoUltimo(); // posicionamos no último
              AtualizarTela(); // atualizamos a tela
          }
      }
       else // se o leitor tem livros emprestados, não podemos excluí-lo até que a situação seja resolvida
       {
                MessageBox.Show("O leitor não pode ser excluido!\n Ainda há livros não devolvidos!", 
                    "Exclusão cancelada", MessageBoxButtons.OK); // alertamos o usuário desta situação
       }
    }

    private void btnProcurar_Click(object sender, EventArgs e) // click do botão procurar
    {
      LimparTela(); // limpamos a tela
      osLeitores.SituacaoAtual = Situacao.pesquisando; // alteramos a situação atual para a situação de pesquisa
      txtCodigoLeitor.Focus(); // focamos no campo de código de leitor
      stlbMensagem.Text = "Digite o código do leitor que busca"; // mudamos a mensagem exibida para o usuário
    }

    private void tpLista_Enter(object sender, EventArgs e) // ao entrar no tabpage de lista (consulta)
    {
      osLeitores.ExibirDados(lsbLivros, "Código  Nome                           Endereço"); // exibimos os dados de leitores, com o cabeçalho
    }

    private void btnEditar_Click(object sender, EventArgs e) // click do botão editar
    {
      osLeitores.SituacaoAtual = Situacao.editando; // alteramos a situação atual para a situação de edição
      txtCodigoLeitor.ReadOnly = true;  // para não permitir alterar a matrícula
      stlbMensagem.Text = "Modifique os campos desejados e pressione [Salvar]"; // alteramos a mensagem exibida ao usuário
      txtNomeLeitor.Focus(); // focamos no campo de nome do leitor

      btnSalvar.Enabled = true; // hablitamos o botão salvar
    }

    private void btnCancelar_Click(object sender, EventArgs e) // click do botão cancelar
    {
      osLeitores.SituacaoAtual = Situacao.navegando; // alteramos a situação atual para a situação de navegação
      AtualizarTela(); // atualizamos a tela
      btnSalvar.Enabled = false; // desabilitamos o botão salvar
    }
  }
}

 
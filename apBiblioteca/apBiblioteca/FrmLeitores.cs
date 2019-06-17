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
        nomeArquivoLeitores = dlgAbrir.FileName; // string do nome do arquivo dos livros recebe o nome do arquivo aberto
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
      osLeitores.PosicionarNoPrimeiro(); // deixa a posição inicial no primeiro índice do vetor
      AtualizarTela(); // atualiza a tela para o usuário
    }
    private void btnAnterior_Click(object sender, EventArgs e)
    {
      osLeitores.RetrocederPosicao();
      AtualizarTela(); // atualiza a tela para o usuário
    }
    private void btnProximo_Click(object sender, EventArgs e)
    {
      osLeitores.AvancarPosicao();
      AtualizarTela(); // atualiza a tela para o usuário
    } 
    private void btnUltimo_Click(object sender, EventArgs e)
    {
      osLeitores.PosicionarNoUltimo();
      AtualizarTela(); // atualiza a tela para o usuário
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
       // fecha o formulário mas antes dispara o evento FormClosing
       Close();
    }

    private void AtualizarTela() // método que atualiza a tela e exibe os campos para o usuário
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

    private void txtMatricula_Leave(object sender, EventArgs e)
    {
      if (txtCodigoLeitor.Text == "")
        MessageBox.Show("Digite um código válido!");
      else
      {
        var procurado = new Leitor(txtCodigoLeitor.Text);
        switch (osLeitores.SituacaoAtual)
        {
          case Situacao.incluindo:
            if (osLeitores.Existe(procurado, ref ondeIncluir))   // se já existe o código
            {
              MessageBox.Show("Código repetido; inclusão cancelada.");
              osLeitores.SituacaoAtual = Situacao.navegando;
              AtualizarTela(); // restaura o registro visível anteriormente
            }
            else // o código ainda não existe no vetor dados
            {
              txtNomeLeitor.Focus();
              stlbMensagem.Text = "Digite os demais dados. Após isso pressione [Salvar]";
            }
            break;
          case Situacao.pesquisando:
            int ondeAchou = 0;
            if (!osLeitores.Existe(procurado, ref ondeAchou))
            {
              MessageBox.Show("Código não foi cadastrado ainda.");
              AtualizarTela();
              osLeitores.SituacaoAtual = Situacao.navegando;
            }
            else  // encontrou o código procurado na posição ondeAchou
            {
              osLeitores.PosicaoAtual = ondeAchou;
              AtualizarTela();
              osLeitores.SituacaoAtual = Situacao.navegando;
            }
            break;
        }
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      if (osLeitores.SituacaoAtual == Situacao.incluindo) // está no modo de inclusão
      {
        var novoDado = new Leitor(txtCodigoLeitor.Text,
                               txtNomeLeitor.Text,
                               txtEndereco.Text,
                               0,    // --> 0 é o número de livros emprestados
                               new string[5]);  // vetor com 5 códigos de livro vazios
        osLeitores.Incluir(novoDado, ondeIncluir);
        // para mudar o registro com o qual trabalhamos no momento
        osLeitores.PosicaoAtual = ondeIncluir;
        AtualizarTela();
        osLeitores.SituacaoAtual = Situacao.navegando; // termina o modo de inclusão
      }
      else  // verificar se está editando
        if (osLeitores.SituacaoAtual == Situacao.editando)
        {
          osLeitores[osLeitores.PosicaoAtual] =
            new Leitor(
                osLeitores[osLeitores.PosicaoAtual].CodigoLeitor,
                txtNomeLeitor.Text,
                txtEndereco.Text,
                osLeitores[osLeitores.PosicaoAtual].QuantosLivrosComLeitor,
                osLeitores[osLeitores.PosicaoAtual].CodigoLivroComLeitor
              );

          osLeitores.SituacaoAtual = Situacao.navegando;
          txtCodigoLeitor.ReadOnly = false;
          AtualizarTela();
        }
      btnSalvar.Enabled = false;
    }

    private void FrmFunc_FormClosing(object sender, FormClosingEventArgs e)
    {
      osLeitores.GravarDados(nomeArquivoLeitores);
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      if(osLeitores[osLeitores.PosicaoAtual].QuantosLivrosComLeitor == 0) // se o leitor não está com nenhum livro emprestado
      {
          if (MessageBox.Show( "Deseja realmente excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
          {
              osLeitores.Excluir(osLeitores.PosicaoAtual);
              if (osLeitores.PosicaoAtual >= osLeitores.Tamanho)
                  osLeitores.PosicionarNoUltimo();
              AtualizarTela();
          }
      }
       else
       {
                MessageBox.Show("O leitor não pode ser excluido!\n Ainda há livros não devolvidos!", 
                    "Exclusão cancelada", MessageBoxButtons.OK);
       }
    }

    private void btnProcurar_Click(object sender, EventArgs e)
    {
      LimparTela();
      osLeitores.SituacaoAtual = Situacao.pesquisando;
      txtCodigoLeitor.Focus();
      stlbMensagem.Text = "Digite o código do leitor que busca";
    }

    private void tpLista_Enter(object sender, EventArgs e)
    {
      osLeitores.ExibirDados(lsbLivros, "Código  Nome                           Endereço");
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      osLeitores.SituacaoAtual = Situacao.editando;
      txtCodigoLeitor.ReadOnly = true;  // para não permitir alterar a matrícula
      stlbMensagem.Text = "Modifique os campos desejados e pressione [Salvar]";
      txtNomeLeitor.Focus();

      btnSalvar.Enabled = true;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      osLeitores.SituacaoAtual = Situacao.navegando;
      AtualizarTela();
      btnSalvar.Enabled = false;
    }
  }
}

 
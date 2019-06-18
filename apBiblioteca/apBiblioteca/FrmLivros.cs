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
  public partial class FrmLivros : Form
  {
    VetorDados<Livro>  osLivros; // osLivros armazenará os dados lidos e terá os métodos de manutenção
    VetorDados<Leitor> osLeitores;
    VetorDados<Tipo> osTipos;
    int ondeIncluir = 0;        // global --> acessível na classe toda

        string nomeArquivoLeitores, nomeArquivoLivros, nomeArquivoTipos;
    public FrmLivros()
    {
      InitializeComponent();
    }

    private void FrmFunc_Load(object sender, EventArgs e)
    {
      int indice = 0;
      barraDeFerramentas.ImageList = imlBotoes;
      foreach (ToolStripItem item in barraDeFerramentas.Items)
        if (item is ToolStripButton) // se não é separador:
          (item as ToolStripButton).ImageIndex = indice++;

            osLivros = new VetorDados<Livro>(50); // instancia o objeto osLivros com a classe VetorDados
            dlgAbrir.Title = "Selecione o arquivo com os dados de livros"; // mudamos o título do OpenFileDialog para o usuário saber qual arquivo deve ser aberto
            if (dlgAbrir.ShowDialog() == DialogResult.OK)  // se abriu o arquivo
            {
                nomeArquivoLivros = dlgAbrir.FileName; // string do nome do arquivo dos livros recebe o nome do arquivo aberto
                osLivros.LerDados(nomeArquivoLivros); // lemos os dados do arquivo aberto
            }

            osLeitores = new VetorDados<Leitor>(50); // instancia o objeto osLeitores com a classe VetorDados 
            dlgAbrir.Title = "Selecione o arquivo com os dados de leitores"; // mudamos o título do OpenFileDialog para o usuário saber qual arquivo deve ser aberto
            if (dlgAbrir.ShowDialog() == DialogResult.OK) // se abriu o arquivo
            {
                nomeArquivoLeitores = dlgAbrir.FileName; // string do nome do arquivo dos leitores recebe o nome do arquivo aberto
                osLeitores.LerDados(nomeArquivoLeitores); // lemos os dados do arquivo aberto
            }


            osTipos = new VetorDados<Tipo>(50); // instancia o objeto osTipos com a classe VetorDados
            dlgAbrir.Title = "Selecione o arquivo com os tipos dos livros"; // mudamos o título do OpenFileDialog para o usuário saber qual arquivo deve ser aberto
            if (dlgAbrir.ShowDialog() == DialogResult.OK) // se abriu o arquivo
            {
               nomeArquivoTipos = dlgAbrir.FileName; // string do nome do arquivo dos tipos recebe o nome do arquivo aberto
               osTipos.LerDados(nomeArquivoTipos); // lemos os dados do arquivo aberto
               ExibirTiposNoDgv(); // chamamos a função que exibe o código do tipo e sua descrição no DataGridView
               btnInicio.PerformClick(); // chamamos o click do botão início
            }

            if (FrmBiblioteca.Consulta) // se o usuário abriu uma consulta de livros
            {
                tabControl1.SelectedIndex = 1; // mudamos para a tabpage lista
                FrmBiblioteca.Consulta = false; // deixamos a variavel Consulta como false
            }
    }

    private void ExibirTiposNoDgv()  // função que exibe os tipos com os códigos e descrições no DataGridView
    {
        dgvTipos.RowCount = osTipos.Tamanho; // mudamos a quantidade de colunas para a quantidade de tipos
        for(int i = 0; i< osTipos.Tamanho; i++) // enquanto o índice é menor que a quantidade de tipos
         {
                dgvTipos.Rows[i].Cells[0].Value = osTipos[i].CodigoTipo; // colocamos na coluna de nmr *i* no primeiro campo, o código do tipo de indíce 'i'
                dgvTipos.Rows[i].Cells[1].Value = osTipos[i].DescricaoTipo; // colocamos na mesma coluna, no segundo campo, a descrição do tipo de indíce 'i'
         }
    }

    private void btnInicio_Click(object sender, EventArgs e)  // click do botão de início
    {
          osLivros.PosicionarNoPrimeiro(); // deixa a posição atual no primeiro índice do vetor
          AtualizarTela(); // atualiza a tela para o usuário
    }
    private void btnAnterior_Click(object sender, EventArgs e) // click do botão de voltar um
    {
       osLivros.RetrocederPosicao(); // deixa a posição atual no índice anterior ao exibido na tela
       AtualizarTela(); // atualiza a tela para o usuário
    }
    private void btnProximo_Click(object sender, EventArgs e) // click do botão de próximo
    {
      osLivros.AvancarPosicao(); // deixa a posição atual no indíce posterior ao exibido na tela
      AtualizarTela(); // atualiza a tela para o usuário
    }
    private void btnUltimo_Click(object sender, EventArgs e) // click no botão de "último"
     {
        osLivros.PosicionarNoUltimo(); // deixa a posição atual no último índice do vetor
        AtualizarTela(); // atualiza a tela para o usuário
    }

    private void AtualizarTela() // função que atualiza a tela e exibe os campos para o usuário
     {
      if (!osLivros.EstaVazio) // se o vetor de livros NÃO está vazio
      {
        int indice = osLivros.PosicaoAtual; // atribuímos à índice o valor da PosiçãoAtual (que está exibida na tela)
        txtCodigoLivro.Text = osLivros[indice].CodigoLivro + ""; // alteramos o campo de código para o código do livro da posição atual
        txtTituloLivro.Text = osLivros[indice].TituloLivro; // e o mesmo com o título do livro ^^

        bool achouTipo = false;
        dgvTipos.ClearSelection(); // limpamos a seleção do datagridview
        for(int i = 0; i < dgvTipos.RowCount && !achouTipo; i++) // enquanto o 'i' for menor que a quantidade de colunas do datagridview, e o tipo não for encontrado
        {
           if(int.Parse(dgvTipos.Rows[i].Cells[0].Value.ToString()) == osLivros[indice].TipoLivro) // se o valor do código na coluna 'i' for igual ao código do livro da posição atual
           {
              dgvTipos.Rows[i].Selected = true; // selecionamos a coluna do tipo do livro
              achouTipo = true; // deixamos a variàvel booleana achouTipo igual a verdadeira, saindo do 'for'
           }
        }

      
        txtLeitorComLivro.Text = "000000"; // alteramos o código do leitor que está com o livro para 000000, que é o padrão, se o livro não estiver emprestado
        txtDataDevolucao.Text = ""; // também mudamos a data de devolução para vazia
        txtNomeLeitor.Text = ""; // e o mesmo com o nome do leitor
        if (osLivros[indice].CodigoLeitorComLivro != "000000") // se o livro exibido estiver emprestado
        {
          int ondeLeitor = 0; // onde encontraremos o leitor futuramente
          var leitorProc = new Leitor(osLivros[indice].CodigoLeitorComLivro); // instanciamos o objeto do leitor procurado passando o seu código como parâmetro
          if (osLeitores.Existe(leitorProc, ref ondeLeitor)) // procuramos o leitor
          {
            txtLeitorComLivro.Text = osLivros[indice].CodigoLeitorComLivro; // preenchemos o campo leitor com livro
            txtNomeLeitor.Text     = osLeitores[ondeLeitor].NomeLeitor; // preenchemos o campo de nome do leitor como o nome do leitor encontrado
            txtDataDevolucao.Text  = osLivros[indice].DataDevolucao.ToShortDateString(); // preenchemos a data de devolução
          }
        }

        TestarBotoes(); // verificamos a validade dos botões
        stlbMensagem.Text = // alteramos a mensagem exibida para o usuário
          "Registro " + (osLivros.PosicaoAtual + 1) +
                     "/" + osLivros.Tamanho;
      }
    }
    private void LimparTela() // função que limpa os campos
    {
      txtCodigoLivro.Clear(); // limpa o codigo do livro
      txtTituloLivro.Clear(); // limpa o título

      txtLeitorComLivro.Text = "000000"; // deixa como '000000' o campo de leitor com livro
      txtDataDevolucao.Text = ""; // deixa vazio a data de devolução e o campo de nome do leitor
      txtNomeLeitor.Text = ""; // ^^

      dgvTipos.ClearSelection(); // limpamos a seleção do datagridview
    }

    private void TestarBotoes() // função que verifica a validade dos botões
    {
      btnInicio.Enabled = true; // habilita os botões
      btnAnterior.Enabled = true; 
      btnProximo.Enabled = true;
      btnUltimo.Enabled = true;
      if (osLivros.EstaNoInicio) // se a posição atual do vetor é a inicial , não tem por que deixar habilitado o botão 'anterior' e o de 'início'
      {                           // então desabilitamos os dois
        btnInicio.Enabled = false; 
        btnAnterior.Enabled = false;
      }
      if (osLivros.EstaNoFim) // se a posição atual do vetor é a final , não tem por que deixar habilitado o botão 'próximo' e o de 'último'
      {                          // então desabilitamos os dois
        btnProximo.Enabled = false;
        btnUltimo.Enabled = false;
      }
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
      // saímos do modo de navegação e entramos no modo de inclusão:
      osLivros.SituacaoAtual = Situacao.incluindo;

      // preparamos a tela para que seja possível digitar dados do novo livro
      LimparTela();

      // colocamos o cursor no campo chave
      txtCodigoLivro.Focus();

      // Exibimos mensagem no statusStrip para instruir o usuário a digitar dados
      stlbMensagem.Text = "Digite o código do novo livro";

      // habilitamos o botão salvar
      btnSalvar.Enabled = true; 
    }

    private void txtMatricula_Leave(object sender, EventArgs e) // ao sair do campo de código de livro
    {
      if (txtCodigoLivro.Text == "") // se o campo está vazio
        MessageBox.Show("Digite um código válido!"); // alertamos o usuário de que este valor é inválido
      else // se não está vazio
      {
        var procurado = new Livro(txtCodigoLivro.Text); // instanciamos o objeto da classe Livro passando o código digitado como parâmetro
        switch (osLivros.SituacaoAtual) // e verificamos qual a situação atual para agir de acordo com ela
        {
          case Situacao.incluindo: // se for uma inclusão
            if (osLivros.Existe(procurado, ref ondeIncluir))   // se já existe o código
            {
              MessageBox.Show("Código repetido; inclusão cancelada."); // alertamos o usuário
              osLivros.SituacaoAtual = Situacao.navegando; // voltamos para a situação original
              AtualizarTela(); // restaura o registro visível anteriormente
            }
            else // o código ainda não existe no vetor dados
            {
              txtTituloLivro.Focus(); // focamos no campo de título do livro
              stlbMensagem.Text = "Digite os demais dados. Após isso pressione [Salvar]"; // alteramos a mensagem exibida ao usuário
            }
            break; // saímos do switch
          case Situacao.pesquisando: // se for uma pesquisa
            int ondeAchou = 0;
            if (!osLivros.Existe(procurado, ref ondeAchou)) // se não existe o livro procurado
            {
              MessageBox.Show("Código não foi cadastrado ainda."); // alertamos o usuário
              AtualizarTela(); // atualizamos a tela
              osLivros.SituacaoAtual = Situacao.navegando; // voltamos para a situação original (navegando)
            }
            else  // encontrou o código procurado na posição ondeAchou
            {
              osLivros.PosicaoAtual = ondeAchou; // mudamos a posição atual
              AtualizarTela(); // atualizamos a tela
              osLivros.SituacaoAtual = Situacao.navegando; // voltamos para a situação original
            }
            break; // sai do switch
        }
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e) // click do botão salvar
    {

            int qualTipo = int.Parse(dgvTipos.CurrentRow.Cells[0].Value.ToString()); // o qual tipo será o valor do código da coluna selecionada no DataGridView
 
          if (osLivros.SituacaoAtual == Situacao.incluindo) // está no modo de inclusão
          {
            var novoDado = new Livro(txtCodigoLivro.Text, // instanciamos um novo objeto com os novos campos
                                   txtTituloLivro.Text, qualTipo,
                                   new DateTime(1899, 12, 31),
                                   "000000"); 
            osLivros.Incluir(novoDado, ondeIncluir); // incluimos este novo Livro
            // para mudar o registro com o qual trabalhamos no momento
            osLivros.PosicaoAtual = ondeIncluir; // mudamos a posição atual
            AtualizarTela(); // atualizamos a tela mostrando para o usuário o livro adicionado
            osLivros.SituacaoAtual = Situacao.navegando; // termina o modo de inclusão
          }
          else  // verificar se está editando
            if (osLivros.SituacaoAtual == Situacao.editando) // se é uma edição
            {
              osLivros[osLivros.PosicaoAtual] = new Livro(  // alteramos o objeto que está na tela do usuário, com índice igual a posição atual
                    txtCodigoLivro.Text, txtTituloLivro.Text,qualTipo,
                    osLivros[osLivros.PosicaoAtual].DataDevolucao,
                    osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro);
              osLivros.SituacaoAtual = Situacao.navegando; // voltamos para a situação original
              txtCodigoLivro.ReadOnly = false; // habilitamos para a escrita o campo de código de livro
              AtualizarTela(); // atualizamos a tela
            }
      btnSalvar.Enabled = false; // desabilitamos o botão salvar
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      // fecha o formulário mas antes dispara o evento FormClosing
      Close();  
    }

    private void FrmFunc_FormClosing(object sender, FormClosingEventArgs e)
    {
      osLivros.GravarDados(nomeArquivoLivros); // salva os dados nos arquivos de livros
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
            if (osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro == "000000") // se o livro não está emprestado
            {
                if (MessageBox.Show( // verificamos se o leitor realmente deseja excluir o livro
            "Deseja realmente excluir?", "Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    osLivros.Excluir(osLivros.PosicaoAtual); //se sim, excluímos o livro
                    if (osLivros.PosicaoAtual >= osLivros.Tamanho) // se a posição atual for maior ou igual a quantidade de registros
                        osLivros.PosicionarNoUltimo(); // posicionamos no último
                    AtualizarTela(); // atualizamos a tela
                }
            }
            else
                MessageBox.Show("O livro não pode ser excluído!\n Está emprestado para o leitor " + osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro,
                    "Exclusão cancelada", MessageBoxButtons.OK); // se o livro estivelr emprestado, alertamos o usuário sobre a situação e NÃO excluímos o livro
    }

    private void btnProcurar_Click(object sender, EventArgs e) // click do botão procurar
    {
      LimparTela(); // limpamos a tela
      osLivros.SituacaoAtual = Situacao.pesquisando; // mudamos a situação atual para a pesquisa
      txtCodigoLivro.Focus(); // focamos no campo de código do livro
      stlbMensagem.Text = "Digite o código do livro que busca"; // alteramos a mensagem exibida para o usuário
    }

    private void tpLista_Enter(object sender, EventArgs e) // entrada na tabpage de consulta
    {
      osLivros.ExibirDados(lsbLivros, "Código  Título                       Cód. Tipo      Data Dev.        Cód. Leitor Com Livro"); // exibimos os dados no listbox, com o cabeçalho
    }

    private void btnEditar_Click(object sender, EventArgs e) // click do botão editar
    {
      osLivros.SituacaoAtual = Situacao.editando; // mudamos a situação atual
      txtCodigoLivro.ReadOnly = true;  // para não permitir alterar a matrícula
      stlbMensagem.Text = "Modifique os campos desejados e pressione [Salvar]"; // alteramos a mensagem exibida ao usuário
      txtTituloLivro.Focus(); // focamos no campo de título do livro

      btnSalvar.Enabled = true; // habilitamos o botão salvar
    }

    private void btnCancelar_Click(object sender, EventArgs e) // click do botão cancelar
    {
      osLivros.SituacaoAtual = Situacao.navegando; // voltamos para a situação original (navegando)
      AtualizarTela(); // atualizamos a tela
      btnSalvar.Enabled = false; // desabilitamos o botão salvar
    }
  }
}

 
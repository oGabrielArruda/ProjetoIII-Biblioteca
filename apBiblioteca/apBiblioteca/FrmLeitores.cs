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
    VetorDados<Livro>  osLivros; // osLivros armazenará os dados lidos e terá os métodos de manutenção
    VetorDados<Leitor> osLeitores;
    int ondeIncluir = 0;        // global --> acessível na classe toda

    string nomeArquivoLeitores, nomeArquivoLivros;
    
    public FrmLeitores()
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

      osLeitores = new VetorDados<Leitor>(50); // instancia com vetor dados com 50 posições
      dlgAbrir.Title = "Selecione o arquivo com os dados de leitores";
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
      {
        nomeArquivoLeitores = dlgAbrir.FileName;
        osLeitores.LerDados(nomeArquivoLeitores);
        btnInicio.PerformClick();
      }

      osLivros = new VetorDados<Livro>(50); // instancia com vetor dados com 50 posições
      dlgAbrir.Title = "Selecione o arquivo com os dados de livros";
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
      {
        nomeArquivoLivros = dlgAbrir.FileName;
        osLivros.LerDados(nomeArquivoLivros);
      }
    }

    private void btnInicio_Click(object sender, EventArgs e)
    {
      osLeitores.PosicionarNoPrimeiro();
      AtualizarTela();
    }
    private void btnAnterior_Click(object sender, EventArgs e)
    {
      osLeitores.RetrocederPosicao();
      AtualizarTela();
    }
    private void btnProximo_Click(object sender, EventArgs e)
    {
      osLeitores.AvancarPosicao();
      AtualizarTela();
    }
    private void btnUltimo_Click(object sender, EventArgs e)
    {
      osLeitores.PosicionarNoUltimo();
      AtualizarTela();
    }

    private void AtualizarTela()
    {
      if (!osLeitores.EstaVazio)
      {
        Leitor oLeitor = osLeitores[osLeitores.PosicaoAtual];
        txtCodigoLeitor.Text = oLeitor.CodigoLeitor + "";
        txtNomeLeitor.Text   = oLeitor.NomeLeitor;
        txtEndereco.Text     = oLeitor.EnderecoLeitor;
        dgvLivros.RowCount   = oLeitor.QuantosLivrosComLeitor+1; 

        for (int umLivro = 0; 
                 umLivro < oLeitor.QuantosLivrosComLeitor; umLivro++)
        {
          int ondeLivro = -1;
          var livroProcurado = 
              new Livro(oLeitor.CodigoLivroComLeitor[umLivro]);
          if (osLivros.Existe(livroProcurado, ref ondeLivro))
          {
            Livro oLivro = osLivros[ondeLivro];
            dgvLivros.Rows[umLivro].Cells[0].Value = oLivro.CodigoLivro;
            dgvLivros.Rows[umLivro].Cells[1].Value = oLivro.TituloLivro;
            dgvLivros.Rows[umLivro].Cells[2].Value = oLivro.DataDevolucao.ToShortDateString();
            if (oLivro.DataDevolucao < DateTime.Now.Date)
               dgvLivros.Rows[umLivro].Cells[3].Value = "S";
            else
              dgvLivros.Rows[umLivro].Cells[3].Value = "N";
          }
        }

        TestarBotoes();
        stlbMensagem.Text =
          "Registro " + (osLeitores.PosicaoAtual + 1) +
                     "/" + osLeitores.Tamanho;
      }
    }
    private void LimparTela()
    {
      txtCodigoLeitor.Clear();
      txtNomeLeitor.Clear();
      txtEndereco.Text = "";
      dgvLivros.RowCount = 1;
    }

    private void TestarBotoes()
    {
      btnInicio.Enabled = true;
      btnAnterior.Enabled = true;
      btnProximo.Enabled = true;
      btnUltimo.Enabled = true;
      if (osLeitores.EstaNoInicio)
      {
        btnInicio.Enabled = false;
        btnAnterior.Enabled = false;
      }
      if (osLeitores.EstaNoFim)
      {
        btnProximo.Enabled = false;
        btnUltimo.Enabled = false;
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

      btnSalvar.Enabled = true;
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

    private void btnSair_Click(object sender, EventArgs e)
    {
      // fecha o formulário mas antes dispara o evento FormClosing
      Close();  
    }

    private void FrmFunc_FormClosing(object sender, FormClosingEventArgs e)
    {
      osLeitores.GravarDados(nomeArquivoLeitores);
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show(
             "Deseja realmente excluir?", "Exclusão",
             MessageBoxButtons.YesNo, 
             MessageBoxIcon.Warning) == DialogResult.Yes)
      {
        osLeitores.Excluir(osLeitores.PosicaoAtual);
        if (osLeitores.PosicaoAtual >= osLeitores.Tamanho)
           osLeitores.PosicionarNoUltimo();
        AtualizarTela();
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

 
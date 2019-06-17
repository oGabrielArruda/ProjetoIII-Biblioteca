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

      osLivros = new VetorDados<Livro>(50); // instancia com vetor dados com 50 posições
      dlgAbrir.Title = "Selecione o arquivo com os dados de livros";
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
      {
        nomeArquivoLivros = dlgAbrir.FileName;
        osLivros.LerDados(nomeArquivoLivros);
      }

      osLeitores = new VetorDados<Leitor>(50); // instancia com vetor dados com 50 posições
      dlgAbrir.Title = "Selecione o arquivo com os dados de leitores";
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
      {
        nomeArquivoLeitores = dlgAbrir.FileName;
        osLeitores.LerDados(nomeArquivoLeitores);
      }


        osTipos = new VetorDados<Tipo>(50);
        dlgAbrir.Title = "Selecione o arquivo com os tipos dos livros";
        if (dlgAbrir.ShowDialog() == DialogResult.OK)
        {
            nomeArquivoTipos = dlgAbrir.FileName;
            osTipos.LerDados(nomeArquivoTipos);
            ExibirTiposNoDgv();
            btnInicio.PerformClick();
        }

            if (FrmBiblioteca.Consulta)
            {
                tabControl1.SelectedIndex = 1;
                FrmBiblioteca.Consulta = false;
            }
    }

    private void ExibirTiposNoDgv()
    {
        dgvTipos.RowCount = osTipos.Tamanho;
        for(int i = 0; i< osTipos.Tamanho; i++)
         {
                dgvTipos.Rows[i].Cells[0].Value = osTipos[i].CodigoTipo;
                dgvTipos.Rows[i].Cells[1].Value = osTipos[i].DescricaoTipo;
         }
    }

    private void btnInicio_Click(object sender, EventArgs e)
    {
      osLivros.PosicionarNoPrimeiro();
      AtualizarTela();
    }
    private void btnAnterior_Click(object sender, EventArgs e)
    {
      osLivros.RetrocederPosicao();
      AtualizarTela();
    }
    private void btnProximo_Click(object sender, EventArgs e)
    {
      osLivros.AvancarPosicao();
      AtualizarTela();
    }
    private void btnUltimo_Click(object sender, EventArgs e)
    {
      osLivros.PosicionarNoUltimo();
      AtualizarTela();
    }

    private void AtualizarTela()
    {
      if (!osLivros.EstaVazio)
      {
        int indice = osLivros.PosicaoAtual;
        txtCodigoLivro.Text = osLivros[indice].CodigoLivro + "";
        txtTituloLivro.Text = osLivros[indice].TituloLivro;

      
        txtLeitorComLivro.Text = "000000";
        txtDataDevolucao.Text = "";
        txtNomeLeitor.Text = "";
        if (osLivros[indice].CodigoLeitorComLivro != "000000") // livro emprestado?
        {
          int ondeLeitor = 0;
          var leitorProc = new Leitor(osLivros[indice].CodigoLeitorComLivro);
          if (osLeitores.Existe(leitorProc, ref ondeLeitor))
          {
            txtLeitorComLivro.Text = osLivros[indice].CodigoLeitorComLivro;
            txtNomeLeitor.Text     = osLeitores[ondeLeitor].NomeLeitor;
            txtDataDevolucao.Text  = osLivros[indice].DataDevolucao.ToShortDateString();
          }
        }

        TestarBotoes();
        stlbMensagem.Text =
          "Registro " + (osLivros.PosicaoAtual + 1) +
                     "/" + osLivros.Tamanho;
      }
    }
    private void LimparTela()
    {
      txtCodigoLivro.Clear();
      txtTituloLivro.Clear();

      txtLeitorComLivro.Text = "000000";
      txtDataDevolucao.Text = "";
      txtNomeLeitor.Text = "";
    }

    private void TestarBotoes()
    {
      btnInicio.Enabled = true;
      btnAnterior.Enabled = true;
      btnProximo.Enabled = true;
      btnUltimo.Enabled = true;
      if (osLivros.EstaNoInicio)
      {
        btnInicio.Enabled = false;
        btnAnterior.Enabled = false;
      }
      if (osLivros.EstaNoFim)
      {
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

      btnSalvar.Enabled = true;
    }

    private void txtMatricula_Leave(object sender, EventArgs e)
    {
      if (txtCodigoLivro.Text == "")
        MessageBox.Show("Digite um código válido!");
      else
      {
        var procurado = new Livro(txtCodigoLivro.Text);
        switch (osLivros.SituacaoAtual)
        {
          case Situacao.incluindo:
            if (osLivros.Existe(procurado, ref ondeIncluir))   // se já existe o código
            {
              MessageBox.Show("Código repetido; inclusão cancelada.");
              osLivros.SituacaoAtual = Situacao.navegando;
              AtualizarTela(); // restaura o registro visível anteriormente
            }
            else // o código ainda não existe no vetor dados
            {
              txtTituloLivro.Focus();
              stlbMensagem.Text = "Digite os demais dados. Após isso pressione [Salvar]";
            }
            break;
          case Situacao.pesquisando:
            int ondeAchou = 0;
            if (!osLivros.Existe(procurado, ref ondeAchou))
            {
              MessageBox.Show("Código não foi cadastrado ainda.");
              AtualizarTela();
              osLivros.SituacaoAtual = Situacao.navegando;
            }
            else  // encontrou o código procurado na posição ondeAchou
            {
              osLivros.PosicaoAtual = ondeAchou;
              AtualizarTela();
              osLivros.SituacaoAtual = Situacao.navegando;
            }
            break;
        }
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {

            int qualTipo = int.Parse(dgvTipos.CurrentRow.Cells[0].Value.ToString());
 
          if (osLivros.SituacaoAtual == Situacao.incluindo) // está no modo de inclusão
          {
            var novoDado = new Livro(txtCodigoLivro.Text,
                                   txtTituloLivro.Text, qualTipo,
                                   new DateTime(1899, 12, 31),
                                   "000000");
            osLivros.Incluir(novoDado, ondeIncluir);
            // para mudar o registro com o qual trabalhamos no momento
            osLivros.PosicaoAtual = ondeIncluir;
            AtualizarTela();
            osLivros.SituacaoAtual = Situacao.navegando; // termina o modo de inclusão
          }
          else  // verificar se está editando
            if (osLivros.SituacaoAtual == Situacao.editando)
            {
              osLivros[osLivros.PosicaoAtual] = new Livro(
                    txtCodigoLivro.Text, txtTituloLivro.Text,qualTipo,
                    osLivros[osLivros.PosicaoAtual].DataDevolucao,
                    osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro);
              osLivros.SituacaoAtual = Situacao.navegando;
              txtCodigoLivro.ReadOnly = false;
              AtualizarTela();
            }
      btnSalvar.Enabled = false;
            dgvTipos.ReadOnly = false;
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      // fecha o formulário mas antes dispara o evento FormClosing
      Close();  
    }

    private void FrmFunc_FormClosing(object sender, FormClosingEventArgs e)
    {
      osLivros.GravarDados(nomeArquivoLivros);
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
            if (osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro == "000000") // se o livro não está emprestado
            {
                if (MessageBox.Show(
            "Deseja realmente excluir?", "Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    osLivros.Excluir(osLivros.PosicaoAtual);
                    if (osLivros.PosicaoAtual >= osLivros.Tamanho)
                        osLivros.PosicionarNoUltimo();
                    AtualizarTela();
                }
            }
            else
                MessageBox.Show("O livro não pode ser excluído!\n Está emprestado para o leitor " + osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro,
                    "Exclusão cancelada", MessageBoxButtons.OK);
    }

    private void btnProcurar_Click(object sender, EventArgs e)
    {
      LimparTela();
      osLivros.SituacaoAtual = Situacao.pesquisando;
      txtCodigoLivro.Focus();
      stlbMensagem.Text = "Digite o código do livro que busca";
    }

    private void tpLista_Enter(object sender, EventArgs e)
    {
      osLivros.ExibirDados(lsbLivros, "Código  Título");
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      osLivros.SituacaoAtual = Situacao.editando;
      txtCodigoLivro.ReadOnly = true;  // para não permitir alterar a matrícula
            dgvTipos.ReadOnly = false;
      stlbMensagem.Text = "Modifique os campos desejados e pressione [Salvar]";
      txtTituloLivro.Focus();

      btnSalvar.Enabled = true;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      osLivros.SituacaoAtual = Situacao.navegando;
      AtualizarTela();
      btnSalvar.Enabled = false;
    }
  }
}

 
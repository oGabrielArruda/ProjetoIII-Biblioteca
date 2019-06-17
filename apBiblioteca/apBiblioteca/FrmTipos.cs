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
    public partial class FrmTipos : Form
    {
        VetorDados<Tipo> osTipos;
        public FrmTipos()
        {
            InitializeComponent();
        }

        private void FrmTipos_Load(object sender, EventArgs e)
        {
            int indice = 0;
            barraDeFerramentas.ImageList = imlBotoes;
            foreach (ToolStripItem item in barraDeFerramentas.Items)
                if (item is ToolStripButton) // se não é separador:
                    (item as ToolStripButton).ImageIndex = indice++;

            osTipos = new VetorDados<Tipo>(50);
            if(dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                osTipos.LerDados(dlgAbrir.FileName);
                btnInicio.PerformClick();
            }
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
           osTipos.PosicionarNoPrimeiro();
            AtualizarTela();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            osTipos.RetrocederPosicao();
            AtualizarTela();
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            osTipos.AvancarPosicao();
            AtualizarTela();
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            osTipos.PosicionarNoUltimo();
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            if (!osTipos.EstaVazio)
            {
                int indice = osTipos.PosicaoAtual;
                txtCodigoTipo.Text = osTipos[indice].CodigoTipo.ToString();
                txtDescricao.Text = osTipos[indice].DescricaoTipo;
            }
            TestarBotoes();
        }
        private void LimparTela()
        {
            txtCodigoTipo.Clear();
            txtDescricao.Clear();
        }

        private void TestarBotoes()
        {
            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;
            if (osTipos.EstaNoInicio)
            {
                btnInicio.Enabled = false;
                btnAnterior.Enabled = false;
            }
            if (osTipos.EstaNoFim)
            {
                btnProximo.Enabled = false;
                btnUltimo.Enabled = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // saímos do modo de navegação e entramos no modo de inclusão:
            osTipos.SituacaoAtual = Situacao.incluindo;

            // preparamos a tela para que seja possível digitar dados do novo livro
            LimparTela();

            // colocamos o cursor no campo chave
            txtCodigoTipo.Focus();

            // Exibimos mensagem no statusStrip para instruir o usuário a digitar dados
            stlbMensagem.Text = "Digite o código do novo leitor";

            btnSalvar.Enabled = true;
            txtCodigoTipo.ReadOnly = false;
        }

        int ondeAchou = -1;
        int ondeIncluir = -1;
        private void txtCodigoTipo_Leave(object sender, EventArgs e)
        {
            switch (osTipos.SituacaoAtual)
            {
                case Situacao.incluindo:
                    var novoTipo = new Tipo(int.Parse(txtCodigoTipo.Text), "");
                    if (!osTipos.Existe(novoTipo, ref ondeIncluir))
                    {
                        stlbMensagem.Text = "Insira os outros campos e pressione salvar";
                        txtDescricao.ReadOnly = false;
                        txtDescricao.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Código repetido, tente novamente");
                        osTipos.SituacaoAtual = Situacao.navegando;
                        txtCodigoTipo.ReadOnly = true;
                        txtDescricao.ReadOnly = true;
                        btnInicio.PerformClick();
                    }
                    break;
                case Situacao.pesquisando:
                    var proc = new Tipo(int.Parse(txtCodigoTipo.Text), "");
                    if (osTipos.Existe(proc, ref ondeAchou))
                    {
                        osTipos.PosicaoAtual = ondeAchou;
                        AtualizarTela();
                    }
                    else
                    {
                        MessageBox.Show("Tipo não encontrado!");
                        btnInicio.PerformClick();
                    }
                    osTipos.SituacaoAtual = Situacao.navegando;
                    txtCodigoTipo.ReadOnly = true;
                    break;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (osTipos.SituacaoAtual)
            {
                case Situacao.incluindo:
                        var novo = new Tipo(int.Parse(txtCodigoTipo.Text), txtDescricao.Text);
                        osTipos.Incluir(novo, ondeIncluir);
                    osTipos.PosicaoAtual = ondeIncluir;
                    AtualizarTela();
                    osTipos.SituacaoAtual = Situacao.navegando;
                    txtCodigoTipo.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                    break;
                case Situacao.editando:
                    var editado = new Tipo(int.Parse(txtCodigoTipo.Text), txtDescricao.Text);
                    osTipos[osTipos.PosicaoAtual] = editado;
                    AtualizarTela();
                    osTipos.SituacaoAtual = Situacao.navegando;
                    txtCodigoTipo.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                    break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCodigoTipo.ReadOnly = false;
            txtDescricao.ReadOnly = false;
            btnSalvar.Enabled = true;
            stlbMensagem.Text = "Modifique os campos desejados e então pressione [salvar]";
            osTipos.SituacaoAtual = Situacao.editando;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            txtCodigoTipo.ReadOnly = false;
            stlbMensagem.Text = "Digite o código do tipo procurado";
            osTipos.SituacaoAtual = Situacao.pesquisando;
        }

        private void FrmTipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            osTipos.GravarDados(dlgAbrir.FileName);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            osTipos.SituacaoAtual = Situacao.navegando;
            AtualizarTela();
            btnSalvar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja excluir esse tipo?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                osTipos.Excluir(osTipos.PosicaoAtual);
            }
        }
    }
}

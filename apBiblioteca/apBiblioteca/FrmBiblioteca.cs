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
  public partial class FrmBiblioteca : Form
  {

    FrmLivros frmLivros;
    FrmLeitores frmLeitores;
    FrmTipos frmTipos;
    FrmEmprestimos frmEmprestimos;
    FrmDevolucao frmDevolucao;
    public static bool Consulta = false;

    public FrmBiblioteca()
    {
      InitializeComponent();
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e) // click do botão sair
    {
      Close(); // fecha o formulário
    }

    private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmLivros = new FrmLivros(); // instancia o formulário
      frmLivros.Show(); // exibe o formulário
    }

    private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmLeitores = new FrmLeitores(); // instancia o formulário 
            frmLeitores.Show(); // exibe o formulário
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTipos = new FrmTipos(); // instancia o formulário
            frmTipos.Show(); // exibe o formulário
        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmprestimos = new FrmEmprestimos(); // instancia o formulário
            frmEmprestimos.Show(); // exibe o formulário
        }

        private void devoluçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucao = new FrmDevolucao(); // instancia o formulário
            frmDevolucao.Show(); // exibe o formulário
        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta = true; // como será aberta uma aba em outro formulário, usaremos a variàvel global consulta para abrir a TabPage futuramente
            frmLivros = new FrmLivros(); // instancia o formulário
            frmLivros.Show(); // exibe o formulário                  
        }

        private void leitoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta = true; // como será aberta uma aba em outro formulário, usaremos a variàvel global consulta para abrir a TabPage futuramente
            frmLeitores = new FrmLeitores(); // instancia o formulário
            frmLeitores.Show(); // exibe o formulário  
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta = true; // como será aberta uma aba em outro formulário, usaremos a variàvel global consulta para abrir a TabPage futuramente
            frmTipos = new FrmTipos(); // instancia o formulário
            frmTipos.Show(); // exibe o formulário  
        }
    }
}

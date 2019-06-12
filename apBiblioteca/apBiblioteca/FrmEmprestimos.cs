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
    public partial class FrmEmprestimos : Form
    {

        Livro oLivro;
        Leitor oLeitor;
        VetorDados<Leitor> osLeitores;
        VetorDados<Livro> osLivros;
        public FrmEmprestimos()
        {
            InitializeComponent();
        }


        private void FrmEmprestimos_Load(object sender, EventArgs e)
        {
            oLivro = new Livro();
            oLeitor = new Leitor();
            osLeitores = new VetorDados<Leitor>(50);
            osLivros = new VetorDados<Livro>(50);
        }

        private void Emprestar_Click(object sender, EventArgs e)
        {
            oLeitor.QuantosLivrosComLeitor++;
          //  oLeitor.CodigoLivroComLeitor[] == "";
        }

        private void txtCodLeitor_Leave(object sender, EventArgs e)
        {
            Leitor qualLeitor = new Leitor(txtCodLeitor.Text);
            int onde = -1;
            if (!osLeitores.Existe(qualLeitor, ref onde))
            {
                MessageBox.Show("O leitor não está cadastrado!");
                LimparFocar(txtCodLeitor);
            }
            else
                oLeitor = qualLeitor;
        }

        private void txtCodLivro_Leave(object sender, EventArgs e)
        {
            Livro qualLivro = new Livro(txtCodLivro.Text);
            int onde = -1;
            if (osLivros.Existe(qualLivro, ref onde))
            {
                if (qualLivro.CodigoLeitorComLivro == "000000")
                {
                    oLivro = qualLivro;
                }
                else
                {
                    MessageBox.Show("Livro já está emprestado!");
                    LimparFocar(txtCodLivro);
                }
            }
            else
            {
                MessageBox.Show("O livro não está cadastrado!");
                LimparFocar(txtCodLivro);
            }                
        }

        void LimparFocar(TextBox qualTxt)
        {
            qualTxt.Clear();
            qualTxt.Focus();
        }
    }
}

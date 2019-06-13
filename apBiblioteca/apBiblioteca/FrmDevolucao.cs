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
    public partial class FrmDevolucao : Form
    {
        VetorDados<Livro> osLivros;
        VetorDados<Leitor> osLeitores;
        Livro oLivro;
        Leitor oLeitor;
        string nomeArqLivros, nomeArqLeitores;
        public FrmDevolucao()
        {
            InitializeComponent();
        }

        private void FrmDevolucao_Load(object sender, EventArgs e)
        {
            osLivros = new VetorDados<Livro>(50);
            dlgAbrir.Title = "Abra o arquivo texto dos livros.";
            if(dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                nomeArqLivros = dlgAbrir.FileName;
                osLivros.LerDados(nomeArqLivros);
            }

            osLeitores = new VetorDados<Leitor>(50);
            dlgAbrir.Title = "Abra o arquivo texto dos leitores.";
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                nomeArqLeitores = dlgAbrir.FileName;
                osLeitores.LerDados(nomeArqLeitores);
            }
        }

        private void txtCodLivro_Leave(object sender, EventArgs e)
        {
            Livro proc = new Livro(txtCodLivro.Text); // livro procurado pelo seu código
            int ondeLivro = -1;
            if (osLivros.Existe(proc, ref ondeLivro)) // se o livro existe
            {
                oLivro = osLivros[ondeLivro]; // atribuímos à variável oLivro, o livro encontrado
                if(oLivro.CodigoLeitorComLivro == "000000") // se o livro não está emprestado para ninguém
                {
                    MessageBox.Show("O livro digitado não está emprestado!", "Devolução cancelada", MessageBoxButtons.OK); // alertamos o leitor
                    LimparFocar(txtCodLivro); // limpamos e focamos no campo do código do livro
                }
            }
            else // se o livro não existe
            {
                MessageBox.Show("O código digitado não existe!", "Devolução cancelada", MessageBoxButtons.OK); // alertamos o usuário
                LimparFocar(txtCodLivro); //  limpamos e focamos no campo do código do livro
            }                
        }

        private void btnDevolve_Click(object sender, EventArgs e)
        {
            AcharLeitor(); // achamos o leitor que está devolvendo o livro
            oLeitor.QuantosLivrosComLeitor--; // diminuímos sua quantidade de livros
            oLivro.CodigoLeitorComLivro = ""; // código vazio, pois o livro não está mais emprestado 
        }


        void AcharLeitor()
        {
            string codigoLeitor = oLivro.CodigoLeitorComLivro;
            Leitor proc = new Leitor(codigoLeitor);
            int ondeLeitor = -1;
            if (osLeitores.Existe(proc, ref ondeLeitor))
                 oLeitor = osLeitores[ondeLeitor];
        }

        void LimparFocar(TextBox qualTxt)
        {
            qualTxt.Clear();
            qualTxt.Focus();
        }
    }
}

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

        Livro oLivro; // declaramos o objeto oLivro do tipo Livro
        Leitor oLeitor; // declaramos o objeto oLeitor do tipo Leitor
        DateTime dataDev; // declaramos à variavel 'dataDev' do tipo DateTime
         
        VetorDados <Leitor> osLeitores; // declaramos o objeto osLivros do tipo VetorDados com o registro de Leitor
        VetorDados<Livro> osLivros; // declaramos o objeto osLivros do tipo VetorDados com o registro de Livro
        string nomeArqLivros, nomeArqLeitores; // string dos nomes dos arquivos abertos

        public FrmEmprestimos()
        {
            InitializeComponent();
        }


        private void FrmEmprestimos_Load(object sender, EventArgs e) 
        {
            osLivros = new VetorDados<Livro>(50); // instancia-se a classe VetorDados com a classe livro como base
            dlgAbrir.Title = "Abra o arquivo texto de livros.";
            if(dlgAbrir.ShowDialog() == DialogResult.OK) //  o arquivo de livros é aberto
            {
                nomeArqLivros = dlgAbrir.FileName;
                osLivros.LerDados(nomeArqLivros); // os dados do arquivo de livros é lido
            }

            osLeitores = new VetorDados<Leitor>(50); // instancia-se a classe VetorDados com a classe leitor como base
            dlgAbrir.Title = "Abra o arquivo de leitores.";
            if(dlgAbrir.ShowDialog() == DialogResult.OK)// o arquivo de leitores é aberto
            {
                nomeArqLeitores = dlgAbrir.FileName;
                osLeitores.LerDados(nomeArqLeitores);
            }
        }


        private void txtCodLeitor_Leave(object sender, EventArgs e) // ao sair do campodo código do leitor
        {
            Leitor qualLeitor = new Leitor(txtCodLeitor.Text); 
            int ondeLeitor = -1;
            if (!osLeitores.Existe(qualLeitor, ref ondeLeitor)) // se NÃO existe o leitor com o referido código
            {
                MessageBox.Show("O leitor não está cadastrado!"); // alertamos o leitor
                LimparFocar(txtCodLeitor); // limpamos e focamos o campo do código do leitor
            }
            else // se existe o leitor
            {
                oLeitor = osLeitores[ondeLeitor]; // atríbuimos o leitor desejado à varíavel oLeitor
                HabilitarBtn();// tentamos habilitar o botão
            }
                
        }

        private void txtCodLivro_Leave(object sender, EventArgs e) // ao sair do campo do código do livro
        {
            Livro qualLivro = new Livro(txtCodLivro.Text);
            int ondeLivro = -1;

            if (osLivros.Existe(qualLivro, ref ondeLivro)) // verifica-se se o código existe
            {
                oLivro = osLivros[ondeLivro]; // se existe, atribuí-se ele ao livro que será emprestado
                if (oLivro.CodigoLeitorComLivro == "000000") // se o livro NÃO está emprestado
                {
                    HabilitarBtn(); // habilitamos o botão (ou tentamos, pois há restrições no método de habilitar)
                }
                else //se o livro já está emprestado
                {
                    MessageBox.Show("Livro já está emprestado!"); // alertamos o usuário
                    LimparFocar(txtCodLivro); // limpamos e focamos no campo do código do livro
                }
            }
            else // se o livro não existe
            {
                MessageBox.Show("O livro não está cadastrado!"); // avisamos ao leitor que o livro não está cadastrado no "sistema"
                LimparFocar(txtCodLivro); // limpamos e focamos no campó do código do livro
            }                
        }

        private void mtxtData_Leave(object sender, EventArgs e) // ao sair do campo da data de devolução
        {
                dataDev = Convert.ToDateTime(mtxtData.Text); // atríbuimos à data de devolução a data digitada
                HabilitarBtn(); // tentamos habilitar o botão
        }

        private void Emprestar_Click(object sender, EventArgs e) // click do botão emprestar
        {
            oLeitor.CodigoLivroComLeitor[oLeitor.QuantosLivrosComLeitor] = oLivro.CodigoLivro; // atribuimos ao array de livros com o leitor, o código
                                                                      // do novo livro emprestado no índice de quantos livros o leitor pegou emprestado
                                                                     
            oLeitor.QuantosLivrosComLeitor++; //somamos mais 1 na quantidade de livros com o leitor, pois foi emprestado mais um nesse momento
            oLivro.CodigoLeitorComLivro = oLeitor.CodigoLeitor; // alteramos o CódigoLeitorComLivro do livro para o código do leitor que o pegou
            oLivro.DataDevolucao = dataDev; // altera a data de devolução para a digitada pelo usuário

            btnEmprestar.Enabled = false; // desabilitamos o botão de empréstimo
            LimparTela(); // limpamos a tela
            txtCodLeitor.Focus(); // focamos no campo do código do leitors
            MessageBox.Show("O livro " + oLivro.TituloLivro + " foi emprestado para " + oLeitor.NomeLeitor + " com sucesso!"); // alertamos ao usuário que o empréstimo foi realizado
        }

        private void FrmEmprestimos_FormClosing(object sender, FormClosingEventArgs e) // ao fechar o formulário
        {
            osLeitores.GravarDados(nomeArqLeitores); // salvamos os dados nos arquivos texto de leitores e de livros
            osLivros.GravarDados(nomeArqLivros);
        }

        void LimparFocar(TextBox qualTxt) // função de limpar e focar com TextBox
        {
            qualTxt.Clear(); // limpar
            qualTxt.Focus(); // focar  :)
        }

        void LimparFocar(MaskedTextBox qualMtxt) // função de limpar e focar com MaskedTextBox (data)
        {
            qualMtxt.Clear(); // limpar
            qualMtxt.Focus(); // focar :)
        }

        void LimparTela() // função que limpa a tela
        {
            txtCodLeitor.Clear(); // limpa o campo de código de leitor
            txtCodLivro.Clear(); // o campo de código de livro
            mtxtData.Clear(); // e o campo da data
        }

        void HabilitarBtn() // função de habilitar o botão de empréstimo
        {
            if(txtCodLeitor.Text != "" && txtCodLivro.Text != "" && mtxtData.Text != "") // só habilitamos se não houver nenhum campo vazio
            {
                btnEmprestar.Enabled = true;  // habilitamos o botão
            }
        }
    }
}

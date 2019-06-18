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
        VetorDados<Livro> osLivros; // declaramos o objeto osLivros do tipo VetorDados com o registro de Livro
        VetorDados<Leitor> osLeitores; // declaramos o objeto osLivros do tipo VetorDados com o registro de Leitor
        Livro oLivro; // declaramos o objeto oLivro do tipo Livro
        Leitor oLeitor; // declaramos o objeto oLeitor do tipo Leitor
        string nomeArqLivros, nomeArqLeitores; // string dos nomes dos arquivos abertos
        public FrmDevolucao()
        {
            InitializeComponent();
        }

        private void FrmDevolucao_Load(object sender, EventArgs e)
        {
            osLivros = new VetorDados<Livro>(50); // instanciamos o objeto 'osLivros'
            dlgAbrir.Title = "Abra o arquivo texto dos livros."; // mudamos o título do OpenFileDialog para o usuário saber qual arquivo deve ser aberto
            if(dlgAbrir.ShowDialog() == DialogResult.OK) // se abriu o arquivo
            {
                nomeArqLivros = dlgAbrir.FileName; // string do nome do arquivo dos livros recebe o nome do arquivo aberto
                osLivros.LerDados(nomeArqLivros); // lemos os dados do arquivo aberto
            }

            osLeitores = new VetorDados<Leitor>(50); // instanciamos o objeto 'osLivros'
            dlgAbrir.Title = "Abra o arquivo texto dos leitores."; // mudamos o título do OpenFileDialog para o usuário saber qual arquivo deve ser aberto
            if (dlgAbrir.ShowDialog() == DialogResult.OK) // se abriu o arquivo
            {
                nomeArqLeitores = dlgAbrir.FileName; // string do nome do arquivo dos livros recebe o nome do arquivo aberto
                osLeitores.LerDados(nomeArqLeitores); // lemos os dados do arquivo aberto
            }
        }

        private void txtCodLeitor_Leave(object sender, EventArgs e)
        {
            Leitor proc = new Leitor(txtCodLeitor.Text); // váriavel do tipo leitor com o código digitado passado como parâmetro
            int onde = -1; 
            if (osLeitores.Existe(proc, ref onde)) // se o leitor procurado existe
            {
                if (osLeitores[onde].QuantosLivrosComLeitor != 0) // se o leitor tem algum livro emprestado
                {
                    oLeitor = osLeitores[onde]; // atribuímos a variável oLeitor o valor do leitor encontrado
                    ExibirNoCBX(oLeitor); // exibimos os livros emprestados a este leitor no combobox
                }
                else //se o leitor não tem nenhum livro emprestado
                {
                    MessageBox.Show("O leitor digitado não tem nenhum livro!"); // notificamos o usuário
                    LimparFocar(txtCodLeitor); // limpamos e focamos o campo do código do leitor
                }                    
            }
            else // se o código do leitor não existe no arquivo texto
            {
                MessageBox.Show("O código do leitor não existe"); // notificamos o usuário
                LimparFocar(txtCodLeitor); // limpamos e focamos o campo do código do leitor
            }                
        }

        void ExibirNoCBX(Leitor qualLeitor)
        {
            for(int i = 0; i < qualLeitor.QuantosLivrosComLeitor; i++) // enquanto índice é menor que a quantidade de livros com o leitor
            {
                Livro livroVez = new Livro(qualLeitor.CodigoLivroComLeitor[i]); // instanciamos a variável livroVez passando o CodigoLivroLeitor como parâmetor
                int onde = -1;
                if(osLivros.Existe(livroVez, ref onde)) // se o livro procurado ( livroVez ) existe
                     cbxLivros.Items.Add(osLivros[onde].TituloLivro); // exibimos o título do livro no comboBox
            }
        }


        private void btnDevolve_Click(object sender, EventArgs e)
        {
            AcharLivro(); // achamos o livro escolhido
            Devolver(); // chamamos o método devolver
            cbxLivros.Items.Clear(); // limpa a combo box
        }


        void AcharLivro()
        {
            string codigo = oLeitor.CodigoLivroComLeitor[cbxLivros.SelectedIndex]; // atribuìmos à string 'código' o código do livro escolhido
            Livro proc = new Livro(codigo); 
            int onde = -1;
            if (osLivros.Existe(proc, ref onde)) // se o Livro procurado existe
                oLivro = osLivros[onde]; // atrbuímos ao 'oLivro' o livro encontrado
        }

        void Devolver()
        {
              for(int i = 0; i < oLeitor.QuantosLivrosComLeitor; i++) // enquanto o índice for menor que a quantidade de livros com o leitor
              {
                  if(oLeitor.CodigoLivroComLeitor[i] == oLivro.CodigoLivro) // se o código do livro com leitor for igual ao código do livro que será devolvido
                  {
                    for (int y = i; y < oLeitor.QuantosLivrosComLeitor; y++) //enquanto o índice 'y' for menor que a quantidade de livros com o leitor
                        oLeitor.CodigoLivroComLeitor[y] = oLeitor.CodigoLivroComLeitor[y + 1]; // excluímos este índice no vetor
                    oLeitor.QuantosLivrosComLeitor--; // diminuímos a quantidade de livros com o leitor, pois ele devolveu um deles
                    oLivro.CodigoLeitorComLivro = ""; // deixamos vazio o atributo de CodigoLeitorComLivro do livro devolvido
                    if (oLivro.DataDevolucao < DateTime.Now.Date) // se a data de hoje for maior que a data de devolução
                        MessageBox.Show("O livro " + oLivro.TituloLivro +  " foi devolvido com atraso!", "Livro devolvido!"); // alertamos que o livro foi devolvido com atraso
                    else // se a data de devolução for depois do dia de hoje
                        MessageBox.Show("O livro " + oLivro.TituloLivro  + " foi devolvido dentro do prazo!", "Livro devolvido!"); // alertamos o leitor que o livro foi devolvido no prazo
                  } 
              }
            LimparFocar(txtCodLeitor); // limpamos o campo do código do leitor
            cbxLivros.Items.Clear(); // limpamos a combo box
            btnDevolve.Enabled = false; // desabilitamos o botão de devolução

        }

        private void FrmDevolucao_FormClosing(object sender, FormClosingEventArgs e)  // quando o formulário está fechando
        {
            osLeitores.GravarDados(nomeArqLeitores); // gravamos os dados no arquivo de leitores
            osLivros.GravarDados(nomeArqLivros); // gravamos os dados no arquivo de livros
        }

        private void cbxLivros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnDevolve.Enabled = true;
        }

        void LimparFocar(TextBox qualTxt) // método de limpar e focar algum textbox passado como parâmetro
        {
            qualTxt.Clear(); // limpa
            qualTxt.Focus(); // foca 
        }
    }
}

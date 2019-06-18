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
            // -- coloca as imagens nos botões -- //
            int indice = 0;
            barraDeFerramentas.ImageList = imlBotoes;
            foreach (ToolStripItem item in barraDeFerramentas.Items)
                if (item is ToolStripButton) // se não é separador:
                    (item as ToolStripButton).ImageIndex = indice++;
            // ----------------------------------- //
            osTipos = new VetorDados<Tipo>(50); // instancia o objeto 'osTipos' na classe VetorDados usando a classe Tipo como registro
            if(dlgAbrir.ShowDialog() == DialogResult.OK) // se abriu o arquvio
            {
                osTipos.LerDados(dlgAbrir.FileName); // lemos os dados do arquivo texto de tipos
                btnInicio.PerformClick(); // chamamos o evento do click do botão início
            }

            if (FrmBiblioteca.Consulta) // se é uma consulta
            {
                tabControl1.SelectedIndex = 1; // mudamos para a tabpage de lista ( consulta )
                FrmBiblioteca.Consulta = false; // deixamos a variável de Consulta como falsa
            }
        }


        private void btnInicio_Click(object sender, EventArgs e) // click do botão de início
        {
           osTipos.PosicionarNoPrimeiro(); // deixa a posição atual no primeiro índice do vetor
            AtualizarTela(); // atualiza a tela para o usuário
        }
        private void btnAnterior_Click(object sender, EventArgs e) // click do botão de voltar um
        {
            osTipos.RetrocederPosicao(); // deixa a posição atual no índice anterior ao exibido na tela
            AtualizarTela(); // atualiza a tela para o usuário
        }
        private void btnProximo_Click(object sender, EventArgs e) // click do botão de próximo
        {
            osTipos.AvancarPosicao(); // deixa a posição atual no indíce posterior ao exibido na tela
            AtualizarTela(); // atualiza a tela para o usuário
        }
        private void btnUltimo_Click(object sender, EventArgs e) // click no botão de "último"
        {
            osTipos.PosicionarNoUltimo(); // deixa a posição atual no último índice do vetor
            AtualizarTela(); // atualiza a tela para o usuário
        }

        private void AtualizarTela() // função que atualiza a tela e exibe os campos para o usuário
        {
            if (!osTipos.EstaVazio) // se o vetor de tipos NÃO está vazio
            {
                int indice = osTipos.PosicaoAtual;  // atribuímos à índice o valor da posição atual (exibida na tela)
                txtCodigoTipo.Text = osTipos[indice].CodigoTipo.ToString(); // alteramos o campo de código do tipo para o código do tipo no índice
                txtDescricao.Text = osTipos[indice].DescricaoTipo; // fazemos o mesmo com o campo de descirção
            }
            TestarBotoes(); // verificamos a validade dos botões
        }
        private void LimparTela() // função que limpa a tela
        {
            txtCodigoTipo.Clear(); // limpa o campo de código do tipo
            txtDescricao.Clear(); // e também o campo da descrição do tipo
        }

        private void TestarBotoes() // função que verifica a validade dos botões
        {
            btnInicio.Enabled = true; // habilitamos os botões
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;
            if (osTipos.EstaNoInicio) // se a posição atual do vetor é a inicial , não tem por que deixar habilitado o botão 'anterior' e o de 'início'
            {                         // então desabilitamos os dois
                btnInicio.Enabled = false;  
                btnAnterior.Enabled = false;
            }
            if (osTipos.EstaNoFim)  // se a posição atual do vetor é a final , não tem por que deixar habilitado o botão 'próximo' e o de 'último'
            {                      // então desabilitamos os dois
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
        private void txtCodigoTipo_Leave(object sender, EventArgs e) // evento disparado na saída do campo de código do tipo
        {
            switch (osTipos.SituacaoAtual) // verificamos a situação
            {
                case Situacao.incluindo: // se for uma inclusão
                    var novoTipo = new Tipo(int.Parse(txtCodigoTipo.Text), ""); // instanciamos um novo objeto da classe tipo passando o código como parâmetro
                    if (!osTipos.Existe(novoTipo, ref ondeIncluir)) // se não existe o código
                    {
                        stlbMensagem.Text = "Insira os outros campos e pressione salvar";  // mudamos a mensagem exibida ao usuário
                        txtDescricao.ReadOnly = false; // liberamos o campo da descrição
                        txtDescricao.Focus(); 
                    }
                    else // se existe o código
                    {
                        MessageBox.Show("Código repetido, tente novamente"); // alertamos o usuário
                        osTipos.SituacaoAtual = Situacao.navegando; // mudamos a situa~ção atual
                        txtCodigoTipo.ReadOnly = true;
                        txtDescricao.ReadOnly = true;
                        btnInicio.PerformClick();
                    }
                    break; // sai do switch
                case Situacao.pesquisando: // se for uma pesquisa
                    var proc = new Tipo(int.Parse(txtCodigoTipo.Text), "");  // instanciamos um novo objeto da classe tipo passando o código como parâmetro
                    if (osTipos.Existe(proc, ref ondeAchou)) // se achou o tipo procurado
                    {
                        osTipos.PosicaoAtual = ondeAchou; // mudamos a posicao atual
                        AtualizarTela(); // e atualizamos a tela exibindo o tipo encontrado
                    }
                    else // se não achou
                    {
                        MessageBox.Show("Tipo não encontrado!"); // avisamos o usuário
                        btnInicio.PerformClick();
                    }
                    osTipos.SituacaoAtual = Situacao.navegando; // mudamos a situação para a original (navegando)
                    txtCodigoTipo.ReadOnly = true;
                    break; // sai do swicth
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) // click do botão salvar
        {
            switch (osTipos.SituacaoAtual) // verificamos as diferentes situações
            {
                case Situacao.incluindo: // se for uma inclusão
                        var novo = new Tipo(int.Parse(txtCodigoTipo.Text), txtDescricao.Text); // instanciamos um novo objeto da classe tipo passando o código e a descrição como parâmetros
                        osTipos.Incluir(novo, ondeIncluir); // incluímos o novo objeto na posição definida
                    osTipos.PosicaoAtual = ondeIncluir; // mudamos a posição atual para a posição de inclusão
                    AtualizarTela(); // atualizamos a tela exibindo o Tipo adicionado
                    osTipos.SituacaoAtual = Situacao.navegando; // mudamos a situação atual para a original (navgenado)
                    txtCodigoTipo.ReadOnly = true; // não deixamos que tenha novas alterações nos campos
                    txtDescricao.ReadOnly = true; // ^^
                    break; // sai do switch
                case Situacao.editando: // se for uma edição
                    var editado = new Tipo(int.Parse(txtCodigoTipo.Text), txtDescricao.Text); // instanciamos um novo objeto da classe tipo passando o código e a descrição como parâmetros
                    osTipos[osTipos.PosicaoAtual] = editado; // alteramos o Tipo que está na tela pelo Tipo que foi editado
                    AtualizarTela(); // atualizamos a tela
                    osTipos.SituacaoAtual = Situacao.navegando; // voltamos para a situação original
                    txtCodigoTipo.ReadOnly = true; // não deixamos que tenha novas alterações nos campos
                    txtDescricao.ReadOnly = true; // ^^
                    break; // sai do switch
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) // click do botão editar
        {
            txtCodigoTipo.ReadOnly = false; // habilitamos os campos
            txtDescricao.ReadOnly = false;
            btnSalvar.Enabled = true;
            stlbMensagem.Text = "Modifique os campos desejados e então pressione [salvar]"; // mudamos a mensagem exibida ao usuário
            osTipos.SituacaoAtual = Situacao.editando; // mudamos para a situação de edição
        }

        private void btnProcurar_Click(object sender, EventArgs e) // click do botão procurar
        {
            txtCodigoTipo.ReadOnly = false; // habilitamos o campo de código do tipo
            stlbMensagem.Text = "Digite o código do tipo procurado"; // mudamos a mensagem exibida ao usuário
            osTipos.SituacaoAtual = Situacao.pesquisando; // mudamos para a situação de pesquisa
        }

        private void FrmTipos_FormClosing(object sender, FormClosingEventArgs e) // evento disparado quando o formulário está fechando
        {
            osTipos.GravarDados(dlgAbrir.FileName); // salvamos os tipos no arquivo texto de tipos
        }

        private void btnCancelar_Click(object sender, EventArgs e) // click do botão cancelar
        {
            osTipos.SituacaoAtual = Situacao.navegando; // mudamos a situação atual para a situação navegando
            AtualizarTela(); // atualizamos a tela
            btnSalvar.Enabled = false; // desabilitamos o botão salvar
        }

        private void btnSair_Click(object sender, EventArgs e) // click do botão sair
        {
            Close(); // fecha o formulário
        }

        private void btnExcluir_Click(object sender, EventArgs e) // click do botão excluir
        {
            if(MessageBox.Show("Tem certeza que deseja excluir esse tipo?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes) // verifica se o usuário deseja realmente excluir o campo
            {
                osTipos.Excluir(osTipos.PosicaoAtual); // exclui o tipo exibido na tela
            }
        }

        private void tpLista_Enter(object sender, EventArgs e) // entrada na tabpage de consulta
        {
            osTipos.ExibirDados(lsbLista, "Código  Nome Tipo"); // exibe no listbox os dados dos Tipos, com o cabeçalho
        }
    }
}

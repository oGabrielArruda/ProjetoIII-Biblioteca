namespace apBiblioteca
{
  partial class FrmLivros
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivros));
      this.barraDeFerramentas = new System.Windows.Forms.ToolStrip();
      this.btnInicio = new System.Windows.Forms.ToolStripButton();
      this.btnAnterior = new System.Windows.Forms.ToolStripButton();
      this.btnProximo = new System.Windows.Forms.ToolStripButton();
      this.btnUltimo = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.btnProcurar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.btnNovo = new System.Windows.Forms.ToolStripButton();
      this.btnEditar = new System.Windows.Forms.ToolStripButton();
      this.btnCancelar = new System.Windows.Forms.ToolStripButton();
      this.btnSalvar = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.btnExcluir = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.btnSair = new System.Windows.Forms.ToolStripButton();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tpCadastro = new System.Windows.Forms.TabPage();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtDataDevolucao = new System.Windows.Forms.TextBox();
      this.txtNomeLeitor = new System.Windows.Forms.TextBox();
      this.txtLeitorComLivro = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.grbTipoLivro = new System.Windows.Forms.GroupBox();
      this.txtTituloLivro = new System.Windows.Forms.TextBox();
      this.txtCodigoLivro = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tpLista = new System.Windows.Forms.TabPage();
      this.lsbLivros = new System.Windows.Forms.ListBox();
      this.ssMensagem = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.stlbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
      this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
      this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
      this.rbTipo00 = new System.Windows.Forms.RadioButton();
      this.rbTipo01 = new System.Windows.Forms.RadioButton();
      this.rbTipo02 = new System.Windows.Forms.RadioButton();
      this.rbTipo03 = new System.Windows.Forms.RadioButton();
      this.rbTipo04 = new System.Windows.Forms.RadioButton();
      this.rbTipo05 = new System.Windows.Forms.RadioButton();
      this.rbTipo06 = new System.Windows.Forms.RadioButton();
      this.rbTipo07 = new System.Windows.Forms.RadioButton();
      this.rbTipo08 = new System.Windows.Forms.RadioButton();
      this.barraDeFerramentas.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tpCadastro.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.grbTipoLivro.SuspendLayout();
      this.tpLista.SuspendLayout();
      this.ssMensagem.SuspendLayout();
      this.SuspendLayout();
      // 
      // barraDeFerramentas
      // 
      this.barraDeFerramentas.BackColor = System.Drawing.Color.Silver;
      this.barraDeFerramentas.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.barraDeFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator1,
            this.btnProcurar,
            this.toolStripSeparator2,
            this.btnNovo,
            this.btnEditar,
            this.btnCancelar,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnExcluir,
            this.toolStripSeparator4,
            this.btnSair});
      this.barraDeFerramentas.Location = new System.Drawing.Point(0, 0);
      this.barraDeFerramentas.Name = "barraDeFerramentas";
      this.barraDeFerramentas.Size = new System.Drawing.Size(611, 38);
      this.barraDeFerramentas.TabIndex = 0;
      this.barraDeFerramentas.Text = "toolStrip1";
      // 
      // btnInicio
      // 
      this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
      this.btnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnInicio.Name = "btnInicio";
      this.btnInicio.Size = new System.Drawing.Size(40, 35);
      this.btnInicio.Text = "Início";
      this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnInicio.ToolTipText = "Vai para o início dos dados";
      this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
      // 
      // btnAnterior
      // 
      this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
      this.btnAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnAnterior.Name = "btnAnterior";
      this.btnAnterior.Size = new System.Drawing.Size(54, 35);
      this.btnAnterior.Text = "Anterior";
      this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnAnterior.ToolTipText = " Vai ao registro anterior";
      this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
      // 
      // btnProximo
      // 
      this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
      this.btnProximo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnProximo.Name = "btnProximo";
      this.btnProximo.Size = new System.Drawing.Size(55, 35);
      this.btnProximo.Text = "Próximo";
      this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnProximo.ToolTipText = "Avança para registro seguinte";
      this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
      // 
      // btnUltimo
      // 
      this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
      this.btnUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnUltimo.Name = "btnUltimo";
      this.btnUltimo.Size = new System.Drawing.Size(47, 35);
      this.btnUltimo.Text = "Último";
      this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnUltimo.ToolTipText = "Posiciona no último registro";
      this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
      // 
      // btnProcurar
      // 
      this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
      this.btnProcurar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnProcurar.Name = "btnProcurar";
      this.btnProcurar.Size = new System.Drawing.Size(56, 35);
      this.btnProcurar.Text = "Procurar";
      this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnProcurar.ToolTipText = "Procura registro através de seu código";
      this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
      // 
      // btnNovo
      // 
      this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
      this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(40, 35);
      this.btnNovo.Text = "Novo";
      this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnNovo.ToolTipText = "Inclui novo registro em ordem de matrícula";
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // btnEditar
      // 
      this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
      this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(41, 35);
      this.btnEditar.Text = "Editar";
      this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnEditar.ToolTipText = "Permite alterar os dados do registro atual";
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
      this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(57, 35);
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnCancelar.ToolTipText = "Cancela a operação atual";
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnSalvar
      // 
      this.btnSalvar.Enabled = false;
      this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
      this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(42, 35);
      this.btnSalvar.Text = "Salvar";
      this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSalvar.ToolTipText = "Armazena os valores atuais da tela";
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
      this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(45, 35);
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnExcluir.ToolTipText = "Exclui o registro exibido na tela";
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
      // 
      // btnSair
      // 
      this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
      this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(30, 35);
      this.btnSair.Text = "Sair";
      this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSair.ToolTipText = "Termina o programa";
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tpCadastro);
      this.tabControl1.Controls.Add(this.tpLista);
      this.tabControl1.Location = new System.Drawing.Point(0, 57);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(611, 321);
      this.tabControl1.TabIndex = 1;
      // 
      // tpCadastro
      // 
      this.tpCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.tpCadastro.Controls.Add(this.groupBox2);
      this.tpCadastro.Controls.Add(this.grbTipoLivro);
      this.tpCadastro.Controls.Add(this.txtTituloLivro);
      this.tpCadastro.Controls.Add(this.txtCodigoLivro);
      this.tpCadastro.Controls.Add(this.label2);
      this.tpCadastro.Controls.Add(this.label1);
      this.tpCadastro.Location = new System.Drawing.Point(4, 27);
      this.tpCadastro.Name = "tpCadastro";
      this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
      this.tpCadastro.Size = new System.Drawing.Size(603, 290);
      this.tpCadastro.TabIndex = 0;
      this.tpCadastro.Text = "Cadastro";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtDataDevolucao);
      this.groupBox2.Controls.Add(this.txtNomeLeitor);
      this.groupBox2.Controls.Add(this.txtLeitorComLivro);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Location = new System.Drawing.Point(26, 189);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(570, 91);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "informações de empréstimo";
      // 
      // txtDataDevolucao
      // 
      this.txtDataDevolucao.Location = new System.Drawing.Point(160, 57);
      this.txtDataDevolucao.MaxLength = 7;
      this.txtDataDevolucao.Name = "txtDataDevolucao";
      this.txtDataDevolucao.ReadOnly = true;
      this.txtDataDevolucao.Size = new System.Drawing.Size(98, 26);
      this.txtDataDevolucao.TabIndex = 6;
      // 
      // txtNomeLeitor
      // 
      this.txtNomeLeitor.Location = new System.Drawing.Point(265, 23);
      this.txtNomeLeitor.MaxLength = 35;
      this.txtNomeLeitor.Name = "txtNomeLeitor";
      this.txtNomeLeitor.ReadOnly = true;
      this.txtNomeLeitor.Size = new System.Drawing.Size(282, 26);
      this.txtNomeLeitor.TabIndex = 5;
      // 
      // txtLeitorComLivro
      // 
      this.txtLeitorComLivro.Location = new System.Drawing.Point(160, 25);
      this.txtLeitorComLivro.MaxLength = 7;
      this.txtLeitorComLivro.Name = "txtLeitorComLivro";
      this.txtLeitorComLivro.ReadOnly = true;
      this.txtLeitorComLivro.Size = new System.Drawing.Size(78, 26);
      this.txtLeitorComLivro.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 60);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(139, 18);
      this.label4.TabIndex = 1;
      this.label4.Text = "Data de devolução";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 31);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 18);
      this.label3.TabIndex = 0;
      this.label3.Text = "Leitor com livro";
      // 
      // grbTipoLivro
      // 
      this.grbTipoLivro.Controls.Add(this.rbTipo08);
      this.grbTipoLivro.Controls.Add(this.rbTipo07);
      this.grbTipoLivro.Controls.Add(this.rbTipo06);
      this.grbTipoLivro.Controls.Add(this.rbTipo05);
      this.grbTipoLivro.Controls.Add(this.rbTipo04);
      this.grbTipoLivro.Controls.Add(this.rbTipo03);
      this.grbTipoLivro.Controls.Add(this.rbTipo02);
      this.grbTipoLivro.Controls.Add(this.rbTipo01);
      this.grbTipoLivro.Controls.Add(this.rbTipo00);
      this.grbTipoLivro.Location = new System.Drawing.Point(28, 89);
      this.grbTipoLivro.Name = "grbTipoLivro";
      this.grbTipoLivro.Size = new System.Drawing.Size(570, 91);
      this.grbTipoLivro.TabIndex = 5;
      this.grbTipoLivro.TabStop = false;
      this.grbTipoLivro.Text = "Tipo do livro";
      // 
      // txtTituloLivro
      // 
      this.txtTituloLivro.Location = new System.Drawing.Point(93, 53);
      this.txtTituloLivro.MaxLength = 30;
      this.txtTituloLivro.Name = "txtTituloLivro";
      this.txtTituloLivro.Size = new System.Drawing.Size(233, 26);
      this.txtTituloLivro.TabIndex = 4;
      // 
      // txtCodigoLivro
      // 
      this.txtCodigoLivro.Location = new System.Drawing.Point(93, 21);
      this.txtCodigoLivro.MaxLength = 7;
      this.txtCodigoLivro.Name = "txtCodigoLivro";
      this.txtCodigoLivro.Size = new System.Drawing.Size(78, 26);
      this.txtCodigoLivro.TabIndex = 3;
      this.txtCodigoLivro.Leave += new System.EventHandler(this.txtMatricula_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(25, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Título:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Código:";
      // 
      // tpLista
      // 
      this.tpLista.Controls.Add(this.lsbLivros);
      this.tpLista.Location = new System.Drawing.Point(4, 27);
      this.tpLista.Name = "tpLista";
      this.tpLista.Padding = new System.Windows.Forms.Padding(3);
      this.tpLista.Size = new System.Drawing.Size(603, 290);
      this.tpLista.TabIndex = 1;
      this.tpLista.Text = "Lista";
      this.tpLista.UseVisualStyleBackColor = true;
      this.tpLista.Enter += new System.EventHandler(this.tpLista_Enter);
      // 
      // lsbLivros
      // 
      this.lsbLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lsbLivros.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lsbLivros.FormattingEnabled = true;
      this.lsbLivros.ItemHeight = 16;
      this.lsbLivros.Location = new System.Drawing.Point(8, 6);
      this.lsbLivros.Name = "lsbLivros";
      this.lsbLivros.Size = new System.Drawing.Size(557, 164);
      this.lsbLivros.TabIndex = 0;
      // 
      // ssMensagem
      // 
      this.ssMensagem.BackColor = System.Drawing.Color.CornflowerBlue;
      this.ssMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlbMensagem});
      this.ssMensagem.Location = new System.Drawing.Point(0, 385);
      this.ssMensagem.Name = "ssMensagem";
      this.ssMensagem.Size = new System.Drawing.Size(611, 22);
      this.ssMensagem.TabIndex = 2;
      this.ssMensagem.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
      this.toolStripStatusLabel1.Text = "Mensagem:";
      // 
      // stlbMensagem
      // 
      this.stlbMensagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.stlbMensagem.ForeColor = System.Drawing.Color.White;
      this.stlbMensagem.Name = "stlbMensagem";
      this.stlbMensagem.Size = new System.Drawing.Size(56, 17);
      this.stlbMensagem.Text = "Bom dia!";
      // 
      // imlBotoes
      // 
      this.imlBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBotoes.ImageStream")));
      this.imlBotoes.TransparentColor = System.Drawing.Color.Transparent;
      this.imlBotoes.Images.SetKeyName(0, "first.bmp");
      this.imlBotoes.Images.SetKeyName(1, "prior.bmp");
      this.imlBotoes.Images.SetKeyName(2, "next.bmp");
      this.imlBotoes.Images.SetKeyName(3, "last.bmp");
      this.imlBotoes.Images.SetKeyName(4, "Oeil2.bmp");
      this.imlBotoes.Images.SetKeyName(5, "Add.bmp");
      this.imlBotoes.Images.SetKeyName(6, "COPY.BMP");
      this.imlBotoes.Images.SetKeyName(7, "UNDO.BMP");
      this.imlBotoes.Images.SetKeyName(8, "Save.bmp");
      this.imlBotoes.Images.SetKeyName(9, "Minus.bmp");
      this.imlBotoes.Images.SetKeyName(10, "CLOSE1.BMP");
      this.imlBotoes.Images.SetKeyName(11, "about.bmp");
      this.imlBotoes.Images.SetKeyName(12, "abort.bmp");
      this.imlBotoes.Images.SetKeyName(13, "FIND.BMP");
      this.imlBotoes.Images.SetKeyName(14, "PRINTER5.BMP");
      this.imlBotoes.Images.SetKeyName(15, "REDO.BMP");
      this.imlBotoes.Images.SetKeyName(16, "WINNEXT.BMP");
      this.imlBotoes.Images.SetKeyName(17, "WINPREV.BMP");
      // 
      // dlgAbrir
      // 
      this.dlgAbrir.CheckFileExists = false;
      this.dlgAbrir.DefaultExt = "*.txt";
      // 
      // rbTipo00
      // 
      this.rbTipo00.AutoSize = true;
      this.rbTipo00.Location = new System.Drawing.Point(16, 26);
      this.rbTipo00.Name = "rbTipo00";
      this.rbTipo00.Size = new System.Drawing.Size(106, 22);
      this.rbTipo00.TabIndex = 0;
      this.rbTipo00.TabStop = true;
      this.rbTipo00.Text = "Quadrinhos";
      this.rbTipo00.UseVisualStyleBackColor = true;
      // 
      // rbTipo01
      // 
      this.rbTipo01.AutoSize = true;
      this.rbTipo01.Location = new System.Drawing.Point(142, 25);
      this.rbTipo01.Name = "rbTipo01";
      this.rbTipo01.Size = new System.Drawing.Size(74, 22);
      this.rbTipo01.TabIndex = 1;
      this.rbTipo01.TabStop = true;
      this.rbTipo01.Text = "Drama";
      this.rbTipo01.UseVisualStyleBackColor = true;
      // 
      // rbTipo02
      // 
      this.rbTipo02.AutoSize = true;
      this.rbTipo02.Location = new System.Drawing.Point(242, 26);
      this.rbTipo02.Name = "rbTipo02";
      this.rbTipo02.Size = new System.Drawing.Size(74, 22);
      this.rbTipo02.TabIndex = 2;
      this.rbTipo02.TabStop = true;
      this.rbTipo02.Text = "Ficção";
      this.rbTipo02.UseVisualStyleBackColor = true;
      // 
      // rbTipo03
      // 
      this.rbTipo03.AutoSize = true;
      this.rbTipo03.Location = new System.Drawing.Point(366, 25);
      this.rbTipo03.Name = "rbTipo03";
      this.rbTipo03.Size = new System.Drawing.Size(93, 22);
      this.rbTipo03.TabIndex = 3;
      this.rbTipo03.TabStop = true;
      this.rbTipo03.Text = "Romance";
      this.rbTipo03.UseVisualStyleBackColor = true;
      // 
      // rbTipo04
      // 
      this.rbTipo04.AutoSize = true;
      this.rbTipo04.Location = new System.Drawing.Point(477, 25);
      this.rbTipo04.Name = "rbTipo04";
      this.rbTipo04.Size = new System.Drawing.Size(87, 22);
      this.rbTipo04.TabIndex = 4;
      this.rbTipo04.TabStop = true;
      this.rbTipo04.Text = "Aventura";
      this.rbTipo04.UseVisualStyleBackColor = true;
      // 
      // rbTipo05
      // 
      this.rbTipo05.AutoSize = true;
      this.rbTipo05.Location = new System.Drawing.Point(16, 54);
      this.rbTipo05.Name = "rbTipo05";
      this.rbTipo05.Size = new System.Drawing.Size(102, 22);
      this.rbTipo05.TabIndex = 5;
      this.rbTipo05.TabStop = true;
      this.rbTipo05.Text = "Informática";
      this.rbTipo05.UseVisualStyleBackColor = true;
      // 
      // rbTipo06
      // 
      this.rbTipo06.AutoSize = true;
      this.rbTipo06.Location = new System.Drawing.Point(142, 54);
      this.rbTipo06.Name = "rbTipo06";
      this.rbTipo06.Size = new System.Drawing.Size(88, 22);
      this.rbTipo06.TabIndex = 6;
      this.rbTipo06.TabStop = true;
      this.rbTipo06.Text = "Culinária";
      this.rbTipo06.UseVisualStyleBackColor = true;
      // 
      // rbTipo07
      // 
      this.rbTipo07.AutoSize = true;
      this.rbTipo07.Location = new System.Drawing.Point(242, 53);
      this.rbTipo07.Name = "rbTipo07";
      this.rbTipo07.Size = new System.Drawing.Size(108, 22);
      this.rbTipo07.TabIndex = 7;
      this.rbTipo07.TabStop = true;
      this.rbTipo07.Text = "Matemática";
      this.rbTipo07.UseVisualStyleBackColor = true;
      // 
      // rbTipo08
      // 
      this.rbTipo08.AutoSize = true;
      this.rbTipo08.Location = new System.Drawing.Point(366, 54);
      this.rbTipo08.Name = "rbTipo08";
      this.rbTipo08.Size = new System.Drawing.Size(72, 22);
      this.rbTipo08.TabIndex = 8;
      this.rbTipo08.TabStop = true;
      this.rbTipo08.Text = "Outros";
      this.rbTipo08.UseVisualStyleBackColor = true;
      // 
      // FrmLivros
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(611, 407);
      this.Controls.Add(this.ssMensagem);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.barraDeFerramentas);
      this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmLivros";
      this.Text = "Manutenção de Livros";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFunc_FormClosing);
      this.Load += new System.EventHandler(this.FrmFunc_Load);
      this.barraDeFerramentas.ResumeLayout(false);
      this.barraDeFerramentas.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tpCadastro.ResumeLayout(false);
      this.tpCadastro.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.grbTipoLivro.ResumeLayout(false);
      this.grbTipoLivro.PerformLayout();
      this.tpLista.ResumeLayout(false);
      this.ssMensagem.ResumeLayout(false);
      this.ssMensagem.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip barraDeFerramentas;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpCadastro;
    private System.Windows.Forms.TabPage tpLista;
    private System.Windows.Forms.StatusStrip ssMensagem;
    private System.Windows.Forms.TextBox txtTituloLivro;
    private System.Windows.Forms.TextBox txtCodigoLivro;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripButton btnInicio;
    private System.Windows.Forms.ToolStripButton btnAnterior;
    private System.Windows.Forms.ToolStripButton btnProximo;
    private System.Windows.Forms.ToolStripButton btnUltimo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ImageList imlBotoes;
    private System.Windows.Forms.ToolStripButton btnProcurar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnNovo;
    private System.Windows.Forms.ToolStripButton btnCancelar;
    private System.Windows.Forms.ToolStripButton btnSalvar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton btnExcluir;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton btnSair;
    private System.Windows.Forms.ToolStripButton btnEditar;
    private System.Windows.Forms.OpenFileDialog dlgAbrir;
    private System.Windows.Forms.ToolStripStatusLabel stlbMensagem;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ListBox lsbLivros;
    private System.Windows.Forms.GroupBox grbTipoLivro;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtDataDevolucao;
    private System.Windows.Forms.TextBox txtNomeLeitor;
    private System.Windows.Forms.TextBox txtLeitorComLivro;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RadioButton rbTipo08;
    private System.Windows.Forms.RadioButton rbTipo07;
    private System.Windows.Forms.RadioButton rbTipo06;
    private System.Windows.Forms.RadioButton rbTipo05;
    private System.Windows.Forms.RadioButton rbTipo04;
    private System.Windows.Forms.RadioButton rbTipo03;
    private System.Windows.Forms.RadioButton rbTipo02;
    private System.Windows.Forms.RadioButton rbTipo01;
    private System.Windows.Forms.RadioButton rbTipo00;
  }
}


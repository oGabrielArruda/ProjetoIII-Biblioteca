namespace apBiblioteca
{
  partial class FrmLeitores
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeitores));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
      this.dgvLivros = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label4 = new System.Windows.Forms.Label();
      this.txtEndereco = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNomeLeitor = new System.Windows.Forms.TextBox();
      this.txtCodigoLeitor = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tpLista = new System.Windows.Forms.TabPage();
      this.lsbLivros = new System.Windows.Forms.ListBox();
      this.ssMensagem = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.stlbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
      this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
      this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
      this.barraDeFerramentas.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tpCadastro.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
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
      this.tpCadastro.Controls.Add(this.dgvLivros);
      this.tpCadastro.Controls.Add(this.label4);
      this.tpCadastro.Controls.Add(this.txtEndereco);
      this.tpCadastro.Controls.Add(this.label3);
      this.tpCadastro.Controls.Add(this.txtNomeLeitor);
      this.tpCadastro.Controls.Add(this.txtCodigoLeitor);
      this.tpCadastro.Controls.Add(this.label2);
      this.tpCadastro.Controls.Add(this.label1);
      this.tpCadastro.Location = new System.Drawing.Point(4, 27);
      this.tpCadastro.Name = "tpCadastro";
      this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
      this.tpCadastro.Size = new System.Drawing.Size(603, 290);
      this.tpCadastro.TabIndex = 0;
      this.tpCadastro.Text = "Cadastro";
      // 
      // dgvLivros
      // 
      this.dgvLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
      this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvLivros.DefaultCellStyle = dataGridViewCellStyle9;
      this.dgvLivros.Location = new System.Drawing.Point(13, 128);
      this.dgvLivros.Name = "dgvLivros";
      this.dgvLivros.ReadOnly = true;
      this.dgvLivros.Size = new System.Drawing.Size(582, 156);
      this.dgvLivros.TabIndex = 8;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Código";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 60;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Título";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 250;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Devolução";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 80;
      // 
      // Column4
      // 
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.Column4.DefaultCellStyle = dataGridViewCellStyle8;
      this.Column4.HeaderText = "Atraso?";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 60;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(10, 106);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(235, 18);
      this.label4.TabIndex = 7;
      this.label4.Text = "Livros emprestados a este leitor:";
      // 
      // txtEndereco
      // 
      this.txtEndereco.Location = new System.Drawing.Point(96, 71);
      this.txtEndereco.MaxLength = 50;
      this.txtEndereco.Name = "txtEndereco";
      this.txtEndereco.Size = new System.Drawing.Size(348, 26);
      this.txtEndereco.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 74);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 18);
      this.label3.TabIndex = 5;
      this.label3.Text = "Endereço:";
      // 
      // txtNomeLeitor
      // 
      this.txtNomeLeitor.Location = new System.Drawing.Point(96, 39);
      this.txtNomeLeitor.MaxLength = 35;
      this.txtNomeLeitor.Name = "txtNomeLeitor";
      this.txtNomeLeitor.Size = new System.Drawing.Size(233, 26);
      this.txtNomeLeitor.TabIndex = 4;
      // 
      // txtCodigoLeitor
      // 
      this.txtCodigoLeitor.Location = new System.Drawing.Point(96, 7);
      this.txtCodigoLeitor.MaxLength = 6;
      this.txtCodigoLeitor.Name = "txtCodigoLeitor";
      this.txtCodigoLeitor.Size = new System.Drawing.Size(78, 26);
      this.txtCodigoLeitor.TabIndex = 3;
      this.txtCodigoLeitor.Leave += new System.EventHandler(this.txtMatricula_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nome:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 10);
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
      // FrmLeitores
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(611, 407);
      this.Controls.Add(this.ssMensagem);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.barraDeFerramentas);
      this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmLeitores";
      this.Text = "Manutenção de Livros";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFunc_FormClosing);
      this.Load += new System.EventHandler(this.FrmFunc_Load);
      this.barraDeFerramentas.ResumeLayout(false);
      this.barraDeFerramentas.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tpCadastro.ResumeLayout(false);
      this.tpCadastro.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
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
    private System.Windows.Forms.TextBox txtNomeLeitor;
    private System.Windows.Forms.TextBox txtCodigoLeitor;
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
    private System.Windows.Forms.TextBox txtEndereco;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView dgvLivros;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
  }
}


namespace apBiblioteca
{
    partial class FrmDevolucao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDevolve = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.cbxLivros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLeitor.Location = new System.Drawing.Point(217, 63);
            this.txtCodLeitor.MaxLength = 6;
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.Size = new System.Drawing.Size(311, 35);
            this.txtCodLeitor.TabIndex = 0;
            this.txtCodLeitor.Leave += new System.EventHandler(this.txtCodLeitor_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do Leitor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "DEVOLUÇÕES";
            // 
            // btnDevolve
            // 
            this.btnDevolve.Enabled = false;
            this.btnDevolve.Location = new System.Drawing.Point(551, 231);
            this.btnDevolve.Name = "btnDevolve";
            this.btnDevolve.Size = new System.Drawing.Size(97, 44);
            this.btnDevolve.TabIndex = 3;
            this.btnDevolve.Text = "Devolver";
            this.btnDevolve.UseVisualStyleBackColor = true;
            this.btnDevolve.Click += new System.EventHandler(this.btnDevolve_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // cbxLivros
            // 
            this.cbxLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLivros.FormattingEnabled = true;
            this.cbxLivros.Location = new System.Drawing.Point(193, 127);
            this.cbxLivros.Name = "cbxLivros";
            this.cbxLivros.Size = new System.Drawing.Size(335, 33);
            this.cbxLivros.TabIndex = 4;
            this.cbxLivros.SelectionChangeCommitted += new System.EventHandler(this.cbxLivros_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Livros com leitor:";
            // 
            // FrmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxLivros);
            this.Controls.Add(this.btnDevolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodLeitor);
            this.Name = "FrmDevolucao";
            this.Text = "FrmDevolucao";
            this.Load += new System.EventHandler(this.FrmDevolucao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDevolve;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.ComboBox cbxLivros;
        private System.Windows.Forms.Label label3;
    }
}
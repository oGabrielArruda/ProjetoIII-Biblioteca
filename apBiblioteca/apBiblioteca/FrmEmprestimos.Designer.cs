namespace apBiblioteca
{
    partial class FrmEmprestimos
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
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLeitor.Location = new System.Drawing.Point(232, 57);
            this.txtCodLeitor.MaxLength = 6;
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.Size = new System.Drawing.Size(226, 26);
            this.txtCodLeitor.TabIndex = 0;
            this.txtCodLeitor.Leave += new System.EventHandler(this.txtCodLeitor_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Leitor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código Livro:";
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLivro.Location = new System.Drawing.Point(232, 114);
            this.txtCodLivro.MaxLength = 7;
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(226, 26);
            this.txtCodLivro.TabIndex = 3;
            this.txtCodLivro.Leave += new System.EventHandler(this.txtCodLivro_Leave);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Enabled = false;
            this.btnEmprestar.Location = new System.Drawing.Point(232, 238);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(140, 51);
            this.btnEmprestar.TabIndex = 4;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.Emprestar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Devolução:";
            // 
            // mtxtData
            // 
            this.mtxtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtData.Location = new System.Drawing.Point(232, 169);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(108, 26);
            this.mtxtData.TabIndex = 7;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            this.mtxtData.Leave += new System.EventHandler(this.mtxtData_Leave);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "(dd/mm/yyyy)";
            // 
            // FrmEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.txtCodLivro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodLeitor);
            this.Name = "FrmEmprestimos";
            this.Text = " Empréstimos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmprestimos_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmprestimos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.Label label4;
    }
}
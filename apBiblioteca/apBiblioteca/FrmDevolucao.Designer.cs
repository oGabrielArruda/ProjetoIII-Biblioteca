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
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDevolve = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLivro.Location = new System.Drawing.Point(233, 154);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(311, 35);
            this.txtCodLivro.TabIndex = 0;
            this.txtCodLivro.Leave += new System.EventHandler(this.txtCodLivro_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "DEVOLUÇÕES";
            // 
            // btnDevolve
            // 
            this.btnDevolve.Location = new System.Drawing.Point(454, 217);
            this.btnDevolve.Name = "btnDevolve";
            this.btnDevolve.Size = new System.Drawing.Size(90, 44);
            this.btnDevolve.TabIndex = 3;
            this.btnDevolve.Text = "Confirmar";
            this.btnDevolve.UseVisualStyleBackColor = true;
            this.btnDevolve.Click += new System.EventHandler(this.btnDevolve_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // FrmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 378);
            this.Controls.Add(this.btnDevolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodLivro);
            this.Name = "FrmDevolucao";
            this.Text = "FrmDevolucao";
            this.Load += new System.EventHandler(this.FrmDevolucao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDevolve;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}
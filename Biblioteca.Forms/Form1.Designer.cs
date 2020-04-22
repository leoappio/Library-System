namespace Biblioteca.Forms
{
    partial class Form1
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
            this.DevolucaoBotao = new System.Windows.Forms.Button();
            this.emprestimoBotao = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelRetorno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DevolucaoBotao
            // 
            this.DevolucaoBotao.Location = new System.Drawing.Point(37, 33);
            this.DevolucaoBotao.Name = "DevolucaoBotao";
            this.DevolucaoBotao.Size = new System.Drawing.Size(75, 23);
            this.DevolucaoBotao.TabIndex = 0;
            this.DevolucaoBotao.Text = "devolucao";
            this.DevolucaoBotao.UseVisualStyleBackColor = true;
            this.DevolucaoBotao.Click += new System.EventHandler(this.DevolucaoBotao_Click);
            // 
            // emprestimoBotao
            // 
            this.emprestimoBotao.Location = new System.Drawing.Point(139, 33);
            this.emprestimoBotao.Name = "emprestimoBotao";
            this.emprestimoBotao.Size = new System.Drawing.Size(75, 23);
            this.emprestimoBotao.TabIndex = 1;
            this.emprestimoBotao.Text = "emprestimo";
            this.emprestimoBotao.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "criar conta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelRetorno
            // 
            this.labelRetorno.AutoSize = true;
            this.labelRetorno.Location = new System.Drawing.Point(655, 43);
            this.labelRetorno.Name = "labelRetorno";
            this.labelRetorno.Size = new System.Drawing.Size(35, 13);
            this.labelRetorno.TabIndex = 3;
            this.labelRetorno.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRetorno);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.emprestimoBotao);
            this.Controls.Add(this.DevolucaoBotao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DevolucaoBotao;
        private System.Windows.Forms.Button emprestimoBotao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelRetorno;
    }
}


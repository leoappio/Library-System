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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLivros = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.emprestimoBotao.Click += new System.EventHandler(this.emprestimoBotao_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "criar conta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelRetorno
            // 
            this.labelRetorno.AutoSize = true;
            this.labelRetorno.Location = new System.Drawing.Point(34, 240);
            this.labelRetorno.Name = "labelRetorno";
            this.labelRetorno.Size = new System.Drawing.Size(10, 13);
            this.labelRetorno.TabIndex = 3;
            this.labelRetorno.Text = ".";
            this.labelRetorno.Click += new System.EventHandler(this.labelRetorno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(37, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "devolução";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Devolver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "digite o ID da conta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelLivros);
            this.groupBox2.Location = new System.Drawing.Point(369, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 220);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "seus livros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(37, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Id do livro";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Pegar livro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "digite o ID do livro";
            // 
            // labelLivros
            // 
            this.labelLivros.AutoSize = true;
            this.labelLivros.Location = new System.Drawing.Point(7, 20);
            this.labelLivros.Name = "labelLivros";
            this.labelLivros.Size = new System.Drawing.Size(10, 13);
            this.labelLivros.TabIndex = 0;
            this.labelLivros.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelRetorno);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.emprestimoBotao);
            this.Controls.Add(this.DevolucaoBotao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DevolucaoBotao;
        private System.Windows.Forms.Button emprestimoBotao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelRetorno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelLivros;
    }
}


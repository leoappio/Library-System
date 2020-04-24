using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Entities;

namespace Biblioteca.Forms
    
{  
    public partial class Form1 : Form
    {
        public Library library = new Library();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void DevolucaoBotao_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "devolução";
            label1.Text = "Digite o ID da conta";
            button1.Text = "Prosseguir";
            groupBox3.Visible = false;

        }

        private void labelRetorno_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Criar conta";
            label1.Text = "Qual seu nome?";
            button1.Text = "criar conta";
            groupBox3.Visible = false;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text !=""||textBox1.Text != null)
            {
                if(button1.Text == "criar conta")
                {
                    Account conta = new Account(textBox1.Text);
                    library.addAccount(conta);
                    labelRetorno.Text = "ID da sua conta = "+conta.ID;
                    
                }else if (button1.Text == "Seguir")
                {
                    int numeroConta = int.Parse(textBox1.Text);

                    if (library.ValidarConta(numeroConta))
                    {
                        groupBox3.Visible = true;
                        button2.Text = "pegar livro";                      
                    }

                }else if (button1.Text == "Prosseguir")
                {

                    int numeroConta = int.Parse(textBox1.Text);

                    if (library.ValidarConta(numeroConta))
                    {
                        groupBox3.Visible = true;
                        groupBox2.Visible = true;
                        MostrarLivros(numeroConta);
                        button2.Text = "devolver livro";
                    }
                }
            }
        }

        private void MostrarLivros(int accountNumber)
        {
            List<Book> livros = library.GetBooksByAccount(accountNumber);

            string books = " ";

            foreach (Book livro in livros)
            {
                books = books + " | "+livro.Id;
            }

            labelLivros.Text = books;
        }

        private void emprestimoBotao_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Pegar emprestado";
            label1.Text = "Digite o ID da conta";
            button1.Text = "Seguir";
            groupBox2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            library.InstantiateBooks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" || textBox2.Text != null)
            {
                if (button2.Text == "pegar livro")
                {
                    int bookID = int.Parse(textBox2.Text);
                    int numeroConta = int.Parse(textBox1.Text);

                    if (library.QuantidadeDisponivel(bookID) > 0)
                    {
                        library.AlugarLivro(library.GetLivroByID(bookID));
                        library.AdicionarLivroConta(numeroConta, bookID);
                        labelRetorno.Text = "livro foi alugado com sucesso";
                    }

                }
                else if (button2.Text == "devolver livro")
                {

                    int bookID = int.Parse(textBox2.Text);
                    int numeroConta = int.Parse(textBox1.Text);

                    if (library.ValidarEmprestimo(numeroConta, bookID))
                    {
                        library.DevolverLivro(library.GetLivroByID(bookID));
                        library.RemoverLivroConta(numeroConta, bookID);
                        labelRetorno.Text = "livro devolvido";
                        MostrarLivros(numeroConta);

                    }
                    else
                    {
                        labelRetorno.Text = "vc não pegou esse livro";
                        
                    }


                }
            }
        }
    }
}

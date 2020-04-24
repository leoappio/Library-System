using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Entities
{
    public class Library
    {
        public List<Account> Contas { get; set; } = new List<Account>();
        public Dictionary<Book, int> livros { get; set; } = new Dictionary<Book, int>();

        public Library()
        {
        }

        public void InstantiateBooks()
        {
            Book livro1 = new Book(1234, "Book 1", "writer 1");
            Book livro2 = new Book(1235, "Book 2", "writer 1");
            Book livro3 = new Book(1236, "Book 3", "writer 3");
            Book livro4 = new Book(1237, "Book 4", "writer 5");
            Book livro5 = new Book(1238, "Book 5", "writer 7");

            AddLivro(livro1, 3);
            AddLivro(livro2, 1);
            AddLivro(livro3, 2);
            AddLivro(livro4, 5);
            AddLivro(livro5, 4);

        }

        public void addAccount(Account account)
        {
            Contas.Add(account);
        }

        public void AddLivro(Book livro, int quantidade)
        {
            livros.Add(livro, quantidade);
        }

        public int QuantidadeDisponivel(int id)
        {
            int quantidade = -1;

            foreach (var par in livros)
            {
                if(par.Key.Id == id)
                {
                    quantidade = par.Value;
                }
            }

            return quantidade;           
        }


        public void AlugarLivro(Book book)
        {
            int quantidade = 0;

            foreach(var livro in livros)
            {
                if (livro.Key == book && livro.Value>0)
                {
                    quantidade = livro.Value - 1;
                    SetLivro(book, quantidade);
                    break;
                }
            }
        }


        public void DevolverLivro(Book book)
        {
            int quantidade = 0;

            foreach (var livro in livros)
            {
                if (livro.Key == book )
                {
                    quantidade = livro.Value + 1;
                    SetLivro(book, quantidade);
                    break;
                }
            }
        }


        public Book GetLivroByID(int id)
        {            
            foreach(var book in livros)
            {
                if(book.Key.Id == id)
                {
                    return book.Key;
                }
            }
            return null;
        }


        public void SetLivro(Book livro, int quantidade)
        {
            livros.Remove(livro);
            livros.Add(livro, quantidade);
        }

        public bool ValidarConta(int accountNumber)
        {
            foreach(Account conta in Contas)
            {
                if (conta.ID == accountNumber)
                {
                    return true;
                }
            }

            return false;
        }

        public List<Book> GetBooksByAccount(int accountNumber)
        {
            foreach (Account conta in Contas)
            {
                if (conta.ID == accountNumber)
                {
                    return conta.Livros;
                }
            }

            return null;
        }


        public bool ValidarEmprestimo(int accountNumber, int BookID)
        {
            foreach (Account conta in Contas)
            {
                if (conta.ID == accountNumber)
                {
                    foreach(Book livro in conta.Livros)
                    {
                        if (livro.Id == BookID)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }


        public void RemoverLivroConta(int accountNumber, int bookID)
        {
            foreach (Account conta in Contas)
            {
                if (conta.ID == accountNumber)
                {
                    conta.RemoverLivro(GetLivroByID(bookID));
                }
            }

        }

        public void AdicionarLivroConta(int accountNumber, int bookID)
        {
            foreach (Account conta in Contas)
            {
                if (conta.ID == accountNumber)
                {
                    conta.AddLivro(GetLivroByID(bookID));
                }
            }

        }
    }
}

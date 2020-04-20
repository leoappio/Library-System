using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Entities
{
    class Library
    {
        public List<Account> Contas { get; set; } = new List<Account>();
        public Dictionary<Book, int> livros { get; set; } = new Dictionary<Book, int>();

        public Library()
        {
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



        public Account GetConta(int ID)
        {
            for(int i = 0; i < Contas.Count; i++)
            {
                if(Contas[i].ID == ID)
                {
                    return Contas[i];
                }
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Entities
{
    public class Account
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<Book> Livros { get; set; } = new List<Book>();

        public Account(int iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }

        public void AddLivro(Book livro)
        {
            Livros.Add(livro);
        }

        public void RemoverLivro(Book livro)
        {
            Livros.Remove(livro);
        }

    }
}

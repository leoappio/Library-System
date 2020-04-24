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

        public Account(string nome)
        {
            ID = GenerateID();
            Nome = nome;
        }

        public int GenerateID()
        {
            Random rdn = new Random();
            int id_base = rdn.Next(100, 999);
            int id_multiplier = rdn.Next(2, 20);

            int id = id_base * id_multiplier;
            return id;
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

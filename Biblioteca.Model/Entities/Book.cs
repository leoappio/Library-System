using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }

        public Book(int id, string nome, string autor)
        {
            Id = id;
            Nome = nome;
            Autor = autor;
        }
    }
}

using System;
using Biblioteca.Entities;
using System.Collections.Generic;

namespace Biblioteca
{
    class Program
    {
        Library library = new Library();

        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.InstantiateBooks();
            programa.Menu();
            Console.ReadLine();
        }


        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("[1] Devolução ");
            Console.WriteLine("[2] Empréstimo");
            Console.WriteLine("[3] Criar nova conta");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:

                    Console.WriteLine("digite o numero da conta de quem quer devolver");
                    int accountNumber = int.Parse(Console.ReadLine());

                    if (library.ValidarConta(accountNumber))
                    {
                        List<Book> livros = library.GetBooksByAccount(accountNumber);

                        Console.WriteLine("Seus Livros");

                        foreach (Book livro in livros)
                        {
                            Console.WriteLine("------------");
                            Console.WriteLine($"Nome: {livro.Nome}");
                            Console.WriteLine($"Id: {livro.Id}");
                            Console.WriteLine($"Autor: {livro.Autor}");
                        }

                        Console.WriteLine("digite o id do livro que deseja devolver");
                        int bookID = int.Parse(Console.ReadLine());

                        if (library.ValidarEmprestimo(accountNumber, bookID))
                        {
                            library.DevolverLivro(library.GetLivroByID(bookID));
                            library.RemoverLivroConta(accountNumber, bookID);
                            PressAnyKey();
                            
                        }
                        else
                        {
                            Console.WriteLine("livro não encontrado");
                            PressAnyKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("conta não encontrada");
                        PressAnyKey();
                    }


                    break;
                case 2:

                    Console.WriteLine("digite o numero da conta de quem quer pegar emprestado");
                    int numeroConta = int.Parse(Console.ReadLine());

                    if (library.ValidarConta(numeroConta))
                    {
                        Console.WriteLine("digite o id do livro que deseja pegar emprestado");
                        int bookID = int.Parse(Console.ReadLine());

                        if(library.QuantidadeDisponivel(bookID) > 0)
                        {
                            library.AlugarLivro(library.GetLivroByID(bookID));
                            library.AdicionarLivroConta(numeroConta, bookID);
                            Console.WriteLine("livro foi alugado com sucesso");
                            PressAnyKey();
                        }
                        else
                        {
                            PressAnyKey();
                            Console.WriteLine("este livro não está disponível");
                        }
                    }
                    else
                    {
                        Console.WriteLine("conta não encontrada");
                        PressAnyKey();
                    }

                    break;
                case 3:
                    CriarConta();
                    break;
                default:
                    Console.WriteLine("erro");
                    break;
            }
        }

        public void CriarConta()
        {

            Console.Write("Qual o seu nome?");
            string nome = Console.ReadLine();

            int id = GenerateId();

            Account account = new Account(id, nome);
            library.addAccount(account);


            Console.WriteLine("id da conta " + id);
            PressAnyKey();
        }


        public int GenerateId()
        {
            Random rdn = new Random();
            int id_base = rdn.Next(100, 999);
            int id_multiplier = rdn.Next(2, 20);

            int id = id_base * id_multiplier;
            return id;
        }

        public void InstantiateBooks()
        {
            Book livro1 = new Book(1234, "Book 1", "writer 1");
            Book livro2 = new Book(1235, "Book 2", "writer 1");
            Book livro3 = new Book(1236, "Book 3", "writer 3");
            Book livro4 = new Book(1237, "Book 4", "writer 5");
            Book livro5 = new Book(1238, "Book 5", "writer 7");

            library.AddLivro(livro1, 3);
            library.AddLivro(livro2, 1);
            library.AddLivro(livro3, 2);
            library.AddLivro(livro4, 5);
            library.AddLivro(livro5, 4);

        }


        public void PressAnyKey()
        {
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Menu();
        }
    }
}

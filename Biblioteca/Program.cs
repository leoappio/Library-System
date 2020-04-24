using System;
using Biblioteca.Entities;
using System.Collections.Generic;


namespace Biblioteca
{
    class Program
    {
        public static Library library = new Library();

        static void Main(string[] args)
        {
            library.InstantiateBooks();
            
            //programa.Menu();
            Console.ReadLine();
        }

        public static void Menu()
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


        public static void CriarConta()
        {

            Console.Write("Qual o seu nome?");
            string nome = Console.ReadLine();

            Account account = new Account(nome);
            library.addAccount(account);


            Console.WriteLine("id da conta " + account.ID);
            PressAnyKey();
        }





        public static void PressAnyKey()
        {
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Menu();
        }
    }
}

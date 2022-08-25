# C-Projects

using System;

namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, distrito;
            int nota;
            

            Console.WriteLine("Insira o seu nome: ");
            nome = Console.ReadLine(); 

            Console.WriteLine("Insira o seu distrito de residência: ");
            distrito = Console.ReadLine();

            Console.WriteLine("Insira a sua nota de avaliação: ");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 10)
            {
                Console.WriteLine("Bem vindo " + nome + " residente em " + distrito + ". Com " + nota + " valores estás aprovado");
            }

            else
            {
                Console.WriteLine("Bem vindo " + nome + " residente em " + distrito + ". Com " + nota + " valores estás reprovado");
            }

            Console.WriteLine("\nTrabalho realizado por: Pedro Miguel Meira Salgado");

            Console.ReadLine();

            Console.ReadKey();
        }  
    }
}

Guess the number game

using System;

namespace numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, i;

            Console.WriteLine("Lets play a game!");
            Console.WriteLine("\nYou have to guess a number!");
            Console.WriteLine("\nType a number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Try to guess the number (you have 10 tries): ");

            int j = 1, tentativa;

            for (i = 0; i < 9; i++)
            {
                tentativa = j + i;
                Console.WriteLine("Try number " + tentativa);
                tentativa = Convert.ToInt32(Console.ReadLine());

                if (tentativa == num1)
                {
                    Console.WriteLine("Nice guess!");
                    Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");
                    return;
                }
                else if (tentativa <= 10)
                {
                    Console.WriteLine("Wrong number! Try again!");
                    
                }


            }
            Console.WriteLine("\nProject coded by: Pedro Miguel Meira Salgado");

            Console.ReadKey();

        }
    }
}

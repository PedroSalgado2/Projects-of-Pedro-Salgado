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

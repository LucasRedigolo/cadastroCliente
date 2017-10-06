using System;

namespace cadastroCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;     
            string RG;   
            int Idade;
            string Endereço;
            string CPF;
            string Genero;

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o seu RG?");
            RG = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual seu endereço?");
            Endereço = Console.ReadLine();
            Console.WriteLine("Qual o seu CPF?");
            CPF = Console.ReadLine();
            Console.WriteLine("Qual genero você se identifica?");
            Genero = Console.ReadLine();
        }
    }
}

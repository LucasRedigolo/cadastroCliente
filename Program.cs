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

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o seu RG?");
            RG = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            Idade = Convert.ToInt32(Console.ReadLine());
            
           
        }
    }
}

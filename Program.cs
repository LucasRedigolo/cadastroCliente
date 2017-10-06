using System;

namespace cadastroCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            string LocalNascimento;
            string Profissao;
            string Endereco;
            int EstadoCivil;
            string StringEstadoCivil;
            bool Converteu = false;

            Console.WriteLine("Qual o seu nome?");
            Nome = Console.ReadLine();

            Console.WriteLine("Qual o seu local de nascimento?");
            LocalNascimento = Console.ReadLine();

            Console.WriteLine("Qual a sua profissão?");
            Profissao = Console.ReadLine();

            Console.WriteLine("Qual o seu endereço?");
            Endereco = Console.ReadLine();

            do
            {
                Console.WriteLine("Qual o seu estado civil?\n1 Solteiro\n2 Casado");
                Converteu = int.TryParse(Console.ReadLine(), out EstadoCivil);

            } while (Converteu == true && EstadoCivil == 1 || EstadoCivil == 2);

            if(EstadoCivil == 1)
            {
                StringEstadoCivil = "Solteiro";
            }else{
                StringEstadoCivil = "Casado";
            }

            Console.WriteLine(StringEstadoCivil);

        }     
    }
}

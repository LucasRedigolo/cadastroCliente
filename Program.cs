using System;

namespace cadastroCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            string RG;
            string CPF;  
            int Idade;
            bool ConverteuIdade = false;
            string Genero;
            string LocalNascimento;
            string Profissao;
            string Endereco;
            int EstadoCivil;
            string StringEstadoCivil;
            bool Converteu = false;

            Console.WriteLine("Qual o seu nome?");
            Nome = Console.ReadLine();

            Console.WriteLine("Qual o seu RG?");
            RG = Console.ReadLine();

            Console.WriteLine("Qual o seu CPF?");
            CPF = Console.ReadLine();


            do
            {

                Console.WriteLine("Qual sua idade?");
                ConverteuIdade = int.TryParse(Console.ReadLine(), out Idade);

            } while (!(ConverteuIdade == true)); 

            Console.WriteLine("Qual o seu local de nascimento?");
            LocalNascimento = Console.ReadLine();

            Console.WriteLine("Qual a sua profissão?");
            Profissao = Console.ReadLine();

            Console.WriteLine("Qual o seu endereço?");
            Endereco = Console.ReadLine();

            Console.WriteLine("Qual genero você se identifica?");
            Genero = Console.ReadLine();

            do
            {
                Console.WriteLine("Qual o seu estado civil?\n1 Solteiro\n2 Casado");
                Converteu = int.TryParse(Console.ReadLine(), out EstadoCivil);

            } while (!(Converteu == true && EstadoCivil == 1 || EstadoCivil == 2));

            if(EstadoCivil == 1)
            {
                StringEstadoCivil = "Solteiro";
            }else{
                StringEstadoCivil = "Casado";
            }

            Console.WriteLine("\nNome: "+Nome);
            Console.WriteLine("RG: "+RG);
            Console.WriteLine("CPF: "+CPF);
            Console.WriteLine("Idade: "+Idade);
            Console.WriteLine("Gênero: "+Genero);
            Console.WriteLine("Local de Nascimento: "+LocalNascimento);
            Console.WriteLine("Profissão: "+Profissao);
            Console.WriteLine("Endereço: "+Endereco);
            Console.WriteLine("Estado Civil: "+StringEstadoCivil);

            Console.WriteLine("\nCadastro concluído com sucesso!");
        }     

    }
}

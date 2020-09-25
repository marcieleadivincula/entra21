using System;

namespace ExerciciosOOpt102Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 2");

            //4 Crie 10 pessoas com nome,idade e uma função que retorna verdadeiro caso a pessoa seja adulta. Peça para o usuário preencher todas as pessoas, em seguida, mostre em ordem do mais velho para o mais novo apenas aqueles que são adultos
            //ps: deve - se usar o retorno da função para avalaiar se é adulto ou não
            Pessoa[] pes = new Pessoa[10];

            for (int i = 0; i < pes.Length; i++)
            {
                Console.WriteLine("Insira a {0}° pessoa", (i + 1));
                Console.Write("Nome: ");
                string nome = Console.In.ReadLine();
                Console.Write("Idade: ");
                int idade = Convert.ToInt32(Console.In.ReadLine());

                pes[i] = new Pessoa(nome, idade);
                Console.WriteLine();
            }

            //&& EhAdult() == "true"
            for (int i = 0; i < pes.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (pes[j - 1].GetIdade() < pes[j].GetIdade())
                    {
                        Pessoa temp = pes[j - 1];
                        pes[j - 1] = pes[j];
                        pes[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < pes.Length; i++)
            {
                if (pes[i].EhAdult() == true)
                {
                    Console.WriteLine("Nome: {0}, Idade: {1}", pes[i].GetNome(), pes[i].GetIdade());
                }
            }
        }
    }
}

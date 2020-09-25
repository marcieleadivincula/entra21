using System;

namespace ExerciciosOOpt101Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");
            //2) Crie 3 cachorros que possuem nome, nome do dono e idade. Peça para o usuario preencher os dados e após, mostre na tela apenas os cachorros com mais de 6 anos.

            Dog[] dogs = new Dog[3];

            for (int i = 0; i < dogs.Length; i++)
            {
                Console.WriteLine("Insira o {0}° cão", (i + 1));

                Console.Write("Nome do cachorro: ");
                string nome = Console.In.ReadLine();
                Console.Write("Nome do dono: ");
                string nomeDono = Console.In.ReadLine();
                Console.Write("Idade do cachorro: ");
                int idade = Convert.ToInt32(Console.In.ReadLine());

                dogs[i] = new Dog(nome, nomeDono, idade);
                Console.WriteLine();
            }

            for (int i = 0; i < dogs.Length; i++)
            {
                if (dogs[i].EhSeis() == true)
                {
                    Console.WriteLine("Nome do cão: {0}, Nome do dono: {1}, Idade do cão: {2}", dogs[i].GetNome(), dogs[i].GetNomeDono(), dogs[i].GetIdade());
                }
                else
                {
                    break;
                }
            }
        }
    }
}

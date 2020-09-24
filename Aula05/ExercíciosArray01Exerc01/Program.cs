using System;

namespace ExercíciosArray01Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando lista 1 de exercícios de Array");
            //1) Crie um vetor que armazena 2 valores vindo do usuario, depois, diga pro usuario qual o maior

            int[] maiorNumero = new int[2];
            int maior = 0;

            for (int i = 0; i < maiorNumero.Length; i++)
            {
                Console.Write("Digite um número qualquer: ");
                maiorNumero[i] = Convert.ToInt32(Console.In.ReadLine());

                if (maiorNumero[i] > maior)
                {
                    maior = maiorNumero[i];
                    Console.WriteLine("Maior número = " + maior);
                }
            }
        }
    }
}

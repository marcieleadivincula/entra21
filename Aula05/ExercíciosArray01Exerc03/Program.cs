using System;
using System.Collections;

namespace ExercíciosArray01Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando lista 1 de exercícios de Array");
            //3) Crie um vetor que armazena 3 valores vindo do usuario, depois, mostre apenas o maior dentre eles , se todos forem iguais, exiba uma mensagem dizendo “sao todos iguais”
            int[] valores = new int[3];
            int maior = 0, menor = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite uma valor qualquer: ");
                valores[i] = Convert.ToInt32(Console.In.ReadLine());

                if (valores[i] > maior)
                {
                    maior = valores[i];
                }
                else if (valores[0] == valores[1] && valores[1] == valores[2] && valores[2] == valores[0])
                {
                    menor = valores[i];
                    Console.WriteLine("São todos iguais");
                }
                else
                {
                    menor = valores[i];
                }
            }

            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);
        }
    }
}

using System;

namespace ExerciciosFunction02Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 2 - Function");

            //1) Escreva uma função que receba 2 valores e retorna o maior entre eles. O usuario vai colocar 4 números, diga para ele qual o maior.
            Program pro = new Program();

            pro.GetInput();
            pro.GetValue(7, 10);

            Console.WriteLine("Maior número: " + pro.GetInput());
        }

        public int GetValue(int a, int b)
        {
            int maior = 0;
            if (a > b)
            {
                maior = a;
            }
            else if (b > a)
            {
                maior = b;
            }
            else
            {
                Console.WriteLine("Valor inválido, tente novamente!");
            }

            return maior;
        }

        public int GetInput()
        {
            int valor = 0;
            int[] valores = new int[4];

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite um número qualquer: ");
                valores[i] = Convert.ToInt32(Console.In.ReadLine());

                if (valores[i] > valor)
                {
                    valor = valores[i];
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente!");
                }
            }

            return valor;
        }

    }
}

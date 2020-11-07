using System;

namespace ExerciciosDeMatrz00Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 ) Leia uma matriz 5 x 5. Leia também um valor X. O programa devera fazer uma busca ´ desse valor na matriz e, ao final, escrever a localização (linha e coluna) ou uma mensagem de “nao encontrado”.
            int[][] matriz = new int[5][];

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[5];
            }

            Console.Write("Digite um número qualquer:");
            int valor = int.Parse(Console.In.ReadLine());

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (valor == matriz[i][j])
                    {
                        Console.WriteLine("Localização (linha e coluna): ");
                        Console.WriteLine(matriz[i][j]);
                    }
                    else
                    {
                        Console.WriteLine("Valor não encontrado!");
                    }
                }
            }
        }
    }
}

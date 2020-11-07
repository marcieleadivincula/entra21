using System;

namespace ExerciciosDeMatrz00Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Declare uma matriz 5 x 5. Preencha com 1 a diagonal principal e com 0 os demais elementos. Escreva ao final a matriz obtida
            int[][] matriz = new int[5][];
            //Gera a matriz
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[5];
            }

            //Para percorrer toda a matriz
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (i == j) //diagonal principal
                    {
                        matriz[i][j] = 1;
                        Console.Write(matriz[i][j]);
                    }
                    else
                    {
                        matriz[i][j] = 0;
                        Console.Write(matriz[i][j]);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

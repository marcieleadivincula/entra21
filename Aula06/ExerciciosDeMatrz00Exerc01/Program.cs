using System;

namespace ExerciciosDeMatrz00Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Leia uma matriz 4 x 4, conte e escreva quantos valores maiores que 10 ela possui.
            int[][] matriz = new int[4][];
            //Gera a matriz
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[4];
            }

            //Para percorrer toda a matriz
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (matriz[i][j] > 10)
                    {
                        Console.Write(matriz[i][j]);
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

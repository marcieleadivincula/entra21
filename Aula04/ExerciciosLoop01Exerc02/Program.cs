using System;

namespace ExerciciosLoop01Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosLoop01Exerc02");
            //2) Gostaria de saber todos os números pares entre 0 e 23, desenvolva um algoritmo que resolve meu problema
            for (int i = 0; i <= 23; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Par: " + i);
                }
            }
        }
    }
}

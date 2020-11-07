using System;

namespace ExerciciosLoop01Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosLoop01Exerc01");
            //1) Eu gostaria de contar de 1 até 10, desenvolva um algoritmo que resolve meu problema
            Console.WriteLine("Usando um for: ");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Número: " + i);
            }

            Console.WriteLine();
            Console.WriteLine("Usando um while: ");
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine("Número: " + num);
                num++;
            }
        }
    }
}

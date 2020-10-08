using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste");

            int[] vetorNumeros = new int[10];
            string[] vetorNomes = new string[10];

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                Console.Write($"Insira {i}° número: ");
                vetorNumeros[i] = int.Parse(Console.In.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < vetorNomes.Length; i++)
            {
                Console.Write($"Insira {i}° nome: ");
                vetorNomes[i] = Console.In.ReadLine();
            }
            Console.WriteLine();

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                Console.WriteLine("Número: " + vetorNumeros[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < vetorNomes.Length; i++)
            {
                Console.WriteLine("Nome: " + vetorNomes[i]);
            }
        }
    }
}

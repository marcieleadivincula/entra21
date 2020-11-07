using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula de Arrays");
            // <tipo>[] <nomeDaVariavel> = new <tipo>[<tamanhoDoArray>];
            //Exemplos
            int[] arr1 = new int[10];
            double[] arr2 = new double[5];
            string[] arr3 = new string[7];
            char[] arr4 = new char[8];
            Random[] arr5 = new Random[15];

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

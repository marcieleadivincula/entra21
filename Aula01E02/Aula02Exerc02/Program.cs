using System;

namespace Aula02Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Fixação – Introdução à Programação");
            //Exercício B
            //b) Escreva um algoritmo que solicita ao usuário 3 valores inteiros via teclado e depois exibe os números fornecidos.
            int x = Convert.ToInt32(Console.In.ReadLine());
            int y = Convert.ToInt32(Console.In.ReadLine());
            int z = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine("================================================================================================");
            Console.WriteLine("Valor de X = " + x);
            Console.WriteLine("Valor de Y = " + y);
            Console.WriteLine("Valor de Z = " + z);
        }
    }
}

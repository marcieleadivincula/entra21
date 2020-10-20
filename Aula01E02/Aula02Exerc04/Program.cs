using System;

namespace Aula02Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Fixação – Introdução à Programação");
            //Exercício D
            //d) Ler dois valores inteiros (variáveis A e B) e apresentar o resultado do quadrado do primeiro valor (variável A) mais o quadrado do segundo valor (variável B).
            Console.Write("Primeiro valor: ");
            int a = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Segundo valor: ");
            int b = Convert.ToInt32(Console.In.ReadLine());
            a = a * a;
            b = b * b;
            Console.WriteLine("================================================================================================");
            Console.WriteLine("Resultado ao quadrado " + (a + b));
        }
    }
}

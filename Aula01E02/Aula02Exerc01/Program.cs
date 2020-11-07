using System;

namespace Aula02Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Fixação – Introdução à Programação");
            //Exercício A - 
            //a) Declarar uma variável A, ler um valor para ela e escrever o valor da variável A em seguida.
            Console.Write("Insira um número: ");
            int a = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine("===============================================");
            Console.WriteLine("Valor digitado = " + a);
        }
    }
}

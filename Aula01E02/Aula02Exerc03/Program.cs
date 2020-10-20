using System;

namespace Aula02Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Fixação – Introdução à Programação");
            //Exercício C
            //c) Efetuar a leitura de um número inteiro e apresentar o resultado do quadrado desse número.
            Console.Write("Digite um número: ");
            int a = Convert.ToInt32(Console.In.ReadLine());
            a = a * a;
            Console.WriteLine("Valor ao quadrado = " + a);
        }
    }
}

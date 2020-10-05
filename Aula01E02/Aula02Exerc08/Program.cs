using System;

namespace Aula02Exerc08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Fixação – Introdução à Programação");
            //Exercício H
            //h) Ler dois valores para as variáveis A e B, e efetuar a troca dos valores de forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.
            int a = Convert.ToInt32(Console.In.ReadLine());
            int b = Convert.ToInt32(Console.In.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Valor de A = " + a);
            Console.WriteLine("Valor de B = " + b);
        }
    }
}

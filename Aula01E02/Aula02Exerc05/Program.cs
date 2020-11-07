using System;

namespace Aula02Exerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Fixação – Introdução à Programação");
            //Exercício E
            //e) Elaborar um programa que efetue a apresentação do valor da conversão em real (R$) de um valor lido em dólar (US$). O programa deverá solicitar o valor da cotação do dólar e também a quantidade de dólares disponível com o usuário.
            Console.Write("Digite o valor para conversão: ");
            int totalDolar = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Digite o valor da cotação: ");
            int cotacaoDolar = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Resultado = " + (totalDolar * cotacaoDolar) + " reais");
            Console.WriteLine("Quantidade de dólares = " + totalDolar);
        }
    }
}

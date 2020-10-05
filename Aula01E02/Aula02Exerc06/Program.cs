using System;

namespace Aula02Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Fixação – Introdução à Programação");
            //Exercício F
            //f) Elaborar um programa que efetue a apresentação do valor da conversão em dólar (US$) de um valor lido em real (R$). O programa deverá solicitar o valor da cotação do dólar e também a quantidade de reais disponível com o usuário.
            Console.WriteLine("Digite o valor para conversão: ");
            double totalReal = Convert.ToDouble(Console.In.ReadLine());
            Console.WriteLine("Digite o valor da cotação: ");
            double cotacaoReal = Convert.ToDouble(Console.In.ReadLine());
            Console.WriteLine("================================================================================================");
            Console.WriteLine("Resultado = " + (totalReal / cotacaoReal) + " dólares");
            Console.WriteLine("Quantidade de reais = " + totalReal);
        }
    }
}

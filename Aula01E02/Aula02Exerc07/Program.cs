using System;

namespace Aula02Exerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Fixação – Introdução à Programação");
            //Exercício G
            //g) Os artigos de uma loja possuem um valor associado a si. Na compra a vista, é concedido um desconto de 8% mas, comprando em 3 vezes há um acréscimo de 15% no valor do artigo. Faça um algoritmo que tendo como entrada o valor do artigo, mostre como resultado o valor a vista e o valor das parcelas a prazo.
            double valorArtigo = Convert.ToDouble(Console.In.ReadLine());
            double avista = valorArtigo * 0.08, tresVezes = valorArtigo * 0.15;
            Console.WriteLine("================================================================================================");
            Console.WriteLine("Valor à vista = " + (valorArtigo - avista));
            Console.WriteLine("Valor parcelado em 3x = " + (valorArtigo + tresVezes));
            0.92 ou .92
            int produto = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine("Valor à vista -> " + (produto * 0.92) + " reais" + " valor parcelado em 3x -> " + (produto * 1.15) + " reais");
        }
    }
}

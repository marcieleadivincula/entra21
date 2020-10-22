using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosDeVAOpt101Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - Variáveis Avançadas");
            //3) Crie uma Lista que armazena 3 valores vindo do usuario, depois, mostre apenas o maior dentre eles , se todos forem iguais, exiba uma mensagem dizendo “sao todos iguais”.
            Console.Write("Insira o valor1: ");
            var valor1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor2: ");
            var valor2 = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor3: ");
            var valor3 = double.Parse(Console.ReadLine());

            List<double> lista = new List<double>(3);
            lista.Add(valor1);
            lista.Add(valor2);
            lista.Add(valor3);

            //lista.Sort();
            //lista.Reverse();

            double maior = 0, iguais = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > maior)
                {
                    maior = lista[i];
                }
                else if(lista[i] == iguais)
                {
                    iguais = lista[i];
                    Console.WriteLine("São todos iguais!");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(maior);

            //foreach (var valor in lista)
            //{
            //    if (valor > maior)
            //    {
            //        maior = valor;
            //        Console.WriteLine(valor);
            //    }
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExerciciosDeVAOpt101Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - Variáveis Avançadas");
            //2) Crie uma Lista que armarmazene 3 notas vindo do usuario, depois, de a média das três notas.

            Console.Write("Nota1: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Nota2: ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("Nota3: ");
            var c = double.Parse(Console.ReadLine());

            List<double> notas = new List<double>(3);
            notas.Add(a);
            notas.Add(b);
            notas.Add(c);

            Console.WriteLine();
            notas.Sort();

            //Console.WriteLine(notas[0]);
            Console.WriteLine(notas.ToArray());

            //Console.WriteLine(notas[notas.Count - 1]);
            a = 0;
            for (int i = 0; i < notas.Count; i++)
            {
                a += notas[i];
                //Console.WriteLine(notas[i]);
            }

            //double elementos = notas.Count; //vê os elementos existentes na lista 
            //double qtd = notas.Capacity; //vê a capacidade da lista

            double result = a / notas.Count;
            Console.WriteLine("{0:#.##}", result);
        }
    }
}

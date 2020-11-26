using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeExcecaopt301Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Crie um programa que recebe 1 número e então eleve-o ao quadrado caso o número seja maior que 10, caso menor, nao faça nada(use Lambda)
            Console.Write("Insira um número: ");
            int numero = int.Parse(Console.ReadLine());

            Func<int, int> quadrado = x => {
                int result = (numero > 10) ? numero * numero : numero;
                return result;
            };
            Console.WriteLine(quadrado(numero));
            Console.ReadLine();
        }
    }
}

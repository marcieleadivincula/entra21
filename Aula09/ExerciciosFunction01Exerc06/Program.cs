using System;

namespace ExerciciosFunction01Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 1 - Function");

            //6) Escreva uma função que recebe 5 valores e retorne o resultado da seguinte fórmula
            Program pro = new Program();
            double num1, num2, num3, num4, num5;

            Console.Write("Digite o valor 1: ");
            num1 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite o valor 2: ");
            num2 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite o valor 3: ");
            num3 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite o valor 4: ");
            num4 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite o valor 5: ");
            num5 = Convert.ToDouble(Console.In.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Resultado: " + pro.Formula(num1, num2, num3, num4, num5));
        }

        public double Formula(double a, double b, double c, double d, double e)
        {
            double resultado = (a + b + c) / (d * e);
            return resultado;
        }
    }
}

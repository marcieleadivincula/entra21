using System;

namespace ExerciciosFunction01Exerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 1 - Function");

            //7) Escreva uma função que retorne a reta da hipotenusa de um triângulo retângulo
            Program pro = new Program();
            double valor1, valor2, valor3;
            Console.Write("Digite a valor 1: ");
            valor1 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite a valor 2: ");
            valor2 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite a valor 3: ");
            valor3 = Convert.ToDouble(Console.In.ReadLine());

            Console.WriteLine("" + pro.Hipotenusa());
        }

        public double Hipotenusa(double a, double b, double c)
        {
            double quadradoA = a * a;
            double quadradoB = b * b;
            double quadradoC = c * c;
            quadradoC = quadradoA + quadradoB;
            double hipotenusa = quadradoA + quadradoB;

            return hipotenusa;
        }
    }
}

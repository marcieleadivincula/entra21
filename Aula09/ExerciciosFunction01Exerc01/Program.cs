using System;

namespace ExerciciosFunction01Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 1 - Function");

            //1) Escreva uma função que receba dois números inteiros retorne o menor número
            Program pro = new Program();
            int x, y;

            Console.WriteLine("Digite dois números inteiros:");
            Console.Write("Insira o valor de X: ");
            x = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Insira o valor de Y: ");
            y = Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("Este é o menor deles \n" + pro.Compara(x, y));
            Console.In.ReadLine();
        }

        public int Compara(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}

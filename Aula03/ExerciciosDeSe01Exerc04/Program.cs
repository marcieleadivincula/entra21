using System;

namespace ExerciciosDeSe01Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc04");
            //4) Receba três valores, apresente na tela apenas o maior deles
            Console.Write("Valor de A: ");
            int a = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Valor de B: ");
            int b = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Valor de C: ");
            int c = Convert.ToInt32(Console.In.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("São iguais!");
            }
        }
    }
}

using System;

namespace ExerciciosDeSe01Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc03");
            //3) Receba dois valores, apresente na tela apenas o maior deles
            Console.Write("Valor de A:");
            int a = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Valor de B:");
            int b = Convert.ToInt32(Console.In.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (b > a)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("São iguais!");
            }
        }
    }
}

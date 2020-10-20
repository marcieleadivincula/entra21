using System;

namespace ExerciciosDeSe01Exerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc07");
            //7) Receba um número, e informe se ele é par ou ímpar   int a = 6 % 2(resto divisão)
            // 2 * k + 1; ou usamos %
            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.In.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Número é par!");
            }
            else
            {
                Console.WriteLine("Número é ímpar!");
            }
        }
    }
}

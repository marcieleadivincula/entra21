using System;

namespace ExerciciosLoop01Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosLoop01Exerc04");
            //4) Após receber um número do usuario, apresentar em ordem decrescente até 0, se o número for menor que 0 apresente em ordem crescente até 0
            Console.Write("Insira um número: ");
            int num = int.Parse(Console.In.ReadLine());

            for (int i = 0; i < num; i++)
            {
                if (num < 0)
                {
                    num++;
                    Console.WriteLine("Número: " + num);
                }
                else
                {
                    num--;
                    Console.WriteLine("Número: " + num);
                }
            }
        }
    }
}

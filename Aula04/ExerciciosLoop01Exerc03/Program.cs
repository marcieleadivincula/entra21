using System;

namespace ExerciciosLoop01Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosLoop01Exerc03");
            //3) Após receber um número do usuario, apresentar em ordem decrescente até 0
            Console.Write("Insira um número: ");
            int num = int.Parse(Console.In.ReadLine());

            //while (num > 0)
            //{
            //    num--;
            //    Console.WriteLine("Número: " + num);
            //}

            for (int i = 0; i < num; i++)
            {
                num--;
                Console.WriteLine("Número: " + num);
            }

            //do
            //{
            //    Console.WriteLine("Número: " + num);
            //    num--;
            //} while (num > 0);
        }
    }
}

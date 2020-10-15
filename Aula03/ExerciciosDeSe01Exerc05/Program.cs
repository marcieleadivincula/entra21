using System;

namespace ExerciciosDeSe01Exerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc05");
            //5) Receba um número qualquer de entrada, se for 1 apresente na tela “1”, se 2 apresente “2”, se for 3 apresente “3” e se não for nenhuma das anteriores apresente “não computável” (use a função Switch)
            int valor = Convert.ToInt32(Console.In.ReadLine());

            switch (valor)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                default:
                    Console.WriteLine("Não computável!");
                    break;
            }
        }
    }
}

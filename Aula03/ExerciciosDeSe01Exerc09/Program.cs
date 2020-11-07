using System;

namespace ExerciciosDeSe01Exerc09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc09");
            //9) Receba o salário de um funcionário, baseado no valor que esta na tabela abaixo (IMAGEM no word), então, apresente o salário com aumento. OBS: tem uma imagem - tabela

            Console.Write("Salário: ");
            double salario = Convert.ToDouble(Console.In.ReadLine());

            if (salario >= 3550.01)
            {
                salario *= 1.10;
            }
            else if (salario >= 2400.01)
            {
                salario *= 1.15;
            }
            else if (salario >= 1100.01)
            {
                salario *= 1.20;
            }
            else if (salario >= 600.01)
            {
                salario *= 1.25;
            }
            else
            {
                salario *= 1.30;
            }

            Console.WriteLine("Salário com aumento: " + salario);
        }
    }
}

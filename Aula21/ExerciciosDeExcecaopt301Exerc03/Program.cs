using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeExcecaopt301Exerc03
{
    class Program
    {
        enum Potencias : int
        {
            a = 2 * 2,
            b = 3 * 3,
            c = 4 * 4,
            d = 5 * 5,
            e = 6 * 6,
            f = 7 * 7,
            g = 8 * 8,
            h = 9 * 9,
            i = 10 * 10,
            //num,
            //result = num * num
        }
        static void Main(string[] args)
        {
            //3) Use um enum para determinar as potências de 2 até 10
            for (int i = 2; i <= 10; i++)
            {
                int num;

                switch (i)
                {
                    case 2:
                        num = Convert.ToInt32(Potencias.a);
                        Console.WriteLine("2 * 2 = " + num);
                        break;
                    case 3:
                        num = Convert.ToInt32(Potencias.b);
                        Console.WriteLine("3 * 3 = " + num);
                        break;
                    case 4:
                        num = Convert.ToInt32(Potencias.c);
                        Console.WriteLine("4 * 4 = " + num);
                        break;
                    case 5:
                        num = Convert.ToInt32(Potencias.d);
                        Console.WriteLine("5 * 5 = " + num);
                        break;
                    case 6:
                        num = Convert.ToInt32(Potencias.e);
                        Console.WriteLine("6 * 6 = " + num);
                        break;
                    case 7:
                        num = Convert.ToInt32(Potencias.f);
                        Console.WriteLine("7 * 7 = " + num);
                        break;
                    case 8:
                        num = Convert.ToInt32(Potencias.g);
                        Console.WriteLine("8 * 8 = " + num);
                        break;
                    case 9:
                        num = Convert.ToInt32(Potencias.h);
                        Console.WriteLine("9 * 9 = " + num);
                        break;
                    case 10:
                        num = Convert.ToInt32(Potencias.i);
                        Console.WriteLine("10 * 10 = " + num);
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine("-----------------------//------------------------");
            Console.WriteLine(Convert.ToInt32(Potencias.a));
            Console.WriteLine(Convert.ToInt32(Potencias.b));
            Console.WriteLine(Convert.ToInt32(Potencias.c));
            Console.WriteLine(Convert.ToInt32(Potencias.d));
            Console.WriteLine(Convert.ToInt32(Potencias.e));
            Console.WriteLine(Convert.ToInt32(Potencias.f));
            Console.WriteLine(Convert.ToInt32(Potencias.g));
            Console.WriteLine(Convert.ToInt32(Potencias.h));
            Console.WriteLine(Convert.ToInt32(Potencias.i));

            Console.ReadLine();
        }
    }
}

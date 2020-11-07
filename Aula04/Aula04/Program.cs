using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula de Laços");


            //Console.WriteLine("Usando do...while");
            //int a = 0;
            //do
            //{
            //    a++;
            //    Console.WriteLine("Valor de a -> " + a);
            //} while (a < 5);


            //Console.WriteLine();
            //Console.WriteLine("Usando While");
            //int b = 0;
            //while (b < 5)
            //{
            //    Console.WriteLine("Valor de b -> " + b);
            //    b++;
            //}

            //Console.WriteLine();
            //Console.WriteLine("Outro exemplo");
            //int c = 0, d = -3;
            //string cafe = "Quero caféé";
            //do
            //{
            //    c++;
            //    d++;
            //} while (c < 3);

            //while (d < 6)
            //{
            //    d++;
            //    cafe = cafe + "é";
            //    Console.WriteLine(cafe);
            //}

            //Console.WriteLine("Desculpe...");

            //Console.WriteLine();
            //Console.WriteLine("Outro exemplo");
            //int x = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    x = i;
            //    if (x > 4 && x < 8)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}

            Console.WriteLine();
            Console.WriteLine("Outro exemplo");
            int z = 0;

            for (int i = 0; i < 1000000; i++)
            {
                z = i * 2;
                //Console.WriteLine(z);
                if (z == 3 || z > 20)
                {
                    Console.WriteLine(z);
                    break;
                }
            }
        }

    }
}

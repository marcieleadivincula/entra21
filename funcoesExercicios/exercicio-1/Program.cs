using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1: Escreva uma função que receba dois números inteiros retorne o menor número
            Program pro = new Program();
            int x, y;
            x = Convert.ToInt32(Console.In.ReadLine());
            y = Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("Este é o menor deles \n" + pro.Compara(x, y));
            Console.In.ReadLine();


        }

        //Exercício 1
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

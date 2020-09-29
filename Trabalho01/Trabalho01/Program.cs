using System;

namespace Trabalho01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalho 01");

            int[][] estoque; //a matriz que você irá criar
            GeraBD log = new GeraBD(); //uma instância do objeto que gerará a matriz inicial
            estoque = log.GeraMatriz(); //a matriz que você criou recebendo a matriz gerada

            int contador = 0, categoria;

            for (int i = 0; i < estoque.Length; i++)
            {
                estoque[i] = new int[40];

                for (int j = 0; j < estoque[i].Length; j++)
                {
                    Console.Write("Insira a categoria: ");
                    categoria = Convert.ToInt32(Console.In.ReadLine());

                    if (contador == 39)
                    {
                        contador = 0;
                        Console.WriteLine();
                    }
                    contador++;

                    Console.Write(estoque[i][j] + "|");
                }
                Console.WriteLine();
            }

            //Console.BackgroundColor = ConsoleColor.DarkMagenta;// Muda a cor da tela.
            //Console.ForegroundColor = ConsoleColor.White;// Muda a cor da letra.
            //Console.Clear();
            //Console.ReadLine();

            //Produto[] prod = new Produto[4];
            //int categoria;

            //for (int i = 0; i < estoque.Length; i++)
            //{
            //    estoque[i] = new int[40];

            //    Console.Write("Insira a categoria: ");
            //    categoria = Convert.ToInt32(Console.In.ReadLine());

            //    for (int j = 0; j < estoque[i].Length; j++)
            //    {
            //        if (categoria == 1)
            //        {
            //            estoque[i][j] = 1;
            //            Console.Write(estoque[i][j]);
            //        }
            //        else if (categoria == 2)
            //        {
            //            estoque[i][j] = 2;
            //            Console.Write(estoque[i][j]);
            //        }
            //        else if (categoria == 3)
            //        {
            //            estoque[i][j] = 3;
            //            Console.Write(estoque[i][j]);
            //        }
            //        else if (categoria == 4)
            //        {
            //            estoque[i][j] = 4;
            //            Console.Write(estoque[i][j]);
            //        }
            //        else
            //        {
            //            estoque[i][j] = 0;
            //            Console.Write(estoque[i][j]);
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}

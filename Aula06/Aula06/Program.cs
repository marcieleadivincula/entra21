using System;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula de Matriz");

            string[][] matriz = new string[3][];
            matriz[0] = new string[4];
            matriz[1] = new string[5];
            matriz[2] = new string[1];

            int a = matriz.Length; //Quantidade de linhas que a matriz possui
            int b = matriz[0].Length; //Quantidade de colunas que a matriz possui
            int c = matriz[1].Length; //Quantidade de colunas que a matriz possui
            int d = matriz[2].Length; //Quantidade de colunas que a matriz possui

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine();
            //Funções úteis:
            //Gera a matriz
            string[][] mtz = new string[10][];
            for (int i = 0; i < mtz.Length; i++)
            {
                mtz[i] = new string[10];
            }

            Console.WriteLine();
            string[][] mtz2 = new string[10][];
            //Para percorrer toda a matriz
            for (int i = 0; i < mtz2.Length; i++)
            {
                mtz2[i] = new string[10];
                for (int j = 0; j < mtz2[i].Length; j++)
                {
                    mtz2[i][j] = i + "." + j + " |";
                    Console.Write(mtz2[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Outro exemplo: ");
            int[][] matriz2 = new int[3][];
            int vF = 0;

            for (int i = 0; i < matriz2.Length; i++)
            {
                matriz2[i] = new int[3];

                for (int j = 0; j < matriz2[i].Length; j++)
                {
                    matriz2[i][j] = 3;
                    vF = vF + matriz2[i][j];
                }
            }
            Console.WriteLine(vF);

            Console.WriteLine();
            Console.WriteLine("Outro exemplo: ");
            int[][] matriz3 = new int[3][];
            int vD = 0;

            for (int i = 0; i < matriz3.Length; i++)
            {
                matriz3[i] = new int[3];

                for (int j = 0; j < matriz3[i].Length; j++)
                {
                    matriz3[i][j] = j;
                    vD = vD + matriz3[i][j];
                }
            }
            Console.WriteLine(vD);



            Console.WriteLine();
            Console.WriteLine("Outro exemplo: ");
            int[][] matriz4 = new int[3][];
            int vG = 0;

            for (int i = 0; i < matriz4.Length; i++)
            {
                matriz4[i] = new int[3];

                for (int j = 0; j < matriz4[i].Length; j++)
                {
                    if (i == j)
                    {
                        matriz4[i][j] = 10;
                        vG = vG + matriz4[i][j];
                    }
                }
            }
            Console.WriteLine(vG);


            Console.WriteLine();
            Console.WriteLine("Outro exemplo: ");
            int[][] matriz5 = new int[10][];
            int vH = 0;

            for (int i = 0; i < matriz5.Length; i++)
            {
                matriz5[i] = new int[3];
            }

            for (int i = 0; i < matriz5.Length; i++)
            {
                matriz5[i][0] = 10;
                vH = vH + matriz5[i][2];
            }
            Console.WriteLine(vH);
        }
    }
}

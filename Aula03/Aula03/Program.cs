using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY
            //1- Uma Dimensão
            //definindo o tamanho e o operador new
            int[] numeros = new int[5] { 1, 2, 3, 4, 5 };
            string[] nomes = new string[3] { "Mac", "Jessica", "MiMi" };
            //omitindo o tamanho do array
            int[] numeros2 = new int[] { 1, 2, 3, 4, 5 };
            string[] nomes2 = new string[] { "Mac", "Jessica", "MiMi" };
            // Omitindo o operador new
            int[] numeros3 = { 1, 2, 3, 4, 5 };
            string[] nomes3 = { "Mac", "Jessica", "MiMi" };

            //2- Mais de uma Dimensão
            //definindo o tamanho e o operador new
            int[,] numeros4 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] amigos = new string[2, 2] { { "Mac", "Jan" }, { "Mimi", "Jeff" } };
            //omitindo o tamanho do array
            int[,] numeros5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] amigos1 = new string[,] { { "Mac", "Jan" }, { "Mimi", "Jeff" } };
            //Omitindo o operador new
            int[,] numeros6 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] amigos2 = { { "Mac", "Jan" }, { "Mimi", "Jeff" } };

            //3- Arrays de Arrays (jagged arrays)
            //definindo o tamanho e o operador new
            int[][] numeros7 = new int[2][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };
            //omitindo o tamanho do array
            int[][] numeros8 = new int[][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };
            // ou
            int[][] numeros9 = { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };


            //Acessando e percorrendo Arrays
            //int[] numeros10 = { 10, 9, 8, 7, 6 };
            //listBox1.Items.Add("Primeiro elemento: " + numeros10[0]);
            //listBox1.Items.Add("Segundo elemento: " + numeros10[1]);
            //listBox1.Items.Add("Terceiro elemento: " + numeros10[2]);
            //listBox1.Items.Add("Quarto elemento: " + numeros10[3]);
            //listBox1.Items.Add("Quinto elemento: " + numeros10[4]);
            //OU
            //int[,] numeros2 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            //listBox2.Items.Add("numeros2[0,0] = " + numeros2[0, 0]);
            //listBox2.Items.Add("numeros2[0,1] = " + numeros2[0, 1]);
            //listBox2.Items.Add("numeros2[1,0] = " + numeros2[1, 0]);
            //listBox2.Items.Add("numeros2[1,1] = " + numeros2[1, 1]);
            //listBox2.Items.Add("numeros2[2,0] = " + numeros2[2, 0]);
            //listBox2.Items.Add("numeros2[2,1] = " + numeros2[2, 1]);
            //listBox2.Items.Add("numeros2[3,0] = " + numeros2[3, 0]);
            //listBox2.Items.Add("numeros2[3,1] = " + numeros2[3, 1]);
            //listBox2.Items.Add("numeros2[4,0] = " + numeros2[4, 0]);
            //listBox2.Items.Add("numeros2[4,1] = " + numeros2[4, 1]);

            string[,] cesta = new string[3,2] { { "Maçã", "100" }, { "Pera", "200" }, { "Melão", "300" } };


            for (int i = 0; i < cesta.Length; i++)
            {
                for (int j = i; j < 2; j++)
                {
                    Console.WriteLine(cesta[i, j]);
                }
            }

            foreach (var fruta in cesta)
            {
                Console.WriteLine("Fruta: " + fruta);
            }

            int[] array1 = new int[] { 1, 3, 5, 7, 9 };
            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            int[] array2 = { 1, 3, 5, 7, 9 };
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //Matrizes de tipo de valor e de tipo de referência
            //SomeType[] array4 = new SomeType[10];
        }
    }
}

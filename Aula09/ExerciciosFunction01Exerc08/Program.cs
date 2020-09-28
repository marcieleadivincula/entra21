using System;

namespace ExerciciosFunction01Exerc08
{
    class Program
    {
        static void Main(string[] args)
        {
            //8) Escreva uma função que começa pedindo um número N ao usuário e depois pede N números. Afunção deverá mostrar na tela todos esses números ordenados do menor para o maior. Escreva sua própria função de ordenação.
            Program ordenacao = new Program();
            ordenacao.OrdenaNumeros();

            //MEU
            //Program pro = new Program();
            //Console.Write("Digite um número: ");
            //double numer = Convert.ToDouble(Console.In.ReadLine());

            //Console.WriteLine("Resultado: " + pro.GetNumbers(numer));
        }

        public void OrdenaNumeros()
        {
            Console.Write("Diga quantos números deseja inserir: ");
            int numero = Convert.ToInt32(Console.In.ReadLine());

            int[] vetNumeros = new int[numero];

            for (int i = 0; i < vetNumeros.Length; i++)
            {
                vetNumeros[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            //Escreve o vetor na tela desordenado
            for (int i = 0; i < vetNumeros.Length; i++)
            {
                Console.Write(vetNumeros[i] + " ");
            }

            for (int i = 0; i < vetNumeros.Length; i++) //seta que vai pra direita
            {
                for (int j = 0; j > 0; j++) //seta que vai pra esquerda
                {
                    if (vetNumeros[j - 1] > vetNumeros[j])
                    {
                        int temp = vetNumeros[j];
                        vetNumeros[j] = vetNumeros[j - 1];
                        vetNumeros[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();
            //Printa o vetor organizado
            for (int i = 0; i < vetNumeros.Length; i++)
            {
                Console.WriteLine(vetNumeros[i] + " ");
            }
        }

        //MEU 8
        //public double GetNumbers(double num)
        //{
        //    //double 
        //    for (int i = 0; i < num; i++)
        //    {

        //    }
        //}
    }
}

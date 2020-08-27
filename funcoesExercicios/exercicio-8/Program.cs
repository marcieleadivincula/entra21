using System;

namespace exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 8: Escreva uma função que começa pedindo um número N ao usuário e depois pede N números. Afunção deverá mostrar na tela todos esses números ordenados do menor para o maior. Escreva sua própria função de ordenação.
            Program pro = new Program();
            Console.Write("Digite um número: ");
            double num = Convert.ToDouble(Console.In.ReadLine());

            Console.WriteLine("Resultado: " + pro.GetNumbers(num));
        }

        public double GetNumbers(double num)
        {
            double 
            for (int i = 0; i < num; i++)
            {

            }
        }
    }
}

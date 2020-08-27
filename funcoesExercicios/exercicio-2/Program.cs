using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 2: Faça uma função que recebe um valor inteiro e verifica se o valor é par. A função deve retornar 1 se o número for par e 0 se for ímpar
            Program pro = new Program();
            Console.Write("Digite um número qualquer: ");
            int numero = Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("RESULTADO: " + pro.EhPar(numero));
        }

        public int EhPar(int num)
        {
            if (num % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

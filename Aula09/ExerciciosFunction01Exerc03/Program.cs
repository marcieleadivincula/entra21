using System;

namespace ExerciciosFunction01Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 1 - Function");

            //3) Faça uma função que recebe um valor inteiro e verifica se o valor é positivo, negativo ou zero. A função deve retornar 1 para valores positivos, -1 para negativos e 0 para o valor 0.
            Program pro = new Program();
            Console.Write("Digite um número qualquer: ");
            int num = Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("RESULTADO:: " + pro.VerificaValor(num));
        }

        public int VerificaValor(int valor)
        {
            if (valor > 0)
            {
                return 1;
            }
            else if (valor < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

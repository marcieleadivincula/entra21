using System;

namespace ExerciciosDeSe01Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc02");
            //2) Recebe dois números, apresente na tela “são iguais” caso sejam iguais, caso contrário apresente qualquer outra mensagem
            Console.Write("Valor1: ");
            int valor1 = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Valor2: ");
            int valor2 = Convert.ToInt32(Console.In.ReadLine());

            if (valor1 == valor2)
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }
        }
    }
}

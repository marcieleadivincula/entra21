using System;

namespace ExerciciosDeSe01Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc01");
            //1) Receba um valor numérico qualquer do usuário, se for maior que 10 apresente este número na tela, caso contrário apresente “Não é maior que 10”
            int valor = Convert.ToInt32(Console.In.ReadLine());
            if (valor >= 10)
            {
                Console.WriteLine(valor);
            }
            else
            {
                Console.WriteLine("Não é maior que 10");
            }
        }
    }
}

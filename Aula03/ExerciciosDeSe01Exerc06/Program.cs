using System;

namespace ExerciciosDeSe01Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc06");
            //6) Simule o lançamento de um dado de seis faces (use a função Random) se o resultado for maior ou igual a 3 , mostre na tela “você venceu”, caso contrário, você perdeu  Random nomeDeVariavel = new Random();   nomeDeVariavel.Next(0,1)  
            Random dado = new Random();

            int valor = dado.Next(1, 7);

            if (valor >= 3)
            {
                Console.WriteLine(valor);
                Console.WriteLine("Você venceu!");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }
        }
    }
}

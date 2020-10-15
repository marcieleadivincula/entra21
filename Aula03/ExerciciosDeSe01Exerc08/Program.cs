using System;

namespace ExerciciosDeSe01Exerc08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc08");
            //8) Receba um valor de produto, se o produto custar mais que R$254,50 deve-se aplicar um desconto de 28% e mostrar na tela o valor original e com desconto, caso contrário, o desconto deve ser de apenas 21% e mostrar na tela o valor original e com desconto
            double valorProduto = Convert.ToDouble(Console.In.ReadLine());
            double desconto;

            if (valorProduto >= 254.50)
            {
                //desconto de 28%
                desconto = valorProduto * .72; //o C# entende que é um valor com ponto flutuante
            }
            else
            {
                //desconto de 21%
                desconto = valorProduto * .79;
            }

            Console.WriteLine("Valor original: " + valorProduto);
            Console.WriteLine("Valor com desconto: " + desconto);
        }
    }
}

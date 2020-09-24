using System;

namespace ExercíciosArray01Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando lista 1 de exercícios de Array");
            //2) Crie um vetor que armarmazene 3 notas vindo do usuario, depois, de a média das três notas
            double[] notas = new double[3];
            double media, soma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a " + i + "º nota: ");
                notas[i] = Convert.ToDouble(Console.In.ReadLine());

                soma += notas[i];
            }

            media = soma / 3;
            Console.WriteLine();
            Console.WriteLine("Média = " + media);
        }
    }
}

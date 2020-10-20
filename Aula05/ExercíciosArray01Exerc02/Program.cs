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

            Console.WriteLine("Insira um valor com ponto em vez de vírgula.");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a " + i + "º nota: ");
                //notas[i] = Convert.ToDouble(Console.In.ReadLine());
                notas[i] = double.Parse(Console.In.ReadLine());

                soma += notas[i];
            }

            media = soma / 3;
            Console.WriteLine();
            Console.WriteLine("Média = " + media);
        }
    }
}

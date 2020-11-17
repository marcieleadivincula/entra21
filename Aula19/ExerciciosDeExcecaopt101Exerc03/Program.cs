using System;
using System.Diagnostics;

namespace ExerciciosDeExcecaopt101Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Crie um programa que recebe três números (double) entre 0 e 10, se por acaso o número for grande demais avise “Numero gigantesco” caso tiver letras e afins, avise “Apenas números” e então, peça novamente até dar certo.
            //Após receber os tres números, mostre a média deles no console

            double[] num = new double[3];
            double soma = 0.0, media;

            for (int i = 0; i < num.Length; i++)
            {
                try
                {
                    Console.Write("Digite o " + i + " número:");
                    num[i] = int.Parse(Console.ReadLine());

                    soma += num[i];

                    media = soma / 3.0;
                }
                catch (FormatException f)
                {
                    Debug.Print(f.ToString());
                    Console.WriteLine("Apenas números!");
                    Console.WriteLine("Erro: " + f.Message);
                }
                catch (OverflowException o)
                {
                    Debug.Print(o.ToString());
                    Console.WriteLine("Número gigantesco!");
                    Console.WriteLine("Erro: " + o.Message);
                }
                catch (Exception e)
                {
                    Debug.Print(e.ToString());
                    Console.WriteLine("**Erro**");
                    Console.WriteLine("Erro: " + e.Message);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Execução finalizada...Tecle enter para sair.");
            Console.ReadLine();
        }
    }
}

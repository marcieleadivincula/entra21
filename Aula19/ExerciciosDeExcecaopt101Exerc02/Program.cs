using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeExcecaopt101Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Crie um programa que recebe um número (int) qualquer, se por acaso o número for grande demais avise “Numero gigantesco” caso tiver letras e afins, avise “Ape-nas números” e então, peça novamente até dar certo, quando der certo, avise “Deu certo”
            int num;
            bool fim = false;

            while (!fim)
            {
                try
                {
                    Console.Write("Digite um número: ");
                    num = int.Parse(Console.ReadLine());
                    fim = true;

                    Console.WriteLine("Deu certo!");
                }
                catch (FormatException f)
                {
                    Debug.Print(f.ToString());
                    Console.WriteLine("Apenas números!");
                    Console.WriteLine("Mensagem: " + f.Message);
                    fim = false;
                }
                catch (OverflowException o)
                {
                    Debug.Print(o.ToString());
                    Console.WriteLine("Número gigantesco!");
                    Console.WriteLine("Mensagem: " + o.Message);
                    fim = false;
                }
                catch (Exception e)
                {
                    Debug.Print(e.ToString());
                    Console.WriteLine("***Erro***");
                    Console.WriteLine("Mensagem: " + e.Message);
                    fim = false;
                }
                finally
                {
                    Console.WriteLine("Programa finalizado...Tecle enter para sair.");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

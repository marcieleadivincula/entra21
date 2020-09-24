using System;

namespace ExercíciosArray01Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando lista 1 de exercícios de Array");
            //4) Crie um vetor que armazena 3 nomes vindo do usuario, o usuario pode, a qualquer momento, solicitar quais nomes estao armazenados.
            string[] nomes = new string[3];
            string nome = "";

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite um nome: ");
                nomes[i] = Console.In.ReadLine();

                nome = nomes[i];
            }

            Console.WriteLine();
            Console.WriteLine("Nome: " + nome);
        }
    }
}

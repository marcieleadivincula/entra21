using System;

namespace Exercicio4Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoa = new Pessoa[5];
            int maiorIdade = 0;

            for (int i = 0; i < pessoa.Length; i++)
            {
                Console.Write("Digite o nome: ");
                pessoa[i].nome = Console.In.ReadLine();
                Console.Write("Digite a idade: ");
                pessoa[i].idade = Convert.ToInt32(Console.In.ReadLine());
                Console.WriteLine();

                if (pessoa[i].idade > maiorIdade && maiorIdade >= 2)
                {
                    Console.WriteLine();
                    maiorIdade = pessoa[i].idade;
                    Console.WriteLine("Maior idade: " + maiorIdade);
                    maiorIdade++;
                }
            }

            Console.WriteLine("Nome: " + pessoa[0].nome);
            Console.WriteLine("Nome: " + pessoa[1].nome);
            Console.WriteLine("Nome: " + pessoa[2].nome);
            Console.WriteLine("Nome: " + pessoa[3].nome);
            Console.WriteLine("Nome: " + pessoa[4].nome);
            Console.WriteLine();
            Console.WriteLine("Não encontramos a pessoa mais velha! " + maiorIdade);
        }

        public struct Pessoa
        {
            public string nome;
            public int idade;
        }
    }
}

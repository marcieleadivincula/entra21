using System;

namespace ExerciciosStruct01Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de Struct - 1");

            //4) Crie 5 pessoas com nome e idade. Peça para o usuario preencher as pessoas, em seguida, diga qual a pessoa mais velha, se houver 2 ou mais pessoas mais velhas avisa-se que nao encontou a pessoa mais velha.
            Pessoas[] pessoas = new Pessoas[5];
            int maiorIdade = 0;

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.Write("Digite o nome: ");
                pessoas[i].nome = Console.In.ReadLine();
                Console.Write("Digite a idade: ");
                pessoas[i].idade = Convert.ToInt32(Console.In.ReadLine());
                Console.WriteLine();

                if (pessoas[i].idade > maiorIdade)
                {
                    maiorIdade = pessoas[i].idade;
                    maiorIdade++;
                    Console.WriteLine("Maior idade: " + maiorIdade);
                }
            }

            if (maiorIdade >= 2)
            {
                Console.WriteLine("Não encontramos a pessoa mais velha!");
            }
        }

        public struct Pessoas
        {
            public string nome;
            public int idade;
        }
    }
}

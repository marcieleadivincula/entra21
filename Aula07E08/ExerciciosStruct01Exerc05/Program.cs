using System;

namespace ExerciciosStruct01Exerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de Struct - 1");

            //5) Crie 3 animais de um zoológico com nome, raça e tempo no zoo. Peça para o usuario inseir todos os animais, em seguida, mostre todos os animas, se houver um leão
            Animal[] animal = new Animal[3];
            bool leao = false;
            int index = 0;

            for (int i = 0; i < animal.Length; i++)
            {
                index = i;
                Console.Write("Digite o nome do animal: ");
                animal[i].nome = Console.In.ReadLine();
                Console.Write("Digite a raça do animal: ");
                animal[i].raca = Console.In.ReadLine();
                Console.Write("Digite o tempo no zoo: ");
                animal[i].tempoZooDias = Convert.ToInt32(Console.In.ReadLine());

                if (animal[i].raca == "leão")
                {
                    Console.WriteLine();
                    leao = true;
                }
            }

            if (leao)
            {
                Console.WriteLine("Nome: " + animal[index].nome);
                Console.WriteLine("Raça: " + animal[index].raca);
                Console.WriteLine("Tempo no Zoo: " + animal[index].tempoZooDias);
            }
        }

        public struct Animal
        {
            public string nome;
            public string raca;
            //public DateTime tempoZoo;
            public int tempoZooDias;
        }
    }
}

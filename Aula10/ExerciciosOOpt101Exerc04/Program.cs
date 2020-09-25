using System;

namespace ExerciciosOOpt101Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");

            //4 Crie 3 animais de um zoológico com nome, espécie e tempo no zoo. Peça para o usuario inseir todos os animais, em seguida, mostre todos os animas do mais novo para o mais velho no zoo
            Animal[] animals = new Animal[3];

            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write("Insira o nome do animal: ");
                string nome = Console.In.ReadLine();
                Console.Write("Insira a espécie do animal: ");
                string especie = Console.In.ReadLine();
                Console.Write("Insira quanto tempo no zoo em dias: ");
                int tempoZoo = Convert.ToInt32(Console.In.ReadLine());

                animals[i] = new Animal(nome, especie, tempoZoo);
                Console.WriteLine();
            }

            for (int i = 0; i < animals.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (animals[j - 1].GetTempoZoo() > animals[j].GetTempoZoo()) //ordem crescente
                    {
                        Animal temp = animals[j];
                        animals[j] = animals[j - 1];
                        animals[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine("Nome: {0}, Espécie: {1}, Tempo no Zoo: {2}", animals[i].GetNome(), animals[i].GetEspecie(), animals[i].GetTempoZoo());
            }

        }
    }
}

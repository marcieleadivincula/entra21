using System;

namespace ExerciciosOOpt102Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 2");

            //2 ) Crie 5 vagas de estacionamento com placa do veículo e nome do dono. Peça para o usuário preencher as vagas(pode-se deixar vazio), em seguida, mostre todas as vagas preenchidas.
            Estacionamento[] estacionamento = new Estacionamento[5];

            for (int i = 0; i < estacionamento.Length; i++)
            {
                Console.WriteLine("Insira o nome do dono e a placa do {0}° carro", (i + 1));

                Console.Write("Nome do dono: ");
                string nomeDono = Console.In.ReadLine();
                Console.Write("Placa do carro: ");
                string placaCarro = Console.In.ReadLine();

                estacionamento[i] = new Estacionamento(nomeDono, placaCarro);
                Console.WriteLine();
            }

            for (int i = 0; i < estacionamento.Length; i++)
            {
                if (estacionamento[i].GetNomeDono() != "")
                {
                    Console.WriteLine("{0}° {1} {2}", i, estacionamento[i].GetNomeDono(), estacionamento[i].GetPlacaCarro());
                }
                else
                {
                    Console.WriteLine("{0}° {1} {2}", i, estacionamento[i].GetNomeDono(), estacionamento[i].GetPlacaCarro());
                }
            }

        }
    }
}

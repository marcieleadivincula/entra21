using System;

namespace ExerciciosOOpt102Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 2");

            //3 Crie 5 hotéis com nome,quantidade de quartos de solteiro e quantidade de quartos de casal e peça para o usuário preencher os hotéis, após isso, mostre na tela do hotel com mais vaga disponível para o com menos vaga disponível
            //OBS: Considere que os hotéis estão vazios, Cada quarto de casal representa duas vagas e o quarto de solteiro uma vaga.
            Hotel[] hotel = new Hotel[5];

            for (int i = 0; i < hotel.Length; i++)
            {
                Console.WriteLine("Insira o nome e o número de quartos: ");

                Console.Write("Nome: ");
                string nome = Console.In.ReadLine();
                Console.Write("Quantidade de quartos de solteiro: ");
                int qtdSolteiro = Convert.ToInt32(Console.In.ReadLine());
                Console.Write("Quantidade de quartos de casal: ");
                int qtdCasal = Convert.ToInt32(Console.In.ReadLine());

                hotel[i] = new Hotel(nome, qtdSolteiro, qtdCasal);
            }

            Console.WriteLine();
            for (int i = 0; i < hotel.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if ((hotel[j - 1].MultiplicaQtdCasal()) + (hotel[j - 1].GetQtdSolteiro()) < (hotel[j].MultiplicaQtdCasal()) + (hotel[j].GetQtdSolteiro()))
                    {
                        Hotel ht = hotel[j];
                        hotel[j] = hotel[j - 1];
                        hotel[j - 1] = ht;
                    }
                }
            }

            for (int i = 0; i < hotel.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", hotel[i].GetNome(), hotel[i].GetQtdSolteiro(), hotel[i].GetQtdCasal());
            }
        }
    }
}

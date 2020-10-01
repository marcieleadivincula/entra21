using System;

namespace ExerciciosOOpt401Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de OOpt - 401");
            // 4) Crie uma subClasse chamado Habitacao com tipo de habitacao, nome do dono e herda Endereco. Em seguida preencha 4 habitações e mostre todas na tela.
            Habitacao[] hab = new Habitacao[4];

            for (int i = 0; i < hab.Length; i++)
            {
                hab[i] = new Habitacao();

                Console.Write("Tipo de habitação: ");
                hab[i].TipoHabitacao = Console.ReadLine();
                Console.Write("Nome do dono: ");
                hab[i].NomeDono = Console.ReadLine();

                Console.Write("Rua: ");
                hab[i].Rua = Console.ReadLine();
                Console.Write("Número: ");
                hab[i].Numero = Console.ReadLine();
                Console.Write("Bairro: ");
                hab[i].Bairro = Console.ReadLine();
                Console.Write("Cidade: ");
                hab[i].Cidade = Console.ReadLine();
                Console.Write("Estado: ");
                hab[i].Estado = Console.ReadLine();

                Console.WriteLine();
            }

            for (int i = 0; i < hab.Length; i++)
            {
                Console.WriteLine("Tipo de habitação: {0} Nome do dono: {1}", hab[i].TipoHabitacao, hab[i].NomeDono);
                Console.WriteLine("Rua: {0} Número: {1} Bairro: {2} Cidade: {3} Estado: {4}", hab[i].Rua, hab[i].Numero, hab[i].Bairro, hab[i].Cidade, hab[i].Estado);
            }
        }
    }
}

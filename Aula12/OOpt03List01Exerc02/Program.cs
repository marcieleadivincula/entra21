using System;

namespace OOpt03List01Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 301");
            //2) Crie um Carro com nome,marca,anoDeFabricação e placa. Peça para o usuario inserir os dados e em seguida, mostre na tela
            Carro[] car = new Carro[1];

            for (int i = 0; i < car.Length; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("marca: ");
                string marca = Console.ReadLine();
                Console.Write("Ano de fabricação: ");
                int anoDeFabricação = int.Parse(Console.ReadLine());
                Console.Write("Placa: ");
                string placa = Console.ReadLine();

                car[i] = new Carro(nome, marca, anoDeFabricação, placa);
            }

            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine("Nome: {0} Marca: {1} Ano de fabricação: {2} Placa: {3}", car[i].Nome, car[i].Marca, car[i].AnoDeFabricacao, car[i].Placa);
            }
        }
    }
}

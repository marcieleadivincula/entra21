using System;

namespace OOpt03List01Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 301");
            // 1) Crie um Cachorro com nome,idade e raça. Peça para o usuario preencher o cachorro e depois mostre na tela
            Dog[] dog = new Dog[1];
            for (int i = 0; i < dog.Length; i++)
            {
                Console.Write("Insira o nome do cão: ");
                string nome = Console.ReadLine();
                Console.Write("Insira o idade do cão: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Insira o raça do cão: ");
                string raca = Console.ReadLine();

                dog[i] = new Dog(nome, idade, raca);
            }

            for (int i = 0; i < dog.Length; i++)
            {
                Console.WriteLine("Nome: {0} Idade: {1} Raça: {2}", dog[i].GetNome(), dog[i].GetIdade(), dog[i].GetRaca());
            }
        }
    }
}

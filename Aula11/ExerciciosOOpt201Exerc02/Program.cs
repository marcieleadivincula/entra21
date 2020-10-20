using System;
using System.ComponentModel;

namespace ExerciciosOOpt201Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Exercícios - OOpt201");
            //2) Crie 4 pessoas com nome,idade e genero. Peça para o usuario preencher as pessoas, em seguida, diga qual o homem mais velho e qual a mulher mais velha.
            Pessoa[] pes = new Pessoa[4];
            int idade;

            for (int i = 0; i < pes.Length; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Gênero: ");
                char genero = char.Parse(Console.ReadLine());

                pes[i] = new Pessoa(nome, idade, genero);
            }

            Console.WriteLine();
            for (int i = 0; i < pes.Length; i++)
            {
                if (pes[i].ValidaGenero() == true)
                {
                    Console.WriteLine("Nome: {0} Idade: {1} Gênero: {2}", pes[i].Nome, pes[i].Idade, pes[i].Genero);
                }
                else if (pes[i].ValidaGenero() == false)
                {
                    Console.WriteLine("Nome: {0} Idade: {1} Gênero: {2}", pes[i].Nome, pes[i].Idade, pes[i].Genero);
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                    break;
                }
            }
        }
    }
}

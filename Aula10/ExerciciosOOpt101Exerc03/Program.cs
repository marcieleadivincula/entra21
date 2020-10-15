using System;

namespace ExerciciosOOpt101Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");
            //3) Crie 5 pessoas com nome,idade e genero. Peça para o usuario preencher as pessoas, em seguida, diga qual o homem mais velho e qual a mulher mais velha.

            //Instância da classe Pessoa com 5 posições 
            Person[] pessoa = new Person[5];
            int homemVelho = -1, mulherVelha = -1;

            //Percorre o vetor pessoa e preenche com os dados digitados pelo usuário
            for (int i = 0; i < pessoa.Length; i++)
            {
                Console.Write("Insira o nome: ");
                string nome = Console.In.ReadLine();
                Console.Write("Insira a idade: ");
                int idade = Convert.ToInt32(Console.In.ReadLine());
                Console.Write("Insira o gênero: ");
                char genero = Convert.ToChar(Console.In.ReadLine());

                pessoa[i] = new Person(nome, idade, genero);
            }

            Console.WriteLine();

            //Verifica qual pessoa é mais velha de cada gênero
            for (int i = 0; i < pessoa.Length; i++)
            {
                if (pessoa[i].SeuGenero() == false && pessoa[i].GetGenero() == 'm')
                {
                    homemVelho++;
                }

                if (pessoa[i].SeuGenero() == true && pessoa[i].GetGenero() == 'f')
                {
                    mulherVelha++;
                }
            }

            //Percorre o vetor pessoa já preenchido com os dados digitados pelo usuário e apresenta na tela
            Console.WriteLine("Pessoas mais velhas: ");
            for (int i = 0; i < pessoa.Length; i++)
            {
                if (homemVelho != -1 && pessoa[i].SeuGenero() == false && pessoa[i].MaisVelho() == true)
                {
                    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].GetNome(), pessoa[i].GetIdade(), pessoa[i].GetGenero());
                }

                if (mulherVelha != -1 && pessoa[i].SeuGenero() == true && pessoa[i].MaisVelho() == true)
                {
                    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].GetNome(), pessoa[i].GetIdade(), pessoa[i].GetGenero());
                }
            }

            //if (homemVelho != -1) e  if (mulherVelha != -1)
        }
    }
}

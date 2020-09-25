using System;

namespace ExerciciosOOpt101Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");
            //3) Crie 5 pessoas com nome,idade e genero. Peça para o usuario preencher as pessoas, em seguida, diga qual o homem mais velho e qual a mulher mais velha.
            Person[] pessoa = new Person[5];
            int homemVelho = 0, mulherVelha = 0;

            for (int i = 0; i < pessoa.Length; i++)
            {
                Console.Write("Insira o nome: ");
                string nome = Console.In.ReadLine();
                Console.Write("Insira a idade: ");
                int idade = Convert.ToInt32(Console.In.ReadLine());
                Console.Write("Insira o gênero: ");
                char genero = Convert.ToChar(Console.In.ReadLine());

                pessoa[i] = new Person(nome, idade, genero);
                Console.WriteLine();
            }

            for (int i = 0; i < pessoa.Length; i++)
            {
                if (pessoa[i].GetIdade() > homemVelho && pessoa[i].SeuGenero() == false)
                {
                    homemVelho = pessoa[i].GetIdade();
                }

                if (pessoa[i].GetIdade() > mulherVelha && pessoa[i].SeuGenero() == true)
                {
                    mulherVelha = pessoa[i].GetIdade();
                }
            }

            for (int i = 0; i < pessoa.Length; i++)
            {
                Console.WriteLine("Homem mais velho: ");
                if (homemVelho > pessoa[i].GetIdade())
                {
                    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].GetNome(), pessoa[i].GetIdade(), pessoa[i].GetGenero());
                }
                else
                {
                    break;
                }

                Console.WriteLine("Mulher mais velha: ");
                if (mulherVelha > pessoa[i].GetIdade())
                {
                    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].GetNome(), pessoa[i].GetIdade(), pessoa[i].GetGenero());
                }
                else
                {
                    break;
                }
            }


            //if (indiceMulher != -1)
            //{
            //    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].GetNome(), pessoa[i].GetIdade(), pessoa[i].GetGenero());
            //}

            //if (indiceHomem != -1)
            //{
            //    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].GetNome(), pessoa[i].GetIdade(), pessoa[i].GetGenero());
            //}

        }
    }
}

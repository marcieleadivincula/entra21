using System;

namespace OOpt03List01Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 301");
            //3) Crie uma Pessoa com nome,cpf e idade.Após isso mostre na tela e peça para o usuario se deseja alterar a Pessoa inserida.
            Pessoa[] pes = new Pessoa[1];
            string nome, cpf;
            int idade;

            for (int i = 0; i < pes.Length; i++)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());

                pes[i] = new Pessoa(nome, cpf, idade);
            }

            for (int i = 0; i < pes.Length; i++)
            {
                Console.WriteLine("Nome: {0} CPF: {1} Idade: {2}", pes[i].Nome, pes[i].Cpf, pes[i].Idade);
                Console.WriteLine();

                Console.WriteLine("Deseja alterar a pessoa inserida?");
                Console.Write("Sim ou não: ");
                string opcao = Console.ReadLine();
                if (opcao == "sim")
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    cpf = Console.ReadLine();
                    Console.Write("Idade: ");
                    idade = int.Parse(Console.ReadLine());

                    pes[i] = new Pessoa(nome, cpf, idade);

                    Console.WriteLine("Nome: {0} CPF: {1} Idade: {2}", pes[i].Nome, pes[i].Cpf, pes[i].Idade);
                }
                else
                {
                    break;
                }
            }
        }
    }
}

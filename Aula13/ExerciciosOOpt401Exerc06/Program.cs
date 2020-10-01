using System;

namespace ExerciciosOOpt401Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de OOpt - 401");
            //6) Crie uma subClasse chamado Pessoa com nome, idade, dopamina, dinheiro no bolso e herda Comportamente.Peça para o usuario preencher a Pessoa, em seguida, pergunte se deseja Comer ou Trabalhar e quanto. Após isso, mostre na tela a Pessoa

            Pessoa pes = new Pessoa();

            Console.Write("Nome: ");
            pes.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pes.Idade = int.Parse(Console.ReadLine());
            Console.Write("Dopamina: ");
            pes.Dopamina = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro: ");
            pes.Dinheiro = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double result;
            Console.WriteLine("Deseja comer, descansar ou trabalhar? E quanto?");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();
            Console.Write("Quanto: ");
            double quanto = int.Parse(Console.ReadLine());

            if (opcao.ToLower() == "comer")
            {
                //dop/kl
                result = pes.Comer(quanto);
                Console.WriteLine(result);
            }
            else if(opcao.ToLower() == "descansar")
            {
                //dinh/hora
                result = pes.Trabalhar((int)quanto);
                Console.WriteLine(result);
            }
            else if (opcao.ToLower() == "trabalhar")
            {
                //dinh/hora
                result = pes.Trabalhar((int)quanto);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine("Nome: {0} Idade: {1} Dopamina: {2} R$ {3} {4}", pes.Nome, pes.Idade, pes.Dopamina, pes.Dinheiro, pes.Trabalhar(), pes.Comer());
        }
    }
}

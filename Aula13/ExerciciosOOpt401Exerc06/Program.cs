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

            //Funcoes: Comer(double quantidade de kilos), Descansar(int horas) e Trabalhar(int horas)
            //Comer: para cada kilo de alimento, ganha 250 de dopamina
            //Descansar: para cada hora de descanso, ganha 100 de conforto
            //Trabalhar: para cada hora de trabalho, ganha R$ 24,52 de dinheiro no bolso

            if (opcao.ToLower() == "comer")
            {
                //dop/kl
                result = pes.Comer(quanto);
                Console.WriteLine();
                Console.WriteLine(quanto + " kilo(s) de alimento = {0} ", result + " de dopamina");
            }
            else if(opcao.ToLower() == "descansar")
            {
                //dinh/hora
                result = pes.Descansar((int)quanto);
                Console.WriteLine();
                Console.WriteLine(quanto + " hora(s) de descanso = {0} ", result + " de conforto");
            }
            else if (opcao.ToLower() == "trabalhar")
            {
                //dinh/hora
                result = pes.Trabalhar((int)quanto);
                Console.WriteLine();
                Console.WriteLine(quanto + " hora(s) de trabalho = R$ {0} ", result + " em dinheiro");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine("Nome: {0} \nIdade: {1} \nDopamina: {2} \nR$ {3}", pes.Nome, pes.Idade, pes.Dopamina, pes.Dinheiro);
        }
    }
}

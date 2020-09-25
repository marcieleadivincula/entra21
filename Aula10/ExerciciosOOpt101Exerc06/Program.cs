using System;

namespace ExerciciosOOpt101Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");

            //6 Crie 3 empregados com nome, salário e cpf. Peça para o usuario preencher todos os funcionários,se o salário do funcionário for menor que 1500 de um aumento de 20%, após tudo isso, mostre na tela os funcionarios na ordem de menor salário para maior.
            Empregado[] empreg = new Empregado[3];

            for (int i = 0; i < empreg.Length; i++)
            {
                Console.Write("Insira o nome do empregado: ");
                string nome = Console.In.ReadLine();
                Console.Write("Insira o salário do empregado: ");
                double salario = Convert.ToDouble(Console.In.ReadLine());
                Console.Write("Insira o CPF do empregado: ");
                string cpf = Console.In.ReadLine();

                empreg[i] = new Empregado(nome, salario, cpf);
                Console.WriteLine();
            }

            for (int i = 0; i < empreg.Length; i++)
            {
                if (empreg[i].getSalario() < 1500.0)
                {
                    empreg[i].Aumento();
                }
            }

            for (int i = 0; i < empreg.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (empreg[j - 1].getSalario() > empreg[j].getSalario()) //ordem crescente
                    {
                        Empregado temp = empreg[j - 1];
                        empreg[j - 1] = empreg[j];
                        empreg[j] = temp;
                    }
                }
            }

            for (int i = 0; i < empreg.Length; i++)
            {
                Console.WriteLine("Nome: {0}, Salário: {1:c} , CPF: {2}", empreg[i].getNome(), empreg[i].getSalario(), empreg[i].getCpf());
            }

        }
    }
}

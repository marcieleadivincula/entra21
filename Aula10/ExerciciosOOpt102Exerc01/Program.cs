using System;

namespace ExerciciosOOpt102Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 2");

            //1 Crie 4 clientes com nome,cpf e VIP. Peça para o usuario preencher os clientes, em seguida, mostre todos os clientes começando pelos VIP’s e com um selo(qualque símbolo serve).
            Cliente[] clientes = new Cliente[4];

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Insira o nome, CPF e VIP do {0}° cliente", (i + 1));

                Console.Write("Digite o nome do cliente: ");
                string nome = Console.In.ReadLine();
                Console.Write("Digite o CPF do cliente: ");
                string cpf = Console.In.ReadLine();
                Console.Write("Digite v para vip ou n para não: ");
                char vip = Convert.ToChar(Console.In.ReadLine());

                clientes[i] = new Cliente(nome, cpf, vip);
            }

            if (clientes[0].GetVip() == 'v')
            {
                clientes[0].GetNome() = clientes[0].GetNome() + "#_#";
            }

            for (int i = 0; i < clientes.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (clientes[j - 1].GetVip() < clientes[j].GetVip())
                    {
                        clientes[j].GetNome() = clientes[j].GetNome() + "#_#";
                        Cliente temp = new Cliente();
                        clientes[j] = clientes[j - 1];
                        clientes[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].GetVip() == 'v')
                {
                    Console.WriteLine("{0} {1}", clientes[i].GetNome() + "#_#", clientes[i].GetCpf());
                }
                else
                {
                    Console.WriteLine("{0} {1}", clientes[i].GetNome(), clientes[i].GetCpf());
                }
            }
        }
    }
}

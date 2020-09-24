using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 04 01 versão 2.0
            Cliente[] clientes = new Cliente[5];

            for (int i = 0; i < clientes.Length; i++)
            {
                clientes[i] = new Cliente();
            }

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Insira o nome, o CPF e as consultas do cliente");
                Console.Write("Nome: ");
                string nome = Console.In.ReadLine();
                Console.Write("CPF: ");
                string cpf = Console.In.ReadLine();
                Console.Write("Consultas: ");
                string[] consultas = new string[10];

                for (int j = 0; j < consultas.Length; i++)
                {
                    //Console.Clear();
                    Console.Write("Insira a {0}° consulta", (j + 1));
                    string inputConsulta = Console.In.ReadLine();

                    if (inputConsulta == "")
                    {
                        break;
                    }
                    else
                    {
                        consultas[j] = inputConsulta;
                    }
                }

                clientes[i].SetNome(nome);
                clientes[i].SetCpf(cpf);
                clientes[i].SetConsultas(consultas);

                Console.WriteLine("Este é o cliente que acabou de inserir:");
                Console.WriteLine("Nome: {0} CPF: {1}", clientes[i].GetNome(), clientes[i].GetCpf());
                string[] temp = clientes[i].GetConsultas();

                for (int k = 0; k < temp.Length; k++)
                {
                    Console.WriteLine("Esta foi a {0}° consulta", (k + 1));
                    Console.WriteLine(temp[k]);
                }

            }

        }
    }
}

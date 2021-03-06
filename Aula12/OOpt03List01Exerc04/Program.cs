﻿using System;

namespace OOpt03List01Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 301");
            // 4) Crie um Cliente para consultório dentário com nome,cpf e consultas[].Peça para o usuario preencher o cliente, após isso, mostre na tela as informações
            //obs: as consultas[] devem ser armazenar em string para poder registrar o que foi feito, pode-se ter até consultas[10] por cliente.

            // Exercício 04 01
            Cliente cliente = new Cliente();

            Console.WriteLine("Insira o nome, o CPF e as consultas do cliente");
            Console.Write("Nome: ");
            string nome = Console.In.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.In.ReadLine();
            Console.Write("Consultas: ");
            string[] consultas = new string[10];

            for (int i = 0; i < consultas.Length; i++)
            {
                //Console.Clear();
                Console.Write("Insira a {0}° consulta", (i + 1));
                string inputConsulta = Console.In.ReadLine();

                if (inputConsulta == "")
                {
                    break;
                }
                else
                {
                    consultas[i] = inputConsulta;
                }
            }

            cliente.SetNome(nome);
            cliente.SetCpf(cpf);
            cliente.SetConsultas(consultas);

            Console.WriteLine("Este é o cliente que acabou de inserir:");
            Console.WriteLine("Nome: {0} CPF: {1}", cliente.GetNome(), cliente.GetCpf());
            string[] temp = cliente.GetConsultas();

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine("Esta foi a {0}° consulta", (i + 1));
                Console.WriteLine(temp[i]);
            }
        }
    }
}

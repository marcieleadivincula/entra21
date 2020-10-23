using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.InteropServices;

namespace ExercíciosDeOOpt0501Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExercíciosDeOOpt0501Exerc01");
            //1) Crie uma ClassePai Chamado Endereco com rua, cep, cidade e estado. Crie uma ClassePai Chamado Dados com nome, idade, cpf, cnpj e rg.

            //a) Crie uma subClasse Chamado Empresa com saldo, quantidade de funcionarios, herda Endereco e herda Dados. Crie e preencha uma empresa, mostre na tela se a quantidade de funcionarios for maior que 8, caso nao, mostre “Micro empresa”.

            //b) Crie uma subClasse Chamado Carro com modelo, cavalos vapor, herda Endereco e herda Dados. Crie e preencha 3 carros, após isso, mostre na tela em ordem do carro com maior cavalos vapor e maior que 500.
            List<Empresa> empresas = new List<Empresa>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Empresa: ");
                Console.Write("Saldo: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.Write("Quantidade de funcionários: ");
                int qtdFuncionarios = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Dados da empresa: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("CNPJ: ");
                string cnpj = Console.ReadLine();
                Console.Write("RG: ");
                string rg = Console.ReadLine();

                Console.WriteLine("Endereço da empresa: ");
                Console.Write("Rua: ");
                string rua = Console.ReadLine();
                Console.Write("Número: ");
                string numero = Console.ReadLine();
                Console.Write("CEP: ");
                string cep = Console.ReadLine();
                Console.Write("Bairro: ");
                string bairro = Console.ReadLine();
                Console.Write("Cidade: ");
                string cidade = Console.ReadLine();
                Console.Write("Estado: ");
                string estado = Console.ReadLine();

                Empresa temp = new Empresa(saldo, qtdFuncionarios, nome, idade, cpf, cnpj, rg, rua, numero, cep, bairro, cidade, estado);
                empresas.Add(temp);
            }
            Console.WriteLine();

            foreach (var emp in empresas)
            {
                if (emp.QtdFuncionarios > 8)
                {
                    Console.WriteLine(emp);
                }
                else
                {
                    Console.WriteLine("Micro empresa");
                }
            }

            //List<Carro> carros = new List<Carro>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Dados do carro: ");
            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Idade: ");
            //    int idade = int.Parse(Console.ReadLine());
            //    Console.Write("CPF: ");
            //    string cpf = Console.ReadLine();
            //    Console.Write("CNPJ: ");
            //    string cnpj = Console.ReadLine();
            //    Console.Write("RG: ");
            //    string rg = Console.ReadLine();

            //    Console.WriteLine("Endereço do carro: ");
            //    Console.Write("Rua: ");
            //    string rua = Console.ReadLine();
            //    Console.Write("Número: ");
            //    string numero = Console.ReadLine();
            //    Console.Write("CEP: ");
            //    string cep = Console.ReadLine();
            //    Console.Write("Bairro: ");
            //    string bairro = Console.ReadLine();
            //    Console.Write("Cidade: ");
            //    string cidade = Console.ReadLine();
            //    Console.Write("Estado: ");
            //    string estado = Console.ReadLine();

            //    Console.WriteLine("Carro: ");
            //    Console.Write("Modelo: ");
            //    string modelo = Console.ReadLine();
            //    Console.Write("Cavalos Vapor: ");
            //    string cavalosVapor = Console.ReadLine();

            //    Carro temp = new Carro(modelo, cavalosVapor, nome, idade, cpf, cnpj, rg, rua, numero, cep, bairro,cidade, estado);
            //    carros.Add(temp);
            //}

        }
    }
}

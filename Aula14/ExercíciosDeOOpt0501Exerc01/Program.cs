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

            //List<Empresa> empresas = new List<Empresa>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Empresa: ");
            //    Console.Write("Saldo: ");
            //    double saldo = double.Parse(Console.ReadLine());
            //    Console.Write("Quantidade de funcionários: ");
            //    int qtdFuncionarios = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Dados da empresa: ");
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

            //    Console.WriteLine("Endereço da empresa: ");
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

            //    Empresa temp = new Empresa(saldo, qtdFuncionarios, nome, idade, cpf, cnpj, rg, rua, numero, cep, bairro, cidade, estado);
            //    empresas.Add(temp);
            //}
            //Console.WriteLine();

            //foreach (var emp in empresas)
            //{
            // mostre na tela se a quantidade de funcionarios for maior que 8, caso nao, mostre “Micro empresa”
            //    if (emp.QtdFuncionarios > 8)
            //    {
            //        Console.WriteLine("Dados da empresa: ");
            //        Console.WriteLine("===========================================================================");
            //        Console.Write("Saldo: ");
            //        Console.WriteLine(emp.Saldo);
            //        Console.Write("Quantidade de funcionários: ");
            //        Console.WriteLine(emp.QtdFuncionarios);
            //        Console.WriteLine("===========================================================================");
            //        Console.Write("Nome: ");
            //        Console.WriteLine(emp.Nome);
            //        Console.Write("Idade: ");
            //        Console.WriteLine(emp.Idade);
            //        Console.Write("CPF: ");
            //        Console.WriteLine(emp.Cpf);
            //        Console.Write("CNPJ: ");
            //        Console.WriteLine(emp.Cnpj);
            //        Console.Write("RG: ");
            //        Console.WriteLine(emp.Rg);
            //        Console.WriteLine("===========================================================================");
            //        Console.Write("Rua: ");
            //        Console.WriteLine(emp.Rua);
            //        Console.Write("Número: ");
            //        Console.WriteLine(emp.Numero);
            //        Console.Write("CEP: ");
            //        Console.WriteLine(emp.Cep);
            //        Console.Write("Bairro: ");
            //        Console.WriteLine(emp.Bairro);
            //        Console.Write("Cidade: ");
            //        Console.WriteLine(emp.Cidade);
            //        Console.Write("Estado: ");
            //        Console.WriteLine(emp.Estado);
            //        Console.WriteLine("===========================================================================");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Microempresa");
            //    }
            //}


            List <Carro> carros = new List<Carro>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dados do carro: ");
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

                Console.WriteLine("Endereço do carro: ");
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

                Console.WriteLine("Carro: ");
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Cavalos Vapor: ");
                int cavalosVapor = int.Parse(Console.ReadLine());

                Carro temp = new Carro(modelo, cavalosVapor, nome, idade, cpf, cnpj, rg, rua, numero, cep, bairro, cidade, estado);
                carros.Add(temp);
            }

            foreach (var car in carros)
            {
                //mostre na tela em ordem do carro com maior cavalos vapor e maior que 500.
                if (car.CavalosVapor >= 500)
                {
                    Console.WriteLine("Dados do carro: ");
                    Console.WriteLine("===========================================================================");
                    Console.Write("Nome: ");
                    Console.WriteLine(car.Nome);
                    Console.Write("Idade: ");
                    Console.WriteLine(car.Idade);
                    Console.Write("CPF: ");
                    Console.WriteLine(car.Cpf);
                    Console.Write("CNPJ: ");
                    Console.WriteLine(car.Cnpj);
                    Console.Write("RG: ");
                    Console.WriteLine(car.Rg);
                    Console.WriteLine("===========================================================================");
                    Console.WriteLine("Endereço do dono: ");
                    Console.Write("Rua: ");
                    Console.WriteLine(car.Rua);
                    Console.Write("Número: ");
                    Console.WriteLine(car.Numero);
                    Console.Write("CEP: ");
                    Console.WriteLine(car.Cep);
                    Console.Write("Bairro: ");
                    Console.WriteLine(car.Bairro);
                    Console.Write("Cidade: ");
                    Console.WriteLine(car.Cidade);
                    Console.Write("Estado: ");
                    Console.WriteLine(car.Estado);
                    Console.WriteLine("===========================================================================");
                    Console.WriteLine("Modelo e Potência do carro: ");
                    Console.Write("Modelo: ");
                    Console.WriteLine(car.Modelo);
                    Console.Write("Cavalos Vapor: ");
                    Console.WriteLine(car.CavalosVapor);
                }
                else
                {
                    Console.WriteLine("Não nenhum carro com mais de 500 cavalos de vapor!");
                }
            }
        }
    }
}

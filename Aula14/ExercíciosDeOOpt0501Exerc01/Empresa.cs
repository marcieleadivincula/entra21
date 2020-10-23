using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc01
{
    class Empresa : Dados
    {
        // herda Endereco e herda Dados
        public double Saldo { get; set; }
        public int QtdFuncionarios { get; set; }

        public Empresa(double saldo, int qtdFuncionarios, string nome, int idade, string cpf, string cnpj, string rg, string rua, string numero, string cep, string bairro, string cidade, string estado) : base(nome, idade, cpf, cnpj, rg, rua, numero, cep, bairro, cidade, estado)
        {
            Saldo = saldo;
            QtdFuncionarios = qtdFuncionarios;
        }
    }
}

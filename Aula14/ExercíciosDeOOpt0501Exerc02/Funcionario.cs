using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc02
{
    class Funcionario : Pessoa
    {
        //herda Endereco e herda Pessoa
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string cargo, double salario, string nome, int idade, string cpf, string rua, string numero, string cep, string bairro, string cidade, string estado) : base(nome, idade, cpf, rua, numero, cep, bairro, cidade, estado)
        {
            Cargo = cargo;
            Salario = salario;
        }
    }
}

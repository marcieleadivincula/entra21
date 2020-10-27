using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc02
{
    class Funcionario
    {
        //herda Endereco e herda Pessoa
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string cargo, double salario)
        {
            Cargo = cargo;
            Salario = salario;
        }
    }
}

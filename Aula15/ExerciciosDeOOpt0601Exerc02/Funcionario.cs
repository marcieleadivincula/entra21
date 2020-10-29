using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc02
{
    class Funcionario
    {
        //2) Implemente a classe Funcionario e a classe Gerente, ambos possuem, nome, salario e ExibeDados().
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public Funcionario()
        {

        }
        //public virtual void ExibeDados()
        //{

        //}
    }
}

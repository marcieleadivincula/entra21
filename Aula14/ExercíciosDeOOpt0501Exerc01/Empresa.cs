using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc01
{
    class Empresa : Endereco
    {
        public double Saldo { get; set; }
        public int QtdFuncionarios { get; set; }

        public Empresa(double saldo, int qtdFuncionarios)
        {
            Saldo = saldo;
            QtdFuncionarios = qtdFuncionarios;
        }
    }
}

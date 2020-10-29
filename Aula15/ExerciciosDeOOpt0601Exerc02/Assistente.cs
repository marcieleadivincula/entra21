using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc02
{
    class Assistente : Funcionario
    {
        //a) crie a classe Assistente, que também é um funcionário, e que possui um número de matrícula. Sobrescreva o método ExibeDados().
        public int NumeroMatricula { get; set; }

        public Assistente(int numeroMatricula)
        {
            NumeroMatricula = numeroMatricula;
        }

        //public override void ExibeDados()
        //{

        //}
    }
}

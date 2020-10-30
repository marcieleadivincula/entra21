using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt401Exerc08
{
    class Funcionario: Comportamento
    {
        public string Nome { get; set; }
        public double DinheiroBolso { get; set; }

        public Funcionario(string nome, double dinheiroBolso)
        {
            Nome = nome;
            DinheiroBolso = dinheiroBolso;
        }
    }
}

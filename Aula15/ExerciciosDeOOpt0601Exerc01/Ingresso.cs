using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc01
{
    class Ingresso
    {
        public double ValorEmReais { get; set; }
        public Ingresso(double valorEmReais) => (ValorEmReais) = (valorEmReais);

        public virtual double ImprimeValor()
        {
            return ValorEmReais;
        }
    }
}

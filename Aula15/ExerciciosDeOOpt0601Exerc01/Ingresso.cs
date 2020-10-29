using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc01
{
    class Ingresso
    {
        //1) Crie uma classe chamada Ingresso que possui um valor em reais e um método ImprimeValor().
        public double ValorEmReais { get; set; }

        //public Ingresso(double valorEmReais) => (ValorEmReais) = (valorEmReais);
        public Ingresso(double valorEmReais)
        {
            ValorEmReais = valorEmReais;
        }

        public Ingresso()
        {

        }

        public virtual double ImprimeValor()
        {
            return ValorEmReais;
        }
    }
}

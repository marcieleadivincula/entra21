using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc01
{
    class Normal : Ingresso
    {
        //b) crie uma classe Normal, que herda Ingresso e possui um método que imprime: "Ingresso Normal"
        public double ValorAdicional { get; set; }
        public override double ImprimeValor()
        {
            double adicional = ValorEmReais + ValorAdicional;
            return adicional;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc01
{
    class Vip : Ingresso
    {
        public double ValorAdicional { get; set; }

        //Sobreencre - va um método que retorne o valor do ingresso VIP(com o adicional incluído).
        public override double ImprimeValor()
        {
            double adicional = ValorEmReais + ValorAdicional;
            return adicional;
        }
    }
}

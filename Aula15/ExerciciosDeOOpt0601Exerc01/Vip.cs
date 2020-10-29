using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc01
{
    class Vip : Ingresso
    {
        //a) crie uma classe VIP, que herda Ingresso e possui um valor adicional.Sobreencreva um método que retorne o valor do ingresso VIP(com o adicional incluído).
        public double ValorAdicional { get; set; }

        //Sobreencre - va um método que retorne o valor do ingresso VIP(com o adicional incluído).
        public override double ImprimeValor()
        {
            double adicional = ValorEmReais + ValorAdicional;
            return adicional;
        }
    }
}

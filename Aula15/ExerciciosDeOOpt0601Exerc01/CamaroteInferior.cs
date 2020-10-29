using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc01
{
    class CamaroteInferior: Vip
    {
        //c) crie uma classe CamaroteInferior(que possui a localização do ingresso e possui valor adicional) e uma classe CamaroteSuperior(que possui a localização do ingresso e possui valor adicional equivalente a 3x o Camaroteinferior). ambas Sobreescrevem o método para retornar o valor do ingresso.Ambas as classes herdam a classe VIP.
        public int LocalizacaoIngresso { get; set; }
        public override double ImprimeValor()
        {
            return ValorAdicional * 3;
        }
    }
}

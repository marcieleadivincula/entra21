using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc03
{
    class Velho: Imovel
    {
        //b) crie uma classe Velho, com desconto e herda Imovel . Sobreescreva o método CalculaValor() para computar o valor com desconto
        public double Desconto { get; set; }
        public override double CalculaValor()
        {
            double valor = Preco + Desconto;
            return valor;
        }
    }
}

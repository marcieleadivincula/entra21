using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc03
{
    class Novo : Imovel
    {
        //a) crie uma classe Novo com precoAdiconal e herda Imovel.Sobreescreva o método CalculaValor() para computar o valor adicional

        public double PrecoAdiconal { get; set; }
        public override double CalculaValor()
        {
            double valor = Preco + PrecoAdiconal;
            return valor;
        }
    }
}

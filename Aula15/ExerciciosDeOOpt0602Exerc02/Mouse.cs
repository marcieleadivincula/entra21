using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0602Exerc02
{
    class Mouse: Produto
    {
        //a) Crie uma SubClasse chamado Mouse com dpi, modelo e herda Produto, além dis - so, ele sobreescreve o método CalculaPreco()(o preco é calculado da seguinte forma, preco = (preco * 2.3) + dpi)
        public double DPI { get; set; }
        public override double CalculaPreco()
        {
            Preco *= 2.3;
            //Preco = ((Preco * 2.3) + DPI);
            return Preco + DPI;
        }

        public Mouse(double dpi, string nome, double preco, string tipo) : base(nome, preco, tipo)
        {
            DPI = dpi;
        }
    }
}

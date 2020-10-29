using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0602Exerc02
{
    class Livro : Produto
    {
        //b) Crie uma SubClasse chamado Livro com autor, estilo e herda Produto, além disso, ele sobreescreve o método CalculaPreco()(o preco é calculado da seguinte forma, preco = preco * 1.55)

        public string Autor { get; set; }
        public string Estilo { get; set; }

        public override double CalculaPreco()
        {
            return Preco *= 1.55;
        }

        public Livro(string autor, string estilo, string nome, double preco, string tipo): base(nome, preco, tipo)
        {
            Autor = autor;
            Estilo = estilo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0602Exerc02
{
    class Produto
    {
        //2) Crie uma Classe Pai chamado Produto com nome, preco, tipo e CalculaPreco().
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        public virtual double CalculaPreco()
        {
            return Preco;
        }

        public Produto(string nome, double preco, string tipo)
        {
            Nome = nome;
            Preco = preco;
            Tipo = tipo;
        }
    }
}

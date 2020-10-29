using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc03
{
    class Imovel
    {
        //3) Crie a classe Imovel, que possui endereço, preço e CalculaValor()
        public string Endereco { get; set; }
        public double Preco { get; set; }

        public virtual double CalculaValor()
        {
            return Preco;
        }
    }
}

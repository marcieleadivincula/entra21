using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc03
{
    class Cliente
    {
        //c) crie um Cliente que possui nome e dinheiroDisponivel, em seguida, mostre 2 Imoveis Novos e 2 Velhos, então, pergunte qual o Cliente deseja comprar, caso nao possua dinheiro para aquela compra, sugira parcelar em 12x com 16,74 % de acrés - cimo ou escolher outro imóvel, caso possua agradeça pela preferência, se em algum momento o cliente fechou negócio, desconte aquele valor do dinheiroDisponivel(ca - so for parcelado, desconte apenas o valor de uma parcela)

        public string Nome { get; set; }
        public double DinheiroDisponivel { get; set; }

        public Cliente(string nome, double dinheiroDisponivel)
        {
            Nome = nome;
            DinheiroDisponivel = dinheiroDisponivel;
        }
    }
}

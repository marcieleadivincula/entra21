using System;

namespace ExerciciosDeOOpt0601Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeOOpt0601Exerc03");
            //3) Crie a classe Imovel, que possui endereço, preço e CalculaValor()

            //a) crie uma classe Novo com precoAdiconal e herda Imovel.Sobreescreva o método CalculaValor() para computar o valor adicional

            //b) crie uma classe Velho, com desconto e herda Imovel . Sobreescreva o método CalculaValor() para computar o valor com desconto

            //c) crie um Cliente que possui nome e dinheiroDisponivel, em seguida, mostre 2 Imoveis Novos e 2 Velhos, então, pergunte qual o Cliente deseja comprar, caso nao possua dinheiro para aquela compra, sugira parcelar em 12x com 16,74 % de acrés - cimo ou escolher outro imóvel, caso possua agradeça pela preferência, se em algum momento o cliente fechou negócio, desconte aquele valor do dinheiroDisponivel(ca - so for parcelado, desconte apenas o valor de uma parcela)

            //OBS: para parcelar, primeiro incremente o valor do imovel baseado no acréscimo e em seguida, divada em 12 e terás o valor de cada parcela com acréscimo de 16,74 %

        }
    }
}

using System;

namespace ExerciciosDeOOpt0602Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //2) Crie uma Classe Pai chamado Produto com nome, preco, tipo e CalculaPreco().

            //a) Crie uma SubClasse chamado Mouse com dpi, modelo e herda Produto, além dis - so, ele sobreescreve o método CalculaPreco()(o preco é calculado da seguinte forma, preco = (preco * 2.3) + dpi)

            //b) Crie uma SubClasse chamado Livro com autor, estilo e herda Produto, além disso, ele sobreescreve o método CalculaPreco()(o preco é calculado da seguinte forma, preco = preco * 1.55)

            //c) Crie 3 mouses e livros diferentes, então mostre todos para o usuario, e pergunte quais ele deseja adicionar em seu carrinho, após isso, mostre quanto o carrinho esta custando
            
            //Mouse mouse = new Mouse();
            //Livro livro = new Livro();

            //Console.WriteLine(mouse.Nome, mouse.Preco, mouse.Tipo, mouse.DPI);
        }
    }
}

using System;

namespace ExerciciosStruct01Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de Struct - 1");

            //6) Crie 4 produtos com nome,preço e quantidade no estoque. Peça para o usuario preencher todos os produtos, em seguida, mostre na tela os produtos começando pelos que tem maior quantidade no estoque
            //List<Produto> produtos = new List<Produto>();
            Produto[] produto = new Produto[4];
            int maiorQtd = 0;
            //int qtdEstoque;
            //string nome;
            //double preco;

            for (int i = 0; i < produto.Length; i++)
            {
                Console.Write("Digite o nome do produto: ");
                produto[i].nome = Console.In.ReadLine();
                Console.Write("Digite o preço do produto: ");
                produto[i].preco = Convert.ToDouble(Console.In.ReadLine());
                Console.Write("Digite o quantidade do produto: ");
                produto[i].qtdEstoque = Convert.ToInt32(Console.In.ReadLine());

                if (produto[i].qtdEstoque > maiorQtd)
                {
                    maiorQtd = produto[i].qtdEstoque;
                }

                //Console.WriteLine("Nome do produto:" + produto[i].nome);
                //Console.WriteLine("Preço do produto:" + produto[i].preco);
                //Console.WriteLine("Quantidade em estoque:" + produto[i].qtdEstoque);

                //produtos.Add(new Produto { nome = produto[i].nome, preco = produto[i].preco, qtdEstoque = produto[i].qtdEstoque });
            }
            Console.WriteLine();
            //foreach (Produto produtoo in produtos)
            //{
            //    Console.WriteLine(produtoo);
            //    Console.WriteLine();
            //}

            Console.WriteLine("Lista de Produtos:");
            for (int i = 0; i < produto.Length; i++)
            {
                Console.WriteLine("Nome:" + produto[i].nome);
                Console.WriteLine("Preço:" + produto[i].preco);
                Console.WriteLine("Quantidade em estoque:" + produto[i].qtdEstoque);
                Console.WriteLine();
            }

            Console.WriteLine("Maior quantidade: " + maiorQtd);
        }

        public struct Produto
        {
            public string nome;
            public double preco;
            public int qtdEstoque;

            public override string ToString()
            {
                return "Nome: " + nome + "\nPreço: " + preco + "\nQuantidade em estoque: " + qtdEstoque;
            }
        }
    }
}

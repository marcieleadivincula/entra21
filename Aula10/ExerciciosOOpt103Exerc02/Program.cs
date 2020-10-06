using System;
using System.Collections;

namespace ExerciciosOOpt103Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 3");

            //2) Crie 5 produtos para um mercado com nome do produto, id e preço. Peça para o usuário preencher todos os produtos(nao pode ter produtos com o mesmo id), em seguida, crie um carrinho de compras virtual que PODE ter até 20 produtos , ao finalizar a compra deve-se dizer ao usuario o nome de todos os produtos comprados e some o valor final.

            Produto[] pro = new Produto[2];
            ArrayList listaProdutos = new ArrayList();

            for (int i = 0; i < pro.Length; i++)
            {
                Console.WriteLine("Insira a {0}° produto", (i + 1));

                Console.Write("Nome do produto: ");
                string nome = Console.In.ReadLine();
                Console.Write("Id do produto: ");
                int id = int.Parse(Console.In.ReadLine());
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.In.ReadLine());

                pro[i] = new Produto(nome, id, preco);

                listaProdutos = new ArrayList();

                listaProdutos.Add(pro[i]);
            }

            foreach (Produto produto in listaProdutos)
            {
                Console.WriteLine("Count: ", listaProdutos.Count);
                Console.WriteLine("Contains: ", listaProdutos.Contains(produto));
            }

            for (int i = 0; i < pro.Length; i++)
            {
                Console.WriteLine("Nome do produto: {0} Id: {1} Preço: {2}", pro[i].GetNomeProduto(), pro[i].GetIdProduto(), pro[i].GetPrecoProduto());
            }
        }
    }
}

using System;

namespace ExerciciosOOpt101Exerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");

            //5 Crie 5 produtos com nome,preço e quantidade no estoque. Peça para o usuario preencher todos os produtos, em seguida, mostre na tela os produtos começando pelos que tem maior quantidade no estoque
            Produto[] prod = new Produto[5];

            for (int i = 0; i < prod.Length; i++)
            {
                Console.Write("Insira o nome do produto: ");
                string nome = Console.In.ReadLine();
                Console.Write("Insira o preço do produto: ");
                double preco = Convert.ToDouble(Console.In.ReadLine());
                Console.Write("Insira a quantidade em estoque do produto: ");
                int quantidade = Convert.ToInt32(Console.In.ReadLine());

                prod[i] = new Produto(nome, preco, quantidade);
                Console.WriteLine();
            }

            for (int i = 0; i < prod.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (prod[j - 1].GetQuantidade() < prod[j].GetQuantidade()) //ordem descrescente
                    {
                        Produto temp = prod[j - 1];
                        prod[j - 1] = prod[j];
                        prod[j] = temp;
                    }
                }
            }

            for (int i = 0; i < prod.Length; i++)
            {
                Console.WriteLine("Nome do produto: {0}, Preço do produto: {1}, Quantida em estoque: {2}", prod[i].GetNome(), prod[i].GetPreco(), prod[i].GetQuantidade());
            }
        }
    }
}

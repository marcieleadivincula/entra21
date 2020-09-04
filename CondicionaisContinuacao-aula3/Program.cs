using System;

namespace CondicionaisContinuacao_aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            //queijo = 4.50; macarrao = 5.0; feijao = 4.0; presunto = 5.50
            //> 5 produtos = 5% de desconto no valor final
            //>= 3 queijos = 10% de desconto cada um
            //>= 3 macarrão = 10% de desconto cada um
            //compra máximo 8 produtos

            double valor = 0, total, desconto;
            string produto = " ";

            for (int qtdCarrinho = 0; qtdCarrinho > 5; qtdCarrinho++)
            {
                Console.Write("Digite o código do produto: ");
                int produtoID = Convert.ToInt32(Console.In.ReadLine());

                switch (produtoID)
                {
                    case 1:
                        produto = "queijo";
                        valor = 4.5;
                        break;
                    case 2:
                        produto = "macarrão";
                        valor = 5.0;
                        break;
                    case 3:
                        produto = "feijão";
                        valor = 4.0;
                        break;
                    case 4:
                        produto = "presunto";
                        valor = 5.5;
                        break;
                    default:
                        break;
                }

                if (qtdCarrinho >= 3 && (produto == "queijo" || produto == "macarrão"))
                {
                    desconto = valor * 0.10;
                    total = valor - desconto;
                    Console.WriteLine("Valor com desconto: " + total);
                }
            }
        }
    }
}

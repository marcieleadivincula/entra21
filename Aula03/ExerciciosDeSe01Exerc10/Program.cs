using System;

namespace ExerciciosDeSe01Exerc10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc10");
            //10) Imagine que uma loja possui cartão fidelidade, além disso, tem descontos variadores para diferentes valores de compra, além disso, ela aplica um desconto extra para cada cinco compras, peça ao caixa dessa loja, o valor da compra, se tem cartão fidelidade e se esta é a quinta compra, então aplique os descontos na seguinte ordem: valor, cartão fidelidade e quinta compra
            //A quantidade dos descontos é de : para compras entre 0,01 e 200,00 é de 0 %, entre 200,01 e 400,00 é de 10 % e para compras acima de 400,00 é de 20 %, O cartão fidelidade adiciona um desconto de 15 % e se for a quinta compra mais 10 % desconto.

            //Ordem: valor, cartaoFidelidade e quintaCompra
            //cartaoFidelidade = 15% de desconto
            //quintaCompra = 10% de desconto

            Console.WriteLine("Digite o valor da compra: ");
            double valorCompra = Convert.ToDouble(Console.In.ReadLine());
            Console.WriteLine("Tem cartão fidelidade, digite sim ou não: ");
            string cartaoFidelidade = Console.In.ReadLine().ToLower();
            Console.WriteLine("É a primeira compra, digite sim ou não: ");
            string quintaCompra = Console.In.ReadLine().ToLower();
            double desconto, cartao, fidelidade;

            if (valorCompra >= 0.01 && valorCompra <= 200.0)
            {
                desconto = valorCompra;
                Console.WriteLine("Valor original: " + valorCompra);
                Console.WriteLine("Valor da compra com desconto: " + desconto);
                if (cartaoFidelidade == "sim")
                {
                    fidelidade = valorCompra * 0.15;
                    valorCompra -= fidelidade;
                    Console.WriteLine("Cartão fidelidade: " + valorCompra);
                    if (quintaCompra == "sim")
                    {
                        cartao = valorCompra * 0.10;
                        valorCompra -= cartao;
                        Console.WriteLine("Quinta compra: " + valorCompra);
                    }
                    else
                    {
                        Console.WriteLine("Não é a quinta compra!");
                        Console.WriteLine(valorCompra);
                    }
                }
                else
                {
                    Console.WriteLine("Não tem cartão fidelidade!");
                    Console.WriteLine(valorCompra);
                }
            }
            else if (valorCompra >= 200.01 && valorCompra <= 400.0)
            {
                desconto = valorCompra * 0.10;
                valorCompra -= desconto;
                Console.WriteLine("Valor da compra com desconto: " + valorCompra);
                if (cartaoFidelidade == "sim")
                {
                    fidelidade = valorCompra * 0.15;
                    valorCompra -= fidelidade;
                    Console.WriteLine("Cartão fidelidade: " + valorCompra);
                    if (quintaCompra == "sim")
                    {
                        cartao = valorCompra * 0.10;
                        valorCompra -= cartao;
                        Console.WriteLine("Quinta compra: " + valorCompra);
                    }
                    else
                    {
                        Console.WriteLine("Não é a quinta compra!");
                        Console.WriteLine(valorCompra);
                    }
                }
                else
                {
                    Console.WriteLine("Não tem cartão fidelidade!");
                    Console.WriteLine(valorCompra);
                }
            }
            else if (valorCompra >= 400.01)
            {
                desconto = valorCompra * 0.20;
                valorCompra -= desconto;
                Console.WriteLine("Valor da compra com desconto: " + valorCompra);
                if (cartaoFidelidade == "sim")
                {
                    fidelidade = valorCompra * 0.15;
                    valorCompra -= fidelidade;
                    Console.WriteLine("Cartão fidelidade: " + valorCompra);
                    if (quintaCompra == "sim")
                    {
                        cartao = valorCompra * 0.10;
                        valorCompra -= cartao;
                        Console.WriteLine("Quinta compra: " + valorCompra);
                    }
                    else
                    {
                        Console.WriteLine("Não é a quinta compra!");
                        Console.WriteLine(valorCompra);
                    }
                }
                else
                {
                    Console.WriteLine("Não tem cartão fidelidade!");
                    Console.WriteLine(valorCompra);
                }
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }

        }
    }
}

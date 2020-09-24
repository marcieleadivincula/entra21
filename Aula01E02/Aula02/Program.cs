using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            //int valor = Convert.ToInt32(Console.In.ReadLine());
            //if (valor >= 10)
            //{
            //    Console.WriteLine(valor);
            //}
            //else
            //{
            //    Console.WriteLine("Não é maior que 10");
            //}

            //Exercício 2
            //int valor1 = Convert.ToInt32(Console.In.ReadLine());
            //int valor2 = Convert.ToInt32(Console.In.ReadLine());
            //if (valor1 == valor2)
            //{
            //    Console.WriteLine("São iguais!");
            //}
            //else
            //{
            //    Console.WriteLine("Não são iguais!");
            //}

            //Exercício 3
            //int a = Convert.ToInt32(Console.In.ReadLine());
            //int b = Convert.ToInt32(Console.In.ReadLine());

            //if (a > b)
            //{
            //    Console.WriteLine(a);
            //}
            //else if (b > a)
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine("São iguais!");
            //}

            //Exercício 4
            //int a = Convert.ToInt32(Console.In.ReadLine());
            //int b = Convert.ToInt32(Console.In.ReadLine());
            //int c = Convert.ToInt32(Console.In.ReadLine());

            //if (a > b && a > c)
            //{
            //    Console.WriteLine(a);
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine(b);
            //}
            //else if (c > a && c > b)
            //{
            //    Console.WriteLine(c);
            //}
            //else
            //{
            //    Console.WriteLine("São iguais!");
            //}

            //Exercício 5
            //int valor = Convert.ToInt32(Console.In.ReadLine());
            //switch (valor)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2");
            //        break;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;
            //    default:
            //        Console.WriteLine("Não computável!");
            //        break;
            //}

            //Exercício 6
            //Random dado = new Random();
            //int valor = dado.Next(1, 7);

            //if (valor >= 3)
            //{
            //    Console.WriteLine(valor);
            //    Console.WriteLine("Você venceu!");
            //}
            //else
            //{
            //    Console.WriteLine("Você perdeu!");
            //}

            //Exercício 7
            //2*k + 1; ou usamos %
            //int num = Convert.ToInt32(Console.In.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Número é par!");
            //}
            //else
            //{
            //    Console.WriteLine("Número é ímpar!");
            //}

            //Exercício 8
            //double valorProduto = Convert.ToDouble(Console.In.ReadLine());
            //double desconto;

            //if (valorProduto >= 254.50)
            //{
            //    //desconto de 28%
            //    desconto = valorProduto * .72; //o C# entende que é um valor com ponto flutuante
            //}
            //else
            //{
            //    //desconto de 21%
            //    desconto = valorProduto * .79;
            //}

            //Console.WriteLine("Valor original: " + valorProduto);
            //Console.WriteLine("Valor com desconto: " + desconto);

            //Exercício 9
            //double salario = Convert.ToDouble(Console.In.ReadLine());

            //if (salario >= 3550.01)
            //{
            //    salario *= 1.10;
            //}
            //else if (salario >= 2400.01)
            //{
            //    salario *= 1.15;
            //}
            //else if (salario >= 1100.01)
            //{
            //    salario *= 1.20;
            //}
            //else if (salario >= 600.01)
            //{
            //    salario *= 1.25;
            //}
            //else
            //{
            //    salario *= 1.30;
            //}

            //Console.WriteLine("Salário com aumento: " + salario);

            //Exercício 10
            //Ordem: valor, cartaoFidelidade e quintaCompra
            //cartaoFidelidade = 15% de desconto
            //quintaCompra = 10% de desconto
            //Console.WriteLine("Digite o valor da compra: ");
            //double valorCompra = Convert.ToDouble(Console.In.ReadLine());
            //Console.WriteLine("Tem cartão fidelidade, digite sim ou não: ");
            //string cartaoFidelidade = Console.In.ReadLine().ToLower();
            //Console.WriteLine("É a primeira compra, digite sim ou não: ");
            //string quintaCompra = Console.In.ReadLine().ToLower();
            //double desconto, cartao, fidelidade;

            //if (valorCompra >= 0.01 && valorCompra <= 200.0)
            //{
            //    desconto = valorCompra;
            //    Console.WriteLine("Valor original: " + valorCompra);
            //    Console.WriteLine("Valor da compra com desconto: " + desconto);
            //    if (cartaoFidelidade == "sim")
            //    {
            //        fidelidade = valorCompra * 0.15;
            //        valorCompra -= fidelidade;
            //        Console.WriteLine("Cartão fidelidade: " + valorCompra);
            //        if (quintaCompra == "sim")
            //        {
            //            cartao = valorCompra * 0.10;
            //            valorCompra -= cartao;
            //            Console.WriteLine("Quinta compra: " + valorCompra);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Não é a quinta compra!");
            //            Console.WriteLine(valorCompra);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Não tem cartão fidelidade!");
            //        Console.WriteLine(valorCompra);
            //    }
            //}
            //else if (valorCompra >= 200.01 && valorCompra <= 400.0)
            //{
            //    desconto = valorCompra * 0.10;
            //    valorCompra -= desconto;
            //    Console.WriteLine("Valor da compra com desconto: " + valorCompra);
            //    if (cartaoFidelidade == "sim")
            //    {
            //        fidelidade = valorCompra * 0.15;
            //        valorCompra -= fidelidade;
            //        Console.WriteLine("Cartão fidelidade: " + valorCompra);
            //        if (quintaCompra == "sim")
            //        {
            //            cartao = valorCompra * 0.10;
            //            valorCompra -= cartao;
            //            Console.WriteLine("Quinta compra: " + valorCompra);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Não é a quinta compra!");
            //            Console.WriteLine(valorCompra);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Não tem cartão fidelidade!");
            //        Console.WriteLine(valorCompra);
            //    }
            //}
            //else if (valorCompra >= 400.01)
            //{
            //    desconto = valorCompra * 0.20;
            //    valorCompra -= desconto;
            //    Console.WriteLine("Valor da compra com desconto: " + valorCompra);
            //    if (cartaoFidelidade == "sim")
            //    {
            //        fidelidade = valorCompra * 0.15;
            //        valorCompra -= fidelidade;
            //        Console.WriteLine("Cartão fidelidade: " + valorCompra);
            //        if (quintaCompra == "sim")
            //        {
            //            cartao = valorCompra * 0.10;
            //            valorCompra -= cartao;
            //            Console.WriteLine("Quinta compra: " + valorCompra);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Não é a quinta compra!");
            //            Console.WriteLine(valorCompra);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Não tem cartão fidelidade!");
            //        Console.WriteLine(valorCompra);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Valor inválido!");
            //}


            //Exercício avançado
            //double a = Math.Pow(primeiroValor, segundoValor);
            Console.Write("Digite o primeiro valor: ");
            double primeiroValor = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite o tipo de operação: ");
            string operacao = Console.In.ReadLine();
            Console.Write("Digite o segundo valor: ");
            double segundoValor = Convert.ToDouble(Console.In.ReadLine());
            double conta;

            while (operacao != "0")
            {
                if (operacao == "/")
                {
                    if (primeiroValor > segundoValor)
                    {
                        conta = primeiroValor / segundoValor;
                        Console.WriteLine("Resultado => " + conta);
                    }
                    else
                    {
                        Console.WriteLine("Não é possível divisão por um número menor!");
                    }
                }
                else if (operacao == "*")
                {
                    conta = primeiroValor * segundoValor;
                    Console.WriteLine("Resultado => " + conta);
                }
                else if (operacao == "+")
                {
                    conta = primeiroValor + segundoValor;
                    Console.WriteLine("Resultado => " + conta);
                }
                else if (operacao == "-")
                {
                    if (primeiroValor > segundoValor)
                    {
                        conta = primeiroValor - segundoValor;
                        Console.WriteLine("Resultado => " + conta);
                    }
                    else
                    {
                        Console.WriteLine("Não é possível subtração por um número menor!");
                    }
                }
                else if (operacao == "**")
                {
                    Console.WriteLine($"{primeiroValor}^{segundoValor} = {(long)Math.Pow(primeiroValor, segundoValor):N0} ");
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente");
                }
            }
    }
}

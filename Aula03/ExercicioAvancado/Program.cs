using System;

namespace ExercicioAvancado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício Avançado");
            //1) desenvolva uma calculadora, esta calculadora deve fazer 5 operações, sendo estas: adição,subtração,multiplicação,divisão e ao quadrado, a calculadora deve receber um valor qualquer (com ou sem vírgula) pedir que timo de operação e então o segundo, após isso efetuar a conta, e então mostrar na tela o resultado
            //Exemplo de input: => TEM IMAGEM do console
            // 5
            // +
            // 7
            // resultado => 12
            //ps.: pode-se usar o símbolo ^ ou e para representar a elevação ao quadrado
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
}

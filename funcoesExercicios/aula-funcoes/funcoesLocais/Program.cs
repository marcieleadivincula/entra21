using System;

namespace funcoesLocais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para poder usar as funções criadas deve-se criar uma instância da class
            Program operacoes = new Program();

            Console.WriteLine("Soma: " + operacoes.Soma(89, 3));
            Console.WriteLine("Divisão: " + operacoes.Divisao(15.0, 3));
            Console.WriteLine("Subtração: " + operacoes.Subtracao(78, 3));
            Console.WriteLine("Multiplicação: " + operacoes.Multiplicacao(9, 3));
            Console.WriteLine("Raiz quadrada: " + operacoes.RaizQuadrada(8));
        }

        public int Soma(int a, int b)
        {
            int soma = a + b;
            return soma;
        }

        public double Divisao(double a, double b)
        {
            double divisao = a / b;

            if (a > b)
            {
                return divisao;
            }
            else
            {
                Console.WriteLine("Valor inválido! Primeiro valor é menor que o segundo valor, tente novamente!");
            }
            return divisao;
        }

        public int Subtracao(int a, int b)
        {
            int subtracao = a - b;
            return subtracao;
        }

        public int Multiplicacao(int a, int b)
        {
            int multiplicacao = a / b;

            if (a >= 0 || b >= 0)
            {
                return multiplicacao;
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
            return multiplicacao;
        }

        public int RaizQuadrada(int a)
        {
            int raizQuadrada = a * a;
            return raizQuadrada;
        }
    }
}

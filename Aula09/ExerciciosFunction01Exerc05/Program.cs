using System;

namespace ExerciciosFunction01Exerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 1 - Function");

            //5) Escreva uma função que receba 3 notas de um aluno e uma letra. Se a letra for A a função retorna a média aritmética das notas do aluno, se for P, a sua média ponderada (pesos: 5, 3 e 2) e se for M, a sua mediana.
            Program pro = new Program();
            double[] notas = new double[3];
            double nota;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a " + i + "° nota: ");
                nota = Convert.ToDouble(Console.In.ReadLine());
                notas[i] = nota;
            }

            Console.Write("Digite uma letra qualquer: ");
            string str = Console.In.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Média aritmética = " + pro.CalculaNotas(notas[0], notas[1], notas[2], str));

        }

        public double CalculaNotas(double nota1, double nota2, double nota3, string letra)
        {

            //Calcula média aritmética
            double soma = (nota1 + nota2 + nota3);
            double mediaAritmetica = soma / 3;

            //Calcula média ponderada
            double mediaPonderada = ((1 * nota1 + 1 * nota2 + 1 * nota3) / soma);

            //Calcula mediana
            double mediana = 0;
            //1° Coloque a sequência numérica em ordem crescente/descrescente
            if (nota1 > nota2)
            {

            }

            //2° verifica se a sequência numérica em qtd ímpar ou par: o valor que ocupa a posição central, se a quantidade desses valores for ímpar; a média dos dois valores centrais, se a qtd desses valores for par media ponderada
            if (mediana % 2 == 0)
            {
                mediana = ((nota1 / 2) + (nota2 / 2) + (nota3 / 2) + 1) / 2;
                mediana = ((nota1) + ((nota1 / 2) + 1)) / 2;
            }

            //3° Para a sequência numérica que tenha quantidade de números pares(8,3,1,6,8,3) : separa-se em quantidades iguais tanto para esquerda quanto para a direita 

            //4° Soma-se os números que sobraram no meio e divide por dois: 1 + 6 = 7; 7/2 = 3,5

            if (letra == "A")
            {
                return mediaAritmetica;
            }
            else if (letra == "P")
            {
                return mediaPonderada;
            }
            else if (letra == "M")
            {
                return mediana;
            }
            else
            {
                Console.WriteLine("Valor inválido, tente novamente!");
            }

            return mediaAritmetica;
        }
    }
}

using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 5: Escreva uma função que receba 3 notas de um aluno e uma letra. Se a letra for A a função retorna a média aritmética das notas do aluno, se for P, a sua média ponderada (pesos: 5, 3 e 2) e se for M, a sua mediana.
            Program pro = new Program();
            double[] nota = new double[3];

            Console.Write("Digite a nota " + i + ": ");
            nota[i] = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite a nota 2: ");
            n2 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite a nota 3: ");
            n3 = Convert.ToDouble(Console.In.ReadLine());

            Console.Write("Digite uma letra qualquer: ");
            string str = Console.In.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Média = " + pro.Media(vetNotas[nota], str));
        }

        public double Media(double[] vetNotas, string letra)
        {
            double mediana = 0, mediaAritmetica = 0, soma = 0, mediaPonderada = 0;

            for (int i = 0; i < vetNotas.Length; i++)
            {
                soma += vetNotas[i];
                mediaPonderada = (nota1 + nota2 + nota3) / (nota1 + nota2 + nota3);
                mediana = notas[i];
            }
            mediaAritmetica = soma / 3;

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
        }
    }
}

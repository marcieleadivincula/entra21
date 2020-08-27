using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 5: Escreva uma função que receba 3 notas de um aluno e uma letra. Se a letra for A a função retorna a média aritmética das notas do aluno, se for P, a sua média ponderada (pesos: 5, 3 e 2) e se for M, a sua mediana.
            Program pro = new Program();
            double n1, n2, n3;

            Console.Write("Digite a nota 1: ");
            n1 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite a nota 2: ");
            n2 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite a nota 3: ");
            n3 = Convert.ToDouble(Console.In.ReadLine());

            Console.Write("Digite uma letra qualquer: ");
            string str = Console.In.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Média = " + pro.Media(n1, n2, n3, str));
        }

        public double Media(double nota1, double nota2, double nota3, string letra)
        {
            double mediana;

            if (letra == "A")
            {
                double mediaAritmetica = (nota1 + nota2 + nota3) / 3;
                return mediaAritmetica;
            }
            else if (letra == "P")
            {
                double mediaPonderada = (nota1 + nota2 + nota3) / (nota1 + nota2 + nota3);
                return mediaPonderada;
            }
            else if (letra == "M")
            {
                // Declare and set array element values.
                //double[] notas = new double[] { nota1, nota2, nota3};
                //Alternative syntax.
                double[] notas = { nota1, nota2, nota3};

                for (int i = 0; i < notas.Length; i++)
                {
                    if (notas[i] < nota1 && notas[i] > nota1)
                    {
                        mediana = notas[i];
                        return mediana;
                    }
                    else
                    {
                        Console.WriteLine("Não tem mediana, valores são iguais!");
                    }
                }
               
            }
            else
            {
                Console.WriteLine("Valor inválido, tente novamente!");
            }
        }
    }
}

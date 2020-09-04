using System;

namespace ExerciciosFunction01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 1 - Function");

            //1) Escreva uma função que receba dois números inteiros retorne o menor número

            //2) Faça uma função que recebe um valor inteiro e verifica se o valor é par. A função deve retornar 1 se o número for par e 0 se for ímpar

            //3) Faça uma função que recebe um valor inteiro e verifica se o valor é positivo, negativo ou zero. A função deve retornar 1 para valores positivos, -1 para negativos e 0 para o valor 0.

            //4) Faça uma função que retorne a converção de Celsius para Fahrenheit.

            //5) Escreva uma função que receba 3 notas de um aluno e uma letra. Se a letra for A a função retorna a média aritmética das notas do aluno, se for P, a sua média ponderada (pesos: 5, 3 e 2) e se for M, a sua mediana.

            //6) Escreva uma função que recebe 5 valores e retorne o resultado da seguinte fórmula

            //7) Escreva uma função que retorne a reta da hipotenusa de um triângulo retângulo

            //8) Escreva uma função que começa pedindo um número N ao usuário e depois pede N números. Afunção deverá mostrar na tela todos esses números ordenados do menor para o maior. Escreva sua própria função de ordenação.
            Program ordenacao = new Program();
            ordenacao.OrdenaNumeros();
        }

        public void OrdenaNumeros()
        {
            Console.Write("Diga quantos números deseja inserir: ");
            int numero = Convert.ToInt32(Console.In.ReadLine());

            int[] vetNumeros = new int[numero];

            for (int i = 0; i < vetNumeros.Length; i++)
            {
                vetNumeros[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            //Escreve o vetor na tela desordenado
            for (int i = 0; i < vetNumeros.Length; i++)
            {
                Console.Write(vetNumeros[i] + " ");
            }

            for (int i = 0; i < vetNumeros.Length; i++) //seta que vai pra direita
            {
                for (int j = 0; j > 0; j++) //seta que vai pra esquerda
                {
                    if (vetNumeros[j - 1] > vetNumeros[j])
                    {
                        int temp = vetNumeros[j];
                        vetNumeros[j] = vetNumeros[j - 1];
                        vetNumeros[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();
            //Printa o vetor organizado
            for (int i = 0; i < vetNumeros.Length; i++)
            {
                Console.WriteLine(vetNumeros[i] + " ");
            }
        }
    }
}

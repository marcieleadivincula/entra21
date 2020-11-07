using System;

namespace ExerciciosDeMatrz01Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Faça um programa que leia uma matriz de 5 linhas e 4 colunas contendo as seguintes informações sobre alunos de uma disciplina, sendo todas as informações do tipo inteiro: • Primeira coluna: numero de matrícula (use um inteiro)
            //• Segunda coluna: media das provas
            //• Terceira coluna: media dos trabalhos
            //• Quarta coluna: nota final
            //Elabore um programa que:
            //(a)Leia as tres primeiras informações de cada aluno
            //(b) Calcule a nota final como sendo a soma da media das provas e da média dos trabalhos
            //(c) Imprima a matrícula do aluno que obteve a maior nota final(assuma que só existe
            //uma maior nota)
            //(d)Imprima a media aritmética das notas finais

            Console.WriteLine("Exercicio Resolvido 01");

            //exec 02
            int[][] alunos = new int[5][];
            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i] = new int[4];
            }
            //preenche a matriz
            for (int i = 0; i < alunos.Length; i++)
            {
                for (int j = 0; j < alunos[i].Length; j++)
                {
                    switch (j)
                    {
                        case 0:
                            alunos[i][j] = i;
                            break;
                        case 1:
                            Console.WriteLine("Insira a media das provas do {0}° aluno", (i + 1));
                            alunos[i][j] = Convert.ToInt32(Console.In.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Insira a media dos trabalhos do {0}° aluno", (i + 1));
                            alunos[i][j] = Convert.ToInt32(Console.In.ReadLine());
                            break;
                        case 3:
                            alunos[i][j] = alunos[i][1] + alunos[i][2];
                            break;
                    }
                }
            }
            int indiceMaiorNota = 0, melhorNota = 0;
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i][3] > melhorNota)
                {
                    melhorNota = alunos[i][3];
                    indiceMaiorNota = i;
                }
            }
            Console.WriteLine("Este é o aluno com a melhor media \n {0}", (alunos[indiceMaiorNota][0] + 1));

            int somaDasNotas = 0;
            for (int i = 0; i < alunos.Length; i++)
            {
                somaDasNotas += alunos[i][3];
            }
            Console.WriteLine("Esta é a média geral \n{0}", (somaDasNotas / alunos.Length));

        }
    }
}

using System;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
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

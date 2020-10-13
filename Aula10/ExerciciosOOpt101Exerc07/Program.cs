using System;

namespace ExerciciosOOpt101Exerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");
            //7 Crie 3 alunos que possuem nome, nota1,nota2,nota3 e uma função que retorna a média. Peça para o usuario preencher o nome, nota1,nota2 e nota3 deste aluno, em seguida, diga a média do aluno e se passou (para passar basta ter uma média > 7)
            Student[] students = new Student[3];

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Insira o nome do " + i + "° aluno: ");
                string nome = Console.In.ReadLine();
                Console.Write("Insira a nota1: ");
                double nota1 = Convert.ToDouble(Console.In.ReadLine());
                Console.Write("Insira a nota2: ");
                double nota2 = Convert.ToDouble(Console.In.ReadLine());
                Console.Write("Insira a nota3: ");
                double nota3 = Convert.ToDouble(Console.In.ReadLine());

                students[i] = new Student(nome, nota1, nota2, nota3);
                Console.WriteLine();
            }

            Console.WriteLine("Lista dos alunos e sua sistuação: ");
            for (int i = 0; i < students.Length; i++)
            {
                string info = string.Format("Nome: {0}, Média: {1:0.##} Situação: {2}", students[i].GetNome(), students[i].MediaNotas(), students[i].ValidaMedia());

                Console.WriteLine(info);
            }
        }
    }
}

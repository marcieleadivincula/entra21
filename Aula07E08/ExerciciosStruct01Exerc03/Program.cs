using System;

namespace ExerciciosStruct01Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de Struct - 1");

            //3) Crie 1 aluno que possui nome, nota1,nota2,nota3 e média. Peça para o usuario preencher o nome, nota1,nota2 e nota3 deste aluno, em seguida, diga a média do aluno e se passou (para passar basta ter uma média > 7)
            Aluno aluno = new Aluno();
            aluno.notas = new Notas();

            Console.Write("Nome do aluno: ");
            aluno.nome = Console.In.ReadLine();

            Console.Write("Nota1 do aluno: ");
            aluno.notas.nota1 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Nota2 do aluno: ");
            aluno.notas.nota2 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Nota3 do aluno: ");
            aluno.notas.nota3 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Nota4 do aluno: ");
            aluno.notas.nota4 = Convert.ToDouble(Console.In.ReadLine());

            //Console.Write("Media do aluno: ");
            aluno.media = (aluno.notas.nota1 + aluno.notas.nota2 + aluno.notas.nota3 + aluno.notas.nota4) / 4;
            if (aluno.media > 7)
            {
                Console.WriteLine();
                Console.WriteLine("Nome: " + aluno.nome);
                Console.WriteLine("Nota1:" + aluno.notas.nota1 + "\nNota2:" + aluno.notas.nota2 + "\nNota3:" + aluno.notas.nota3 + "\nNota4:" + aluno.notas.nota4);
                Console.WriteLine("Media: " + aluno.media);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sua média é menor que 7, então está reprovado!");
                Console.WriteLine("Media: " + aluno.media);
            }
        }

        public struct Aluno
        {
            public string nome;
            public Notas notas;
            public double media;
        }

        public struct Notas
        {
            public double nota1;
            public double nota2;
            public double nota3;
            public double nota4;
        }
    }
}

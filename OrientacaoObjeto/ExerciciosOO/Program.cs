using System;

namespace ExerciciosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");

            //1
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "Maria Alves";
            pessoa.idade = 65;
            pessoa.salario = 1578.65;

            Console.WriteLine("Nome: " + pessoa.nome + "\nIdade: " + pessoa.idade + "\nSalário: " + pessoa.salario);
        }
    }
}

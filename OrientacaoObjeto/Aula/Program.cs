using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pes = new Pessoa();
            pes.nome = "Maria Alves";
            pes.idade = 65;
            pes.salario = 1578.65;

            Console.WriteLine("Nome: " + pes.nome + "\nIdade" + pes.nome + "\nSalário: " + pes.salario);
        }
    }
}

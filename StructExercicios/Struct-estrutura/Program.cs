using System;

namespace Struct_estrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara um objeto da struct criada
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "Julieta";
            pessoa.idade = 57;

            Console.WriteLine(pessoa.nome + "\n" + pessoa.idade);

            //Declara um vetor de objetos da struct criada
            Pessoa[]  vetPessoa = new Pessoa[5];
            for (int i = 0; i < vetPessoa.Length; i++)
            {
                vetPessoa[i].nome = "ABC |" + i;
                vetPessoa[i].idade = 33 + i * 4;
                Console.WriteLine(vetPessoa[i].nome + "\n" + vetPessoa[i].idade + "\n --------------");
            }

        }

        //Encapsulamento de informação
        public struct Pessoa {
            public string nome;
            public int idade;
            public bool vivo;
            public double salario;
        }
        public class Person
        {
            public string nome;
            public int idade;
            public bool vivo;
            public double salario;
        }
    }
}

using System;

namespace StructExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.Write("Digite seu nome: ");
            pessoa.nome = Console.In.ReadLine();
            Console.Write("Digite sua idade: ");
            pessoa.idade = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Digite seu CPF:");
            pessoa.cpf = Console.In.ReadLine();
            pessoa.endereco = new Endereco();
            //Endereco endereco = new Endereco();

            Console.Write("Digite seu logradouro: ");
            //endereco.logradouro = Console.In.ReadLine();
            pessoa.endereco.logradouro = Console.In.ReadLine();
            Console.Write("Digite seu CEP: ");
            //endereco.cep = Console.In.ReadLine();
            pessoa.endereco.cep = Console.In.ReadLine();
            Console.Write("Digite seu numero: ");
            //endereco.numero = Console.In.ReadLine();
            pessoa.endereco.numero = Console.In.ReadLine();
            Console.Write("Digite seu bairro: ");
            //endereco.bairro = Console.In.ReadLine();
            pessoa.endereco.bairro = Console.In.ReadLine();
            Console.Write("Digite seu cidade: ");
            //endereco.cidade = Console.In.ReadLine();
            pessoa.endereco.cidade = Console.In.ReadLine();
            Console.Write("Digite seu estado: ");
            //endereco.estado = Console.In.ReadLine();
            pessoa.endereco.estado = Console.In.ReadLine();
            Console.Write("Digite seu pais: ");
            //endereco.pais = Console.In.ReadLine();
            pessoa.endereco.pais = Console.In.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Nome: " + pessoa.nome);
            Console.WriteLine("Idade: " + pessoa.idade);
            Console.WriteLine("CPF: " + pessoa.cpf);
            Console.WriteLine("Logradouro: " + pessoa.endereco.logradouro + "\nCEP: " + pessoa.endereco.cep + "\nNúmero: " + pessoa.endereco.numero + "\nBairro: " + pessoa.endereco.bairro + "\nCidade: " + pessoa.endereco.cidade + "\nEstado: " + pessoa.endereco.estado + "\nPaís: " + pessoa.endereco.pais);
        }

        public struct Pessoa
        {
            public string nome;
            public int idade;
            public string cpf;
            public Endereco endereco;
        }

        public struct Endereco
        {
            public string logradouro;
            public string cep;
            public string numero;
            public string bairro;
            public string cidade;
            public string estado;
            public string pais;
        }
    }
}

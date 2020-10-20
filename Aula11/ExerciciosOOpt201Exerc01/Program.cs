using System;

namespace ExerciciosOOpt201Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Exercícios - OOpt201");
            //1) Crie uma pessoa que possui nome,idade,cpf e endereço. Peça apara o usuario preencher os dados e após, mostrar na tela
            Pessoa[] pes = new Pessoa[1];

            for (int i = 0; i < pes.Length; i++)
            {
                Console.Write("Insira o nome: ");
                string nome = Console.In.ReadLine();
                Console.Write("Insira o idade: ");
                int idade = int.Parse(Console.In.ReadLine());
                Console.Write("Insira o cpf: ");
                string cpf = Console.In.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Insira o endereço completo: ");
                Console.Write("Insira o logradouro: ");
                string logradouro = Console.In.ReadLine();
                Console.Write("Insira o numero: ");
                string numero = Console.In.ReadLine();
                Console.Write("Insira o CEP: ");
                string cep = Console.In.ReadLine();
                Console.Write("Insira o bairro: ");
                string bairro = Console.In.ReadLine();
                Console.Write("Insira o cidade: ");
                string cidade = Console.In.ReadLine();
                Console.Write("Insira o estado: ");
                string estado = Console.In.ReadLine();

                Endereco end = new Endereco(logradouro, numero, cep, bairro, cidade, estado);

                pes[i] = new Pessoa(nome, idade, cpf, end);
            }

            Console.WriteLine();
            for (int i = 0; i < pes.Length; i++)
            {
                string result = string.Format("Nome: {0} Idade: {1} CPF: {2} \nLogradouro: {3} Número: {4} CEP: {5} Bairro: {6} Cidade: {7} Estado: {8}", pes[i].Nome + pes[i].Idade, pes[i].Cpf, pes[i].Endereco.Logradouro, pes[i].Endereco.Logradouro, pes[i].Endereco.Numero, pes[i].Endereco.Cep, pes[i].Endereco.Bairro, pes[i].Endereco.Cidade, pes[i].Endereco.Estado);

                Console.WriteLine(result);
            }
        }
    }
}

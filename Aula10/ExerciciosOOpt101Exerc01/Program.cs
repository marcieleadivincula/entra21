using System;

namespace ExerciciosOOpt101Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");
            //1) Crie uma pessoa que possui nome,idade,cpf e endereço. Peça apara o usuario preencher os dados e após, mostrar na tela
            Console.WriteLine("Insira os dados da pessoa");
            Console.Write("Insira o nome: ");
            string nome = Console.In.ReadLine();
            Console.Write("Insira a idade: ");
            int idade = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Insira o cpf: ");
            string cpf = Console.In.ReadLine();

            Console.WriteLine("Insira o endereço completo");
            Console.Write("Insira o logradouro: ");
            string endereco = Console.In.ReadLine();
            Console.Write("Insira o numero: ");
            string numero = Console.In.ReadLine();
            //Console.Write("Insira o complemento: ");
            //string complemento = Console.In.ReadLine();
            //Console.Write("Insira o CEP: ");
            //string cep = Console.In.ReadLine();
            //Console.Write("Insira o bairro: ");
            //string bairro = Console.In.ReadLine();
            //Console.Write("Insira a cidade: ");
            //string cidade = Console.In.ReadLine();
            //Console.Write("Insira o estado: ");
            //string estado = Console.In.ReadLine();
            //Console.Write("Insira o país: ");
            //string pais = Console.In.ReadLine();

            //Endereco end = new Endereco(endereco, numero, complemento, cep, bairro, cidade, estado, pais);
            Endereco end = new Endereco(endereco, numero);

            Pessoa pessoa = new Pessoa(nome, cpf, idade, end);

            Console.WriteLine();
            Console.WriteLine("Nome: {0} Idade: {1} CPF: {2} Endereço: {3} {4}", pessoa.GetNome(), pessoa.GetIdade(), pessoa.GetCpf(), pessoa.GetEndereco().GetLogradouro(), pessoa.GetEndereco().GetNumero());

            //Console.WriteLine("Nome: " + pessoa.GetNome() + "\nIdade: " + pessoa.GetIdade() + "\nSalário: " + pessoa.GetSalario() + "\nEndereço: " + pessoa.GetEndereco());
        }
    }
}

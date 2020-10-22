using System;

namespace ExerciciosOOpt401Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de OOpt - 401");
            //2) Crie uma subClasse chamado Pessoa com nome, idade, cpf e herda Endereco. Em seguida preencha essa Pessoa e mostre na tela.

            Pessoa pes = new Pessoa();

            Console.WriteLine("Olá cordial nobre cavalheiro, por obséquio insira um indivíduo");

            Console.Write("Nome: ");
            pes.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pes.Idade = int.Parse(Console.In.ReadLine()); //pes.Idade = Convert.ToInt32(Console.In.ReadLine()); 

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Rua: ");
            pes.Rua = Console.ReadLine();
            Console.Write("Número: ");
            pes.Numero = Console.ReadLine();
            Console.Write("Bairro: ");
            pes.Bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            pes.Cidade = Console.ReadLine();
            Console.Write("Estado: ");
            pes.Estado = Console.ReadLine();

            pes.SetCpf(cpf);

            Console.WriteLine("Dados pessoais: \nNome: {0} Idade: {1} CPF: {2}", pes.Nome, pes.Idade, pes.GetCpf());
            Console.WriteLine("Endereço: \nRua: {0} Número: {1} Bairro: {2} Cidade: {3} Estado: {4}", pes.Rua, pes.Numero, pes.Bairro, pes.Cidade, pes.Estado);
        }
    }
}

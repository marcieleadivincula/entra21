using System;

namespace ExerciciosOOpt401Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de OOpt - 401");
            //2) Crie uma subClasse chamado Pessoa com nome, idade, cpf e herda Endereco. Em seguida preencha essa Pessoa e mostre na tela.

            Pessoa[] pes = new Pessoa[1];

            for (int i = 0; i < pes.Length; i++)
            {
                Console.WriteLine("Insira os dados da pessoa: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.In.ReadLine()); //pes.Idade = Convert.ToInt32(Console.In.ReadLine()); 
                Console.Write("CPF: ");
                Console.WriteLine("Endereço completo");
                string cpf = Console.ReadLine();
                Console.Write("Rua: ");
                string rua = Console.ReadLine();
                Console.Write("Número: ");
                string numero = Console.ReadLine();
                Console.Write("Bairro: ");
                string bairro = Console.ReadLine();
                Console.Write("Cidade: ");
                string cidade = Console.ReadLine();
                Console.Write("Estado: ");
                string estado = Console.ReadLine();

                pes[i] = new Pessoa(nome, idade, cpf, rua, numero, bairro, cidade, estado);
            }

            for (int i = 0; i < pes.Length; i++)
            {
                Console.WriteLine("Dados pessoais: \nNome: {0} Idade: {1} CPF: {2}", pes[i].Nome, pes[i].Idade, pes[i].GetCpf());
                Console.WriteLine("Endereço completo: \nRua: {0} Número: {1} Bairro: {2} Cidade: {3} Estado: {4}", pes[i].Rua, pes[i].Numero, pes[i].Bairro, pes[i].Cidade, pes[i].Estado);
            }
            
        }
    }
}

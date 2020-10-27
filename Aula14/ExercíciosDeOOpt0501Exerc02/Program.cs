using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace ExercíciosDeOOpt0501Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExercíciosDeOOpt0501");
            //2) Crie uma ClassePai Chamado Endereco com rua, cep, cidade e estado. Crie uma Classepai Chamado Pessoa com nome, idade e cpf.

            //a) Crie uma subClasse chamado Funcionario com cargo, salario, herda Endereco e herda Pessoa.Crie e preencha 3 Funcionarios, após isso, mostre na tela os funcionarios que possuem um salario igual ou maior que 1800, caso tenha 1 ou mais funcionarios com salario inferior a 1800, mostre apenas aqueles que tem salário inferior a 1800.

            //b) Crie uma subClasse chamado Mae com nome do cônjuge(se houver), quantidade de filhos(se houver), herda Endereco e herda Pessoa.Crie e preencha uma Mae, após isso, mostre na tela e pergunte se deseja alterar alguma coisa e oque, caso nao queira, encerre.
            List<Funcionario> funcionarios = new List<Funcionario>();

            foreach (var func in funcionarios)
            {
                Console.WriteLine("Preencha 3 funcionários com: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Cargo: ");
                string cargo = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Endereço completo:");
                Console.Write("Rua: ");
                string rua = Console.ReadLine();
                Console.Write("Número: ");
                string numero = Console.ReadLine();
                Console.Write("CEP: ");
                string cep = Console.ReadLine();
                Console.Write("Bairro: ");
                string bairro = Console.ReadLine();
                Console.Write("Cidade: ");
                string cidade = Console.ReadLine();
                Console.Write("Estado");
                string estado = Console.ReadLine();

                Funcionario temp = new Funcionario(cargo, salario, nome, idade, cpf, rua, numero, cep, bairro, cidade, estado);
                funcionarios.Add(temp);
            }

            foreach (var func in funcionarios)
            {
                Console.WriteLine("Preencha 3 funcionários com: ");
                Console.Write("Nome: ");
                Console.Write(func.Nome);
                Console.Write("Idade: ");
                Console.Write(func.Idade);
                Console.Write("CPF: ");
                Console.Write(func.CPF);
                Console.Write("Cargo: ");
                Console.Write(func.Cargo);
                Console.Write("Salário: ");
                Console.Write(func.Salario);
                Console.WriteLine("Endereço completo:");
                Console.Write("Rua: ");
                Console.Write(func.Rua);
                Console.Write("Número: ");
                Console.Write(func.Numero);
                Console.Write("CEP: ");
                Console.Write(func.Cep);
                Console.Write("Bairro: ");
                Console.Write(func.Bairro);
                Console.Write("Cidade: ");
                Console.Write(func.Cidade);
                Console.Write("Estado");
                Console.Write(func.Estado);
            }
        }
    }
}

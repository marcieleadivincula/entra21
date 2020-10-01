using System;

namespace ExerciciosOOpt401Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de OOpt - 401");
            //3) Crie uma subClasse chamado Empresa com nome,quantida de funcionários e herda Endereco. Em seguida preencha essa Empresa e mostre na tela.

            Empresa emp = new Empresa();

            Console.Write("Nome: ");
            emp.Nome = Console.ReadLine();
            Console.Write("Quantidade de funcionários: ");
            emp.QtdFuncionarios = int.Parse(Console.ReadLine());

            Console.Write("Rua: ");
            emp.Rua = Console.ReadLine();
            Console.Write("Número: ");
            emp.Numero = Console.ReadLine();
            Console.Write("Bairro: ");
            emp.Bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            emp.Cidade = Console.ReadLine();
            Console.Write("Estado: ");
            emp.Estado = Console.ReadLine();

            Console.WriteLine("Nome: {0} Quantidade de funcionários: {1}", emp.Nome, emp.QtdFuncionarios);
            Console.WriteLine("Rua: {0} Número: {1} Bairro: {2} Cidade: {3} Estado: {4}", emp.Rua, emp.Numero, emp.Bairro, emp.Cidade, emp.Estado);
        }
    }
}

using System;
using System.Threading;

namespace ExerciciosOOpt401Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de OOpt - 401");
            //1) Crie um Script chamado Endereco com os seguintes dados : rua, numero, cidade e estado. Vamos usar esse escript como classe pai nos proximos exercícios.
            Endereco[] end = new Endereco[1];

            for (int i = 0; i < end.Length; i++)
            {
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

                end[i] = new Endereco(rua, numero, bairro, cidade, estado);
            }

            for (int i = 0; i < end.Length; i++)
            {
                Console.WriteLine("Rua: {0} Número: {1} Bairro: {2} Cidade: {3} Estado: {4}", end[i].Rua, end[i].Numero, end[i].Bairro, end[i].Cidade, end[i].Estado);
            }
        }
    }
}

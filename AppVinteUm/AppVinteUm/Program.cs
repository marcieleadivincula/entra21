using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppVinteUm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GeraOutrosDados.Cnpj());

            int userChoice;
            Console.Clear();
            Console.Write("MENU PRINCIPAL: \n1 - Adicionar \n2 - Remover \n3 - Comprar  \n4 - Bater Cartão \n5 - Alterar \n6 - Calcular \n7 - Sair \n");
            Console.WriteLine();
            Console.Write("Escolha uma opção:");
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    FuncaoMenu.Adicionar();
                    break;
                case 2:
                    Console.Clear();
                    FuncaoMenu.Remover();
                    break;
                case 3:
                    Console.Clear();
                    FuncaoMenu.Comprar();
                    break;
                case 4:
                    FuncaoMenu.BaterCartao();
                    Console.Clear();
                    break;
                case 5:
                    FuncaoMenu.Alterar();
                    Console.Clear();
                    break;
                case 6:
                    FuncaoMenu.CalcularLucro();
                    Console.Clear();
                    break;
                case 7:
                    FuncaoMenu.Sair();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Execução finalizada...");
            Console.ReadLine();


            //LIMPA BASE DE DADOS
            //SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            //SqlCommand cmd;
            //string truncate = "TRUNCATE TABLE Cliente";
            //cmd = new SqlCommand(truncate, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("Tabela de clientes limpa.");

            //truncate = "TRUNCATE TABLE Fornecedor";
            //cmd = new SqlCommand(truncate, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("Tabela de Fornecedor limpa.");

            //truncate = "TRUNCATE TABLE Funcionario";
            //cmd = new SqlCommand(truncate, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("Tabela de Funcionario limpa.");
        }
    }
}

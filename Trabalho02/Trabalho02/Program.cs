using System;
using System.Data.SqlClient;
namespace Trabalho02
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            string insert, select, update, create, delete;

            Cliente[] customer = new Cliente[7];

            for (int i = 0; i < customer.Length; i++)
            {
                customer[i] = new Cliente();

                customer[i].Nome = Gerador.NomePessoa();
                customer[i].CPF = Gerador.Cpf();
                customer[i].Idade = Gerador.Idade();
                customer[i].Saldo = Gerador.Saldo();

                customer[i].InsertCliente();
            }

            for (int i = 0; i < customer.Length; i++)
            {
                customer[i].SelectCliente();
            }
        }
    }
}

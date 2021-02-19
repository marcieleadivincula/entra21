using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Aula17ExercicioDeDBpt101Exerc01;

namespace ExercicioDeDBpt101Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Crie um Banco de Dados para armazenar 4 Clientes de uma loja, cada Cliente possui nome, idade e cpf. Após inserir todos os Clientes, Mostre estes Clientes na tela
            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=entra21");
            //SqlCommand cmd;
            SqlDataReader dr;

            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();

            ////CREATE TABLE
            //string create = "CREATE TABLE Pessoa(Id INT NOT NULL IDENTITY(0,1) PRIMARY KEY, Nome VARCHAR(60) NOT NULL)";
            //SqlCommand cmd = new SqlCommand(create, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            string nome, cpf, select;
            int idade;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Insira o cliente número: {0}", (i + 1));
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Cpf: ");
                cpf = Console.ReadLine();
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());

                string insert = $"INSERT INTO Cliente(Nome, Cpf, Idade) values('{nome}', '{cpf}', {idade})";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            select = "SELECT * FROM Cliente";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Id : {0}", dr["Id"]);
                Console.WriteLine("Nome : {0}", dr["Nome"]);
                Console.WriteLine("CPF : {0}", dr["Cpf"]);
                Console.WriteLine("Idade : {0}", dr["Idade"]);
                Console.WriteLine("-----------------//------------------");
            }
            conn.Close();

            Console.ReadLine();
        }
    }
}

using System;
using System.Data.SqlClient;

namespace Trabalho02
{
    class Socio : Cliente
    {
        public double QtdAcoes { get; set; }

        public void GeraQtdAcoes()
        {

        }

        public Socio()
        {

        }

        public Socio(double qtdAcoes, string nome, string cpf, int idade, double saldo) : base(nome, cpf, idade, saldo)
        {
            QtdAcoes = qtdAcoes;
        }
        public double GetAcoes()
        {
            return QtdAcoes;
        }

        public void SetAcoes(double qtdAcoes)
        {
            QtdAcoes = qtdAcoes;
        }

        public void CreateCliente()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            //CRIA TABELA PRODUTO
            string create = "CREATE TABLE Cliente (" +
                "[Id] INT IDENTITY(1,1) NOT NULL, " +
                "[Nome] VARCHAR(60), " +
                "[CPF] VARCHAR(20), " +
                "[Idade] INT NOT NULL, " +
                "[Saldo] FLOAT NOT NULL," +
                "PRIMARY KEY CLUSTERED([Id] ASC))";

            cmd = new SqlCommand(create, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void SelectClienteSocio()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            //Mostra: Mostra todos os produtos
            Console.WriteLine("-----------------//------------------");
            Console.WriteLine("LISTA DE CLIENTES do tipo SÓCIO: ");
            Console.WriteLine("-----------------//------------------");
            string select = "SELECT * FROM Cliente";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Id : {0}", dr["Id"]);
                Console.WriteLine("Nome: {0}", dr["Nome"]);
                Console.WriteLine("CPF: {0}", dr["CPF"]);
                Console.WriteLine("Idade: {0}", dr["Idade"]);
                Console.WriteLine("Saldo: {0}", dr["Saldo"]);
                Console.WriteLine("Tipo de Cliente: {0}", dr["IdTipoCliente"]);
                Console.WriteLine("-----------------//------------------");
            }
            conn.Close();
        }
        public void InsertClienteSocio()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            int tipoCliente = GeraOutrosDados.TipoCliente();

            //Inclui dados na tabela
            Console.WriteLine("Inserindo dos dados do cliente sócio: ");
            string insert = $"INSERT INTO Cliente(Nome, CPF, Idade, Saldo, IdTipoCliente) VALUES('{Nome}', '{CPF}', {Idade}, {Saldo}, {tipoCliente})";
            cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //public void UpdateClienteSocio()
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
        //    SqlCommand cmd;

        //    Console.WriteLine("Atualizando dos dados do cliente: ");
        //    string update = $"UPDATE Cliente SET Nome = '{Nome}', CPF = '{CPF}' WHERE id = {Id}";
        //    cmd = new SqlCommand(update, conn);
        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
        //public void DeleteClienteSocio()
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
        //    SqlCommand cmd;

        //    Console.WriteLine("Deletando dos dados do cliente: ");
        //    string delete = $"DELETE FROM Cliente WHERE Id = {Id}";
        //    cmd = new SqlCommand(delete, conn);
        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
    }
}

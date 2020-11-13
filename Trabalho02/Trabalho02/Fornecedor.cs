using System;
using System.Data.SqlClient;

namespace Trabalho02
{
    class Fornecedor
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public int TipoDeProduto { get; set; }
        public int QuantidadeFornecidaAoMes { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor(string nome, string cnpj, int tipoDeProduto, int qtdFornecidaAoMes)
        {
            Nome = nome;
            CNPJ = cnpj;
            TipoDeProduto = tipoDeProduto;
            QuantidadeFornecidaAoMes = qtdFornecidaAoMes;
        }

        public string GetDados()
        {
            return $"Nome: {Nome} CNPJ: {CNPJ} Tipo de Produto: {TipoDeProduto} Quantidade Fornecida ao Mês: {QuantidadeFornecidaAoMes}";
        }

        public string GetQuantidadeFornecida()
        {
            return $"Quantidade Fornecida ao Mês: {QuantidadeFornecidaAoMes}";
        }

        public void SetQuantidadeFornecida(int quantidade)
        {
            QuantidadeFornecidaAoMes = quantidade;
        }

        public void CreateFornecedor()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            //CRIA TABELA FORNECEDOR
            string create = "CREATE TABLE Fornecedor (" +
                "[Id] INT IDENTITY(1,1) NOT NULL, " +
                "[Nome] VARCHAR(60), " +
                "[CNPJ] VARCHAR(30), " +
                "[TipoDeProduto] INT NOT NULL, " +
                "[QuantidadeFornecidaAoMes] INT NOT NULL, " +
                "PRIMARY KEY CLUSTERED([Id] ASC))";

            cmd = new SqlCommand(create, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void SelectFornecedor()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            //Mostra: Mostra todos os produtos
            Console.WriteLine("-----------------//------------------");
            Console.WriteLine("LISTA DE FORNECEDOR: ");
            Console.WriteLine("-----------------//------------------");
            string select = "SELECT * FROM Fornecedor";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Id : {0}", dr["Id"]);
                Console.WriteLine("Nome: {0}", dr["Nome"]);
                Console.WriteLine("CNPJ: {0}", dr["CNPJ"]);
                Console.WriteLine("TipoDeProduto: {0}", dr["TipoDeProduto"]);
                Console.WriteLine("Quantidade Fornecida ao Mês: {0}", dr["QuantidadeFornecidaAoMes"]);
                Console.WriteLine("-----------------//------------------");
            }
            conn.Close();
        }
        public void InsertFornecedor()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;

            //Inclui dados na tabela
            Console.WriteLine("Inserindo dos dados do fornecedor: ");
            string insert = $"INSERT INTO Fornecedor(Nome, CPF, Idade, Saldo) VALUES('{Nome}', '{CNPJ}', {TipoDeProduto}, {QuantidadeFornecidaAoMes})";
            cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //public void UpdateFornecedor()
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
        //    SqlCommand cmd;

        //    Console.WriteLine("Atualizando dos dados do fornecedor: ");
        //    string update = $"UPDATE Fornecedor SET Nome = '{Nome}', CPF = '{CNPJ}', TipoDeProduto = {TipoDeProduto}, QuantidadeFornecidaAoMes = {QuantidadeFornecidaAoMes} WHERE id = {Id}";
        //    cmd = new SqlCommand(update, conn);
        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}

        //public void DeleteFornecedor()
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
        //    SqlCommand cmd;

        //    Console.WriteLine("Deletando dos dados do fornecedor: ");
        //    string delete = $"DELETE FROM Fornecedor WHERE Id = {Id}";
        //    cmd = new SqlCommand(delete, conn);
        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
    }
}

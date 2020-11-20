using System;
using System.Data.SqlClient;

namespace Trabalho02
{
    class Crud
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        string nome = Gerador.NomePessoa();
        string cpf = Gerador.Cpf();
        string cargo = GeraOutrosDados.Cargo();
        int idade = Gerador.Idade();
        double salarioPorHora = GeraOutrosDados.SalarioPorHora();
        double saldo = Gerador.Saldo();
        int id;

        public void CreateFuncionario()
        {
            //CRIA TABELA FUNCIONARIO
            string create = "CREATE TABLE Funcionario (" +
                "[Id] INT IDENTITY(1,1) NOT NULL, " +
                "[Nome] VARCHAR(60), " +
                "[CPF] VARCHAR(20), " +
                "[Idade] INT NOT NULL, " +
                "[SalarioPorHora] FLOAT NOT NULL, " +
                "[Cargo] VARCHAR(60), " +
                "[Saldo] FLOAT NOT NULL," +
                "PRIMARY KEY CLUSTERED([Id] ASC))";

            cmd = new SqlCommand(create, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void SelectFuncionario()
        {
            //Mostra: Mostra todos os funcionário
            Console.WriteLine("-----------------//------------------");
            Console.WriteLine("LISTA DE FUNCIONÁRIOS: ");
            Console.WriteLine("-----------------//------------------");
            string select = "SELECT * FROM Funcionario";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Id : {0}", dr["Id"]);
                Console.WriteLine("Nome: {0}", dr["Nome"]);
                Console.WriteLine("CPF: {0}", dr["CPF"]);
                Console.WriteLine("Idade: {0}", dr["Idade"]);
                Console.WriteLine("Salário por Hora: {0}", dr["SalarioPorHora"]);
                Console.WriteLine("Cargo: {0}", dr["Cargo"]);
                Console.WriteLine("Saldo: {0}", dr["Saldo"]);
                Console.WriteLine("-----------------//------------------");
            }
            conn.Close();
        }
        public void InsertFuncionario()
        {
            //Inclui dados na tabela
            Console.WriteLine("Inserindo dos dados do funcionário: ");
            string insert = $"INSERT INTO Funcionario(Nome, CPF, Idade, SalarioPorHora, Cargo, Saldo) VALUES('{nome}', '{cpf}', {idade}, {salarioPorHora}, '{cargo}', {saldo})";
            cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateFuncionario()
        {
            Console.WriteLine("Atualizando dos dados do funcionário: ");
            string update = $"UPDATE Funcionario SET Nome = '{nome}', CPF = '{cpf}', Idade = {idade}, SalarioPorHora = {salarioPorHora}, Cargo = '{cargo}', Saldo = {saldo} WHERE id = {id}";
            cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteFuncionario()
        {
            Console.WriteLine("Deletando dos dados do funcionário: ");
            string delete = $"DELETE FROM Funcionario WHERE Id = {id}";
            cmd = new SqlCommand(delete, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

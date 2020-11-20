using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Trabalho02
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public double SalarioPorHora { get; set; }
        public string Cargo { get; set; }
        public double Saldo { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, string cpf, int idade, double salarioPorHora, string cargo, double saldo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            SalarioPorHora = salarioPorHora;
            Cargo = cargo;
            Saldo = saldo;
        }

        public string GetDados()
        {
            return $"Nome: {Nome} CPF: {CPF} Idade: {Idade} Salário por Hora: {SalarioPorHora} Cargo: {Cargo} Saldo: {Saldo}";
        }

        public void SetDados(string nome, string cpf, int idade, double salarioPorHora, string cargo, double saldo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            SalarioPorHora = salarioPorHora;
            Cargo = cargo;
            Saldo = saldo;
        }

        public string GetCargoSalario()
        {
            return $"Cargo: {Cargo} Salário por Hora: {SalarioPorHora}";
        }

        public void SetCargoSalario(string cargo, double salario)
        {
            Cargo = cargo;
            SalarioPorHora = salario / 8.0;
        }

        //public BatePonto(string hrEntrada, string hrSaida)
        //{
        //    //Calcula o ganho do funcionário naquele dia de trabalho e adiciona no Saldo dele

        //}

        public void CreateFuncionario()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;

            //Inclui dados na tabela
            Console.WriteLine("Inserindo dos dados do funcionário: ");
            string insert = $"INSERT INTO Funcionario(Nome, CPF, Idade, SalarioPorHora, Cargo, Saldo) VALUES('{Nome}', '{CPF}', {Idade}, {SalarioPorHora}, '{Cargo}', {Saldo})";
            cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //public void UpdateFuncionario()
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
        //    SqlCommand cmd;

        //    Console.WriteLine("Atualizando dos dados do funcionário: ");
        //    string update = $"UPDATE Funcionario SET Nome = '{Nome}', CPF = '{CPF}', Idade = {Idade}, SalarioPorHora = {SalarioPorHora}, Cargo = '{Cargo}', Saldo = {Saldo} WHERE id = {Id}";
        //    cmd = new SqlCommand(update, conn);
        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
        //public void DeleteFuncionario()
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
        //    SqlCommand cmd;

        //    Console.WriteLine("Deletando dos dados do funcionário: ");
        //    string delete = $"DELETE FROM Funcionario WHERE Id = {Id}";
        //    cmd = new SqlCommand(delete, conn);
        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}

        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        public List<Funcionario> Listar()
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            try
            {

                SqlCommand sqlSelect = new SqlCommand("SELECT Id, Nome, CPF, Idade, SalarioPorHora, Cargo, Saldo FROM Funcionario ORDER BY Id", conn);
                conn.Open();

                SqlDataReader dr = sqlSelect.ExecuteReader();

                while (dr.Read())
                {
                    Funcionario func = new Funcionario();

                    func.Id = dr["Id"].ToString();
                    func.Nome = dr["Nome"].ToString();
                    func.CPF = dr["CPF"].ToString();
                    func.Idade = dr["Idade"].ToString();
                    func.SalarioPorHora = dr["SalarioPorHora"].ToString();
                    func.Cargo = dr["Cargo"].ToString();
                    func.Saldo = dr["Saldo"].ToString();

                    listaFuncionario.Add(func);
                }
            }
            finally
            {

                conn.Close();
            }

            return listaFuncionario;
        }
    }
}

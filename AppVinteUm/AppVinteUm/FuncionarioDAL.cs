using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppVinteUm
{
    public class FuncionarioDAL
    {
        //public string create()
        //{


        //CREATE Funcionario
        //for (int i = 0; i < 1; i++)
        //{
        //    SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
        //    SqlCommand cmd;

        //    //CRIA TABELA Funcionario
        //    string create = "CREATE TABLE Funcionario (" +
        //        "[Id] INT IDENTITY(1,1) NOT NULL, " +
        //        "[Nome] VARCHAR(60), " +
        //        "[CPF] VARCHAR(20), " +
        //        "[Idade] INT NOT NULL, " +
        //        "[SalarioPorHora] FLOAT NOT NULL, " +
        //        "[Cargo] VARCHAR(60), " +
        //        "[Saldo] FLOAT NOT NULL, " +
        //        "PRIMARY KEY CLUSTERED([Id] ASC))";

        //    cmd = new SqlCommand(create, conn);
        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}



        //    //SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
        //    //SqlCommand command = new SqlCommand();
        //    //command.Connection = conn;
        //    //command.CommandText = "CREATE TABLE Funcionario ([Id] INT IDENTITY(1,1) NOT NULL, [Nome] VARCHAR(60), [CPF] VARCHAR(20), [Idade] INT NOT NULL, [SalarioPorHora] FLOAT NOT NULL, [Cargo] VARCHAR(60), [Saldo] FLOAT NOT NULL, PRIMARY KEY CLUSTERED([Id] ASC)) VALUES(@Nome,  @CPF, @Idade, @SalarioPorHora, @Cargo, @Saldo)";
        //    //try
        //    //{
        //    //    conn.Open();
        //    //    command.ExecuteNonQuery();

        //    //    return "Funcionário criado com sucesso!";
        //    //}
        //    //catch (Exception)
        //    //{

        //    //    throw new Exception("Erro no DB, contate o administrador.");
        //    //}
        //    //finally
        //    //{
        //    //    conn.Dispose();
        //    //}
        //}

        public List<Funcionario> getAll()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Funcionario";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionario = new List<Funcionario>();
                while (reader.Read())
                {
                    Funcionario f = new Funcionario();
                    f.Id = Convert.ToInt32(reader["Id"]);
                    f.Nome = Convert.ToString(reader["Nome"]);
                    f.CPF = Convert.ToString(reader["CPF"]);
                    f.Idade = Convert.ToInt32(reader["Idade"]);
                    f.SalarioPorHora = Convert.ToDouble(reader["SalarioPorHora"]);
                    f.Cargo = Convert.ToString(reader["Cargo"]);
                    f.Saldo = Convert.ToDouble(reader["Saldo"]);

                    funcionario.Add(f);
                }
                return funcionario;
            }
            catch (Exception)
            {
                throw new Exception("Erro no DB, contate o administrador.");
            }
            finally
            {
                conn.Dispose();
            }
        }
        public string insert(Funcionario funcionario)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO Funcionario (Nome, CPF, Idade, SalarioPorHora, Cargo, Saldo) VALUES (@Nome,  @CPF, @Idade, @SalarioPorHora, @Cargo, @Saldo)";
            command.Parameters.AddWithValue("@Nome", funcionario.Nome);
            command.Parameters.AddWithValue("@CPF", funcionario.CPF);
            command.Parameters.AddWithValue("@Idade", funcionario.Idade);
            command.Parameters.AddWithValue("@SalarioPorHora", funcionario.SalarioPorHora);
            command.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
            command.Parameters.AddWithValue("@Saldo", funcionario.Saldo);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return "Cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    return "Este funcionário já foi cadastrado";
                }
                else
                {
                    return "Erro no DB, contate o administrador.";
                }
            }
            finally
            {
                conn.Dispose();
            }
        }
        public string update(Funcionario funcionario)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE Funcionario SET Nome = @Nome, CPF = @CPF, Idade = @Idade, SalarioPorHora = @SalarioPorHora, Cargo = @Cargo, Saldo = @Saldo WHERE ID = @Id";
            command.Parameters.AddWithValue("@Nome", funcionario.Nome);
            command.Parameters.AddWithValue("@CPF", funcionario.CPF);
            command.Parameters.AddWithValue("@Idade", funcionario.Idade);
            command.Parameters.AddWithValue("@SalarioPorHora", funcionario.SalarioPorHora);
            command.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
            command.Parameters.AddWithValue("@Saldo", funcionario.Saldo);
            command.Parameters.AddWithValue("@Id", funcionario.Id);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return "Atualizado com sucesso!";
            }
            catch (Exception)
            {
                return "Erro no DB, contate o administrador.";
            }
            finally
            {
                conn.Dispose();
            }
        }
        public string delete(Funcionario funcionario)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM Funcionario WHERE ID = @Id";
            command.Parameters.AddWithValue("@Id", funcionario.Id);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return "Deletado com sucesso!";
            }
            catch (Exception)
            {
                return "Erro no DB, contate o administrador.";
            }
            finally
            {
                conn.Dispose();
            }
        }

        public Funcionario getLastRegister()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT TOP(1) * FROM Funcionario ORDER BY Id DESC";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
                Funcionario funcionario = new Funcionario();

                while (reader.Read())
                {
                    funcionario = new Funcionario();
                    funcionario.Id = Convert.ToInt32(reader["Id"]);
                    funcionario.Nome = Convert.ToString(reader["Nome"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.SalarioPorHora = Convert.ToDouble(reader["SalarioPorHora"]);
                    funcionario.Cargo = Convert.ToString(reader["Cargo"]);
                    funcionario.Saldo = Convert.ToDouble(reader["Saldo"]);

                    funcionarios.Add(funcionario);
                }
                return funcionario;
            }
            catch (Exception)
            {

                throw new Exception("Erro no DB, contate o administrador.");
            }
            finally
            {
                conn.Dispose();
            }
        }

        public Funcionario getById(int id)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Funcionario WHERE Id = @Id";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
                Funcionario funcionario = new Funcionario();

                while (reader.Read())
                {
                    funcionario = new Funcionario();
                    funcionario.Id = Convert.ToInt32(reader["Id"]);
                    funcionario.Nome = Convert.ToString(reader["Nome"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.SalarioPorHora = Convert.ToDouble(reader["SalarioPorHora"]);
                    funcionario.Cargo = Convert.ToString(reader["Cargo"]);
                    funcionario.Saldo = Convert.ToDouble(reader["Saldo"]);

                    funcionarios.Add(funcionario);
                }
                return funcionario;
            }
            catch (Exception)
            {

                throw new Exception("Erro no DB, contate o administrador.");
            }
            finally
            {
                conn.Dispose();
            }
        }

        public Funcionario getByCpf(string cpf)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Funcionario WHERE CPF = @CPF";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionarios = new List<Funcionario>();
                Funcionario funcionario = new Funcionario(); //Esta linha estava dentro do while

                while (reader.Read())
                {
                    funcionario = new Funcionario();
                    funcionario.Id = Convert.ToInt32(reader["Id"]);
                    funcionario.Nome = Convert.ToString(reader["Nome"]);
                    funcionario.CPF = Convert.ToString(reader["CPF"]);
                    funcionario.SalarioPorHora = Convert.ToDouble(reader["SalarioPorHora"]);
                    funcionario.Cargo = Convert.ToString(reader["Cargo"]);
                    funcionario.Saldo = Convert.ToDouble(reader["Saldo"]);

                    funcionarios.Add(funcionario);
                }
                return funcionario;
            }
            catch (Exception)
            {

                throw new Exception("Erro no DB, contate o administrador.");
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}

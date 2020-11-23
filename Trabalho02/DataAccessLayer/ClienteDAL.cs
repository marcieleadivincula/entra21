using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Diagnostics;

namespace DataAccessLayer
{
    public class ClienteDAL
    {
        public string create()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "CREATE TABLE Cliente ([Id] INT IDENTITY(1,1) NOT NULL, [Nome] VARCHAR(60), [CPF] VARCHAR(20), [Idade] INT NOT NULL, [Saldo] FLOAT NOT NULL, PRIMARY KEY CLUSTERED([Id] ASC)) VALUES()";
            try
            {
                conn.Open();
                command.ExecuteNonQuery();

                return "Cliente criado com sucesso!";
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
        public List<Cliente> getAll()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Cliente";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> cliente = new List<Cliente>();

                while (reader.Read())
                {
                    Cliente c = new Cliente();
                    c.Id = Convert.ToInt32(reader["Id"]);
                    c.Nome = Convert.ToString(reader["Nome"]);
                    c.CPF = Convert.ToString(reader["CPF"]);
                    c.Idade = Convert.ToInt32(reader["Idade"]);
                    c.Saldo = Convert.ToDouble(reader["Saldo"]);
                    c.IdTipoCliente = Convert.ToInt32(reader["IdTipoCliente"]);

                    cliente.Add(c);
                }
                return cliente;
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
        public string insert(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO Cliente(Nome, CPF, Idade, Saldo, IdTipoCliente) VALUES(@Nome, @CPF, @Idade, @Saldo, @IdTipoCliente)";
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@Idade", cliente.Idade);
            command.Parameters.AddWithValue("@Saldo", cliente.Saldo);
            command.Parameters.AddWithValue("@IdTipoCliente", cliente.IdTipoCliente);

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
                    return "Este funcionario já foi cadastrado";
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
        public string update(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE Cliente SET Nome = @Nome, CPF = @CPF, Idade = @Idade, Saldo = @Saldo, IdTipoCliente = @IdTipoCliente WHERE Id = @Id";
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@Idade", cliente.Idade);
            command.Parameters.AddWithValue("@Saldo", cliente.Saldo);
            command.Parameters.AddWithValue("@Id", cliente.Id);

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

        public string delete(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM Cliente WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", cliente.Id);

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

        public Cliente getLastRegister()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT TOP(1) * FROM Cliente ORDER BY Id DESC";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                Cliente cliente = new Cliente();

                while (reader.Read())
                {
                    cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(reader["Id"]);
                    cliente.Nome = Convert.ToString(reader["Nome"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Idade = Convert.ToInt32(reader["Idade"]);
                    cliente.Saldo = Convert.ToDouble(reader["Saldo"]);
                    cliente.IdTipoCliente = Convert.ToInt32(reader["IdTipoCliente"]);

                    clientes.Add(cliente);
                }
                return cliente;
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

        public Cliente getById(int id)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Cliente WHERE Id = @Id";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                Cliente cliente = new Cliente(); //Esta linha estava dentro do while

                while (reader.Read())
                {
                    cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(reader["Id"]);
                    cliente.Nome = Convert.ToString(reader["Nome"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Idade = Convert.ToInt32(reader["Idade"]);
                    cliente.Saldo = Convert.ToDouble(reader["Saldo"]);
                    cliente.IdTipoCliente = Convert.ToInt32(reader["IdTipoCliente"]);

                    clientes.Add(cliente);
                }
                return cliente;
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

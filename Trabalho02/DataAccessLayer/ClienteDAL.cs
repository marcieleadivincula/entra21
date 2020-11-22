using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccessLayer
{
    public class ClienteDAL
    {
        public string CreateCliente()
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
        public List<Cliente> getAllCliente()
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
        public string InsertCliente(Cliente cliente)
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
        public string UpdateCliente(Cliente cliente)
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

        public string DeleteCliente(Cliente cliente)
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
    }
}

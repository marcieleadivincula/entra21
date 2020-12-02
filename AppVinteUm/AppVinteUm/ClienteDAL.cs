using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace AppVinteUm
{
    public class ClienteDAL
    {
        public List<Cliente> getAll()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Cliente WHERE TipoCliente LIKE 'N%'";

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                Cliente c = new Cliente();

                while (reader.Read())
                {
                    c = new Cliente();
                    c.Id = Convert.ToInt32(reader["Id"]);
                    c.Nome = Convert.ToString(reader["Nome"]);
                    c.CPF = Convert.ToString(reader["CPF"]);
                    c.Idade = Convert.ToInt32(reader["Idade"]);
                    c.Saldo = Convert.ToDouble(reader["Saldo"]);
                    c.TipoCliente = Convert.ToString(reader["TipoCliente"]);
                    clientes.Add(c);


                    //clientes.Add(new Cliente
                    //{
                    //    Id = Convert.ToInt32(reader["Id"]),
                    //    Nome = Convert.ToString(reader["Nome"]),
                    //    CPF = Convert.ToString(reader["CPF"]),
                    //    Idade = Convert.ToInt32(reader["Idade"]),
                    //    Saldo = Convert.ToDouble(reader["Saldo"]),
                    //    TipoCliente = Convert.ToString(reader["TipoCliente"])
                    //});
                }
               
                return clientes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
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
            command.CommandText = "INSERT INTO Cliente(Nome, CPF, Idade, Saldo, TipoCliente) VALUES(@Nome, @CPF, @Idade, @Saldo, @TipoCliente)";
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@Idade", cliente.Idade);
            command.Parameters.AddWithValue("@Saldo", cliente.Saldo);
            command.Parameters.AddWithValue("@TipoCliente", cliente.TipoCliente);

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
                    return "Este cliente já foi cadastrado";
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
            command.CommandText = "UPDATE Cliente SET Nome = @Nome, CPF = @CPF, Idade = @Idade, Saldo = @Saldo, TipoCliente = @TipoCliente WHERE Id = @Id";
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@Idade", cliente.Idade);
            command.Parameters.AddWithValue("@Saldo", cliente.Saldo);
            command.Parameters.AddWithValue("@TipoCliente", cliente.TipoCliente);
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
                    cliente.TipoCliente = Convert.ToString(reader["TipoCliente"]);

                    clientes.Add(cliente);
                }
                return cliente;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            command.CommandText = "SELECT * FROM Cliente WHERE Id = " + id;
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
                    cliente.TipoCliente = Convert.ToString(reader["TipoCliente"]);

                    clientes.Add(cliente);
                }
                return cliente;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Erro no DB, contate o administrador.");
            }
            finally
            {
                conn.Dispose();
            }
        }

        public Cliente getByCpf(string cpf)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = $"SELECT * FROM Cliente WHERE CPF = '{cpf}'";
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
                    cliente.TipoCliente = Convert.ToString(reader["TipoCliente"]);

                    clientes.Add(cliente);
                }
                return cliente;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                throw new Exception("Erro no DB, contate o administrador.");
            }
            finally
            {
                conn.Dispose();
            }
        }

        public Cliente getBySumSaldo()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = $"SELECT SUM(Saldo) FROM Cliente WHERE TipoCliente LIKE 'Normal'";
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
                    cliente.TipoCliente = Convert.ToString(reader["TipoCliente"]);

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

        public Cliente getBySaldo(string cpf)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = $"SELECT SUM(Saldo) FROM Cliente WHERE CPF = '{cpf}'";
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
                    cliente.TipoCliente = Convert.ToString(reader["TipoCliente"]);

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

        public string updateSaldo(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE Cliente SET Saldo = @Saldo WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@Saldo", cliente.Saldo);

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

        public string deleteByCPF(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM Cliente WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@Id", cliente.CPF);

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

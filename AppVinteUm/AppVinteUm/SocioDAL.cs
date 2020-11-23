using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppVinteUm
{
    public class SocioDAL: ClienteDAL
    {
        public string insert(Socio socio)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO Cliente(Nome, CPF, Idade, Saldo, TipoCliente, QtdAcoes) VALUES(@Nome, @CPF, @Idade, @Saldo, @TipoCliente, @QtdAcoes)";
            command.Parameters.AddWithValue("@Nome", socio.Nome);
            command.Parameters.AddWithValue("@CPF", socio.CPF);
            command.Parameters.AddWithValue("@Idade", socio.Idade);
            command.Parameters.AddWithValue("@Saldo", socio.Saldo);
            command.Parameters.AddWithValue("@TipoCliente", socio.TipoCliente);
            command.Parameters.AddWithValue("@QtdAcoes", socio.QtdAcoes);

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
                    return "Este sócio já foi cadastrado";
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

        public List<Socio> getAll()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Cliente WHERE TipoCliente LIKE 'Sócio'";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Socio> socios = new List<Socio>();
                while (reader.Read())
                {
                    Socio s = new Socio();
                    s.Id = Convert.ToInt32(reader["Id"]);
                    s.Nome = Convert.ToString(reader["Nome"]);
                    s.CPF = Convert.ToString(reader["CPF"]);
                    s.Idade = Convert.ToInt32(reader["Idade"]);
                    s.Saldo = Convert.ToDouble(reader["Saldo"]);
                    s.TipoCliente = Convert.ToString(reader["TipoCliente"]);
                    s.QtdAcoes = Convert.ToDouble(reader["QtdAcoes"]);

                    socios.Add(s);
                }
                return socios;
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

        public string delete(Socio socio)
        {

            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM Cliente WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", socio.Id);

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

        public string update(Socio socio)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE Cliente SET Nome = @Nome, CPF = @CPF, Idade = @Idade, Saldo = @Saldo, TipoCliente = @TipoCliente WHERE Id = @Id";
            command.Parameters.AddWithValue("@Nome", socio.Nome);
            command.Parameters.AddWithValue("@CPF", socio.CPF);
            command.Parameters.AddWithValue("@Idade", socio.Idade);
            command.Parameters.AddWithValue("@Saldo", socio.Saldo);
            command.Parameters.AddWithValue("@TipoCliente", socio.TipoCliente);
            command.Parameters.AddWithValue("@QtdAcoes", socio.QtdAcoes);
            command.Parameters.AddWithValue("@Id", socio.Id);

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

        public Socio getLastRegister()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT TOP(1) * FROM Cliente ORDER BY Id DESC";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Socio> socios = new List<Socio>();
                Socio socio = new Socio();

                while (reader.Read())
                {
                    socio = new Socio();
                    socio.Id = Convert.ToInt32(reader["Id"]);
                    socio.Nome = Convert.ToString(reader["Nome"]);
                    socio.CPF = Convert.ToString(reader["CPF"]);
                    socio.Idade = Convert.ToInt32(reader["Idade"]);
                    socio.Saldo = Convert.ToDouble(reader["Saldo"]);
                    socio.TipoCliente = Convert.ToString(reader["TipoCliente"]);
                    socio.QtdAcoes = Convert.ToDouble(reader["QtdAcoes"]);

                    socios.Add(socio);
                }
                return socio;
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

        public Socio getById(int id)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Cliente WHERE Id = @Id";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Socio> socios = new List<Socio>();
                Socio socio = new Socio(); //Esta linha estava dentro do while

                while (reader.Read())
                {
                    socio = new Socio();
                    socio.Id = Convert.ToInt32(reader["Id"]);
                    socio.Nome = Convert.ToString(reader["Nome"]);
                    socio.CPF = Convert.ToString(reader["CPF"]);
                    socio.Idade = Convert.ToInt32(reader["Idade"]);
                    socio.Saldo = Convert.ToDouble(reader["Saldo"]);
                    socio.TipoCliente = Convert.ToString(reader["TipoCliente"]);
                    socio.QtdAcoes = Convert.ToDouble(reader["QtdAcoes"]);

                    socios.Add(socio);
                }
                return socio;
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

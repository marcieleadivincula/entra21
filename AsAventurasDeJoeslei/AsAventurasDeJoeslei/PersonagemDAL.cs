using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AsAventurasDeJoeslei
{
    public class PersonagemDAL
    {
        public List<Personagem> GetAll()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Personagem";

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Personagem> personagens = new List<Personagem>();
                Personagem p = new Personagem();

                while (reader.Read())
                {
                    p = new Personagem();
                    p.Id = Convert.ToInt32(reader["Id"]);
                    p.Raca = Convert.ToString(reader["Raca"]);
                    p.Vida = Convert.ToInt32(reader["Vida"]);
                    p.DanoMinimo = Convert.ToInt32(reader["DanoMinimo"]);
                    p.DanoMaximo = Convert.ToInt32(reader["DanoMaximo"]);
                    p.Recompensa = Convert.ToInt32(reader["Recompensa"]);
                    personagens.Add(p);
                }

                return personagens;
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
        public string Insert(Personagem personagem)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO Personagem(Raca, Vida, DanoMinimo, DanoMaximo, Recompensa) VALUES(@Raca, @Vida, @DanoMinimo, @DanoMaximo, @Recompensa)";
            command.Parameters.AddWithValue("@Raca", personagem.Raca);
            command.Parameters.AddWithValue("@Vida", personagem.Vida);
            command.Parameters.AddWithValue("@DanoMinimo", personagem.DanoMinimo);
            command.Parameters.AddWithValue("@DanoMaximo", personagem.DanoMaximo);
            command.Parameters.AddWithValue("@Recompensa", personagem.Recompensa);

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
                    return "Este personagem já foi cadastrado";
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
        public string Update(Personagem personagem)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE Personagem SET Raca = @Raca, Vida = @Vida, DanoMinimo = @DanoMinimo, DanoMaximo = @DanoMaximo, Recompensa = @Recompensa WHERE Id = @Id";
            command.Parameters.AddWithValue("@Raca", personagem.Raca);
            command.Parameters.AddWithValue("@Vida", personagem.Vida);
            command.Parameters.AddWithValue("@DanoMinimo", personagem.DanoMinimo);
            command.Parameters.AddWithValue("@DanoMaximo", personagem.DanoMaximo);
            command.Parameters.AddWithValue("@Recompensa", personagem.Recompensa);
            command.Parameters.AddWithValue("@Id", personagem.Id);

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

        public string Delete(Personagem personagem)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM Personagem WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", personagem.Id);

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

        public Personagem GetLastRegister()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT TOP(1) * FROM Personagem ORDER BY Id DESC";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Personagem> personagens = new List<Personagem>();
                Personagem personagem = new Personagem();

                while (reader.Read())
                {
                    personagem = new Personagem();
                    personagem.Id = Convert.ToInt32(reader["Id"]);
                    personagem.Raca = Convert.ToString(reader["Raca"]);
                    personagem.Vida = Convert.ToInt32(reader["Vida"]);
                    personagem.DanoMinimo = Convert.ToInt32(reader["DanoMinimo"]);
                    personagem.DanoMaximo = Convert.ToInt32(reader["DanoMaximo"]);
                    personagem.Recompensa = Convert.ToInt32(reader["Recompensa"]);
                    personagens.Add(personagem);
                }
                return personagem;
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
    }
}

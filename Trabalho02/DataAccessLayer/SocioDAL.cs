using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SocioDAL
    {
        public string Inserir(Socio socio)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO Cliente (NOME,USUARIO,SENHA) VALUES (@NOME,@USUARIO,@SENHA)";
            command.Parameters.AddWithValue("@NOME", socio.Nome);
            command.Parameters.AddWithValue("@USUARIO", socio.Usuario);
            command.Parameters.AddWithValue("@SENHA", socio.Senha);

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


        public List<Socio> LerTodos()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM CADASTRO_FUNCIONARIO";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Funcionario> funcionario = new List<Funcionario>();
                while (reader.Read())
                {
                    Socio s = new Socio();
                    s.ID = Convert.ToInt32(reader["ID"]);
                    s.Nome = Convert.ToString(reader["NOME"]);
                    s.Usuario = Convert.ToString(reader["USUARIO"]);
                    s.Senha = Convert.ToString(reader["SENHA"]);

                    funcionario.Add(s);
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


        public string Deletar(Socio socio)
        {

            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM CADASTRO_FUNCIONARIO WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", socio.ID);

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

        public string Atualizar(Socio socio)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE CADASTRO_FUNCIONARIO SET USUARIO = @USUARIO, SENHA = @SENHA WHERE ID = @ID";
            command.Parameters.AddWithValue("@USUARIO", socio.Usuario);
            command.Parameters.AddWithValue("@SENHA", socio.Senha);
            command.Parameters.AddWithValue("@ID", socio.ID);

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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccessLayer
{
    public class FornecedorDAL
    {
        public string CreateFornecedor()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "CREATE TABLE Fornecedor ([Id] INT IDENTITY(1,1) NOT NULL, [Nome] VARCHAR(60), [CNPJ] VARCHAR(20), [TipoDeProduto] INT NOT NULL, [QuantidadeFornecidaAoMes] INT NOT NULL, PRIMARY KEY CLUSTERED([Id] ASC)) VALUES()";
            try
            {
                conn.Open();
                command.ExecuteNonQuery();

                return "Fornecedor criado com sucesso!";
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


        public string InsertFonecedor(Fornecedor fornecedor)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO Fornecedor (Nome,CNPJ,TipoDeProduto, QuantidadeFornecidaAoMes) VALUES (@Nome, @CNPJ, @TipoDeProduto, @QuantidadeFornecidaAoMes)";
            command.Parameters.AddWithValue("@Nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@TipoDeProduto", fornecedor.TipoDeProduto);
            command.Parameters.AddWithValue("@QuantidadeFornecidaAoMes", fornecedor.QuantidadeFornecidaAoMes);

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
                    return "Este fornecedor já foi cadastrado";
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

        public List<Fornecedor> getAllFornecedor()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Fornecedor";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedor = new List<Fornecedor>();
                while (reader.Read())
                {
                    Fornecedor f = new Fornecedor();
                    f.Id = Convert.ToInt32(reader["Id"]);
                    f.Nome = Convert.ToString(reader["Nome"]);
                    f.CNPJ = Convert.ToString(reader["CNPJ"]);
                    f.TipoDeProduto = Convert.ToInt32(reader["TipoDeProduto"]);
                    f.QuantidadeFornecidaAoMes = Convert.ToInt32(reader["QuantidadeFornecidaAoMes"]);

                    fornecedor.Add(f);
                }
                return fornecedor;
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

        public string DeleteFornecedor(Fornecedor fornecedor)
        {

            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE FROM Fornecedor WHERE ID = @Id";
            command.Parameters.AddWithValue("@Id", fornecedor.Id);

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

        public string UpdateFornecedor(Fornecedor fornecedor)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE Fornecedor SET Nome = @Nome, CNPJ = @CNPJ, TipoDeProduto = @TipoDeProduto,  QuantidadeFornecidaAoMes = @QuantidadeFornecidaAoMes WHERE ID = @Id";
            command.Parameters.AddWithValue("@Nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@TipoDeProduto", fornecedor.TipoDeProduto);
            command.Parameters.AddWithValue("@QuantidadeFornecidaAoMes", fornecedor.QuantidadeFornecidaAoMes);
            command.Parameters.AddWithValue("@Id", fornecedor.Id);

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

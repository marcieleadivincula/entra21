﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public class FornecedorDAL
    {
        //public string create()
        //{
        //    //CREATE Fornecedor
        //    //SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
        //    //SqlCommand cmd;

        //    //CRIA TABELA Fornecedor
        //    //string create = "CREATE TABLE Fornecedor (" +
        //    //    "[Id] INT IDENTITY(1,1) NOT NULL, " +
        //    //    "[Nome] VARCHAR(60), " +
        //    //    "[CNPJ] VARCHAR(20), " +
        //    //    "[TipoDeProduto] INT NOT NULL, " +
        //    //    "[QuantidadeFornecidaAoMes] INT NOT NULL, " +
        //    //    "PRIMARY KEY CLUSTERED([Id] ASC))";

        //    //cmd = new SqlCommand(create, conn);
        //    //conn.Open();
        //    //cmd.ExecuteNonQuery();
        //    //conn.Close();

        //    SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
        //    SqlCommand command = new SqlCommand();
        //    command.Connection = conn;
        //    command.CommandText = "CREATE TABLE Fornecedor ([Id] INT IDENTITY(1,1) NOT NULL, [Nome] VARCHAR(60), [CNPJ] VARCHAR(20), [TipoDeProduto] INT NOT NULL, [QuantidadeFornecidaAoMes] INT NOT NULL, PRIMARY KEY CLUSTERED([Id] ASC)) VALUES(@Nome, @CNPJ, @TipoDeProduto, @QuantidadeFornecidaAoMes)";
        //    try
        //    {
        //        conn.Open();
        //        command.ExecuteNonQuery();

        //        return "Fornecedor criado com sucesso!";
        //    }
        //    catch (Exception)
        //    {

        //        throw new Exception("Erro no DB, contate o administrador.");
        //    }
        //    finally
        //    {
        //        conn.Dispose();
        //    }
        //}

        public string insert(Fornecedor fornecedor)
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

        public List<Fornecedor> getAll()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Fornecedor";

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                while (reader.Read())
                {
                    Fornecedor f = new Fornecedor();
                    f.Id = Convert.ToInt32(reader["Id"]);
                    f.Nome = Convert.ToString(reader["Nome"]);
                    f.CNPJ = Convert.ToString(reader["CNPJ"]);
                    f.TipoDeProduto = Convert.ToInt32(reader["TipoDeProduto"]);
                    f.QuantidadeFornecidaAoMes = Convert.ToInt32(reader["QuantidadeFornecidaAoMes"]);

                    fornecedores.Add(f);
                }
                return fornecedores;
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

        public string delete(Fornecedor fornecedor)
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Erro no DB, contate o administrador.";
            }
            finally
            {
                conn.Dispose();
            }
        }

        public string update(Fornecedor fornecedor)
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Erro no DB, contate o administrador.";
            }
            finally
            {
                conn.Dispose();
            }
        }

        public Fornecedor getLastRegister()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT TOP(1) * FROM Fornecedor ORDER BY Id DESC";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                Fornecedor fornecedor = new Fornecedor();

                while (reader.Read())
                {
                    fornecedor = new Fornecedor();
                    fornecedor.Id = Convert.ToInt32(reader["Id"]);
                    fornecedor.Nome = Convert.ToString(reader["Nome"]);
                    fornecedor.CNPJ = Convert.ToString(reader["CNPJ"]);
                    fornecedor.TipoDeProduto = Convert.ToInt32(reader["TipoDeProduto"]);
                    fornecedor.QuantidadeFornecidaAoMes = Convert.ToInt32(reader["QuantidadeFornecidaAoMes"]);

                    fornecedores.Add(fornecedor);
                }
                return fornecedor;
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

        public Fornecedor getById(int id)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Fornecedor WHERE Id = " + id;
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                Fornecedor fornecedor = new Fornecedor();

                while (reader.Read())
                {
                    fornecedor = new Fornecedor();
                    fornecedor.Id = Convert.ToInt32(reader["Id"]);
                    fornecedor.Nome = Convert.ToString(reader["Nome"]);
                    fornecedor.CNPJ = Convert.ToString(reader["CNPJ"]);
                    fornecedor.TipoDeProduto = Convert.ToInt32(reader["TipoDeProduto"]);
                    fornecedor.QuantidadeFornecidaAoMes = Convert.ToInt32(reader["QuantidadeFornecidaAoMes"]);

                    fornecedores.Add(fornecedor);
                }
                return fornecedor;
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

        public Fornecedor getByCnpj(string cnpj)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = $"SELECT * FROM Fornecedor WHERE CNPJ = '{cnpj}'";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                Fornecedor fornecedor = new Fornecedor();

                while (reader.Read())
                {
                    fornecedor = new Fornecedor();
                    fornecedor.Id = Convert.ToInt32(reader["Id"]);
                    fornecedor.Nome = Convert.ToString(reader["Nome"]);
                    fornecedor.CNPJ = Convert.ToString(reader["CNPJ"]);
                    fornecedor.TipoDeProduto = Convert.ToInt32(reader["TipoDeProduto"]);
                    fornecedor.QuantidadeFornecidaAoMes = Convert.ToInt32(reader["QuantidadeFornecidaAoMes"]);

                    fornecedores.Add(fornecedor);
                }
                return fornecedor;
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

        public Fornecedor getBySumQtdProdutos()
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT SUM(QuantidadeFornecidaAoMes) FROM Fornecedor";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                Fornecedor fornec = new Fornecedor();

                while (reader.Read())
                {
                    fornec = new Fornecedor();
                    fornec.Id = Convert.ToInt32(reader["Id"]);
                    fornec.Nome = Convert.ToString(reader["Nome"]);
                    fornec.CNPJ = Convert.ToString(reader["CNPJ"]);
                    fornec.TipoDeProduto = Convert.ToInt32(reader["TipoDeProduto"]);
                    fornec.QuantidadeFornecidaAoMes = Convert.ToInt32(reader["QuantidadeFornecidaAoMes"]);

                    fornecedores.Add(fornec);
                }
                return fornec;
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

        public Fornecedor getByTipoDeProduto(int tipoProduto)
        {
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT COUNT(TipoDeProduto) FROM Fornecedor WHERE Id = @Id GROUP BY CNPJ";
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                Fornecedor fornecedor = new Fornecedor();

                while (reader.Read())
                {
                    fornecedor = new Fornecedor();
                    fornecedor.Id = Convert.ToInt32(reader["Id"]);
                    fornecedor.Nome = Convert.ToString(reader["Nome"]);
                    fornecedor.CNPJ = Convert.ToString(reader["CNPJ"]);
                    fornecedor.TipoDeProduto = Convert.ToInt32(reader["TipoDeProduto"]);
                    fornecedor.QuantidadeFornecidaAoMes = Convert.ToInt32(reader["QuantidadeFornecidaAoMes"]);

                    fornecedores.Add(fornecedor);
                }
                return fornecedor;
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

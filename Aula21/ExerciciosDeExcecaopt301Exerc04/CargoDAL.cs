using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Aula21;

namespace ExerciciosDeExcecaopt301Exerc04
{
    public static class CargoDAL
    {
        public static void Create()
        {
            SqlConnection connection = new SqlConnection(DBConfig.CONNECTION_STRING);
            string create = "CREATE TABLE Cargo(Id INT NOT NULL IDENTITY(0,1) PRIMARY KEY, Cargo VARCHAR(60) NOT NULL)";
            SqlCommand command = new SqlCommand(create, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Criado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Erro no DB, contate o administrador.");
            }
            finally
            {
                connection.Dispose();
            }
        }

        public static void Update(Cargo cargo)
        {
            SqlConnection connection = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE Cargo SET Cargo = @Cargo WHERE ID = @Id";
            command.Parameters.AddWithValue("@Cargo", cargo.JobTitle);
            command.Parameters.AddWithValue("@Id", cargo.IdJobTitle);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Erro no DB, contate o administrador.");
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}

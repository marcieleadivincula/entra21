using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aula21
{
    public static class Criar
    {
        public static void CreatePerson()
        {
            SqlConnection connection = new SqlConnection(DBConfig.CONNECTION_STRING);
            string create = "CREATE TABLE Pessoa(Id INT NOT NULL IDENTITY(0,1) PRIMARY KEY, Nome VARCHAR(60) NOT NULL)";
            SqlCommand command = new SqlCommand(create, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void Create()
        {
            SqlConnection connection = new SqlConnection(DBConfig.CONNECTION_STRING);
            string create = "CREATE TABLE Pessoa(Id INT NOT NULL IDENTITY(0,1) PRIMARY KEY, Nome VARCHAR(60) NOT NULL)";
            SqlCommand command = new SqlCommand(create, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void CreateP()
        {
            SqlConnection connection = new SqlConnection(DBConfig.CONNECTION_STRING);
            string create = "CREATE TABLE Pessoa(Id INT NOT NULL IDENTITY(0,1) PRIMARY KEY, Nome VARCHAR(60) NOT NULL)";
            SqlCommand command = new SqlCommand(create, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

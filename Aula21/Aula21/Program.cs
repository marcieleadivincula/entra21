using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();

            ////CREATE TABLE
            //string create = "CREATE TABLE Pessoa(Id INT NOT NULL IDENTITY(0,1) PRIMARY KEY, Nome VARCHAR(60) NOT NULL)";
            //SqlCommand command = new SqlCommand(create, connection);
            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();

            Console.ReadLine();
        }
    }
}

using MySql.Data.MySqlClient;
using System;

namespace Aula29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MySQL");

            MySqlConnection conn = new MySqlConnection(DBConfig.CONNECTION_STRING);

            //MySqlCommand cmd;

            string create = $"CREATE TABLE IF NOT EXISTS cliente(idCliente int not null primary key auto_increment, Nome varchar(60), Idade INT, CPF varchar(20))";
            MySqlCommand cmd = new MySqlCommand(create, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.ReadLine();
        }
    }
}

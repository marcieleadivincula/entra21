using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Aula21;

namespace ExerciciosDeExcecaopt301Exerc04
{
    class Program
    {
        enum Cargo
        {
            desenvolvedor,
            estagiario,
            estudante,
            designer
        }
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();

            //4) Use um enum para criar 4 cargos de emprego,então, peça para o usuario escolher um cargo pelo índice e usando o BD do exercício 1, atualize as pessoas para terem um cargo, os cargos tambem geram um salário(1000, 2500, 3000, 4000 respectivamente)
            //string update = "ALTER TABLE Nome ADD Cargo VARCHAR(60)";
            //command = new SqlCommand(update, connection);
            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("update FINALIZADO");




            Console.WriteLine("Finalizado execução...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Aula21;

namespace ExerciciosDeExcecaopt301Exerc01
{
    enum Nomes
    {
        Joao,
        Carlos,
        SamiraOP,
        Natasha,
        Maria,
        Juca
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1) Crie um programa que armazena 5 nome dentro de um enum e então, peça para o usuario escolher um nome pelo índice dele, então armazene em um BD

            SqlConnection connection = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();

            ////CREATE TABLE
            //string create = "CREATE TABLE Pessoa(Id INT NOT NULL IDENTITY(0,1) PRIMARY KEY, Nome VARCHAR(60) NOT NULL)";
            //SqlCommand command = new SqlCommand(create, connection);
            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine("{0} {1}", j + 1, (Nomes)j);
                    }
                    Console.Write("Insira o nome do elemento: ");
                    int escolha = int.Parse(Console.ReadLine()) - 1;

                    string insert = $"INSERT INTO Pessoa(Nome) VALUES('{Convert.ToString((Nomes)escolha)}')";
                    command = new SqlCommand(insert, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                    Console.WriteLine(f.InnerException);
                    Console.WriteLine("Insira apenas números.");
                    i--;
                }
                catch (SqlException s)
                {
                    Console.WriteLine(s.Message);
                    Console.WriteLine(s.InnerException);
                    Console.WriteLine("ERRO no DB");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.InnerException);
                    Console.WriteLine("**ERRO**");
                    i--;
                }
                finally
                {
                    Console.WriteLine("Execução finalizada com sucesso.");
                    //connection.Close();
                    connection.Dispose();
                }
            }

            Console.ReadLine();
        }
    }
}

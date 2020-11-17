using System;
using System.Data.SqlClient;

namespace ExerciciosDeBDpt201Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Crie uma tabela com 4 colunas (além da id) e peça pro usuario qual o nomeda tabela, cada coluna e qual o tipo (palavra ou numérico)
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            //opção 01
            Console.WriteLine("Qual o nome da tabela?");
            string nomeTabela = Console.ReadLine();
            Console.WriteLine("Qual o nome das 4 colunas?");
            string[] colunas = new string[4];
            for (int i = 0; i < colunas.Length; i++)
            {
                Console.WriteLine("coluna {0}", i + 1);
                colunas[i] = Console.ReadLine();
            }
            Console.WriteLine("qual o tipo?\n1-Palavra\n2-Numero");
            string[] tipos = new string[4];
            for (int i = 0; i < tipos.Length; i++)
            {
                Console.WriteLine("Qual o tipo da {0}° coluna", i + 1);
                tipos[i] = Console.ReadLine();
                if (tipos[i].CompareTo("1") == 0)
                {
                    tipos[i] = "VARCHAR(50) NULL";
                }
                else
                {
                    tipos[i] = "INT NOT NULL";
                }
            }
            string createTable = $"create table {nomeTabela} (id INT NOT NULL IDENTITY(0,1) primary key,{colunas[0]} {tipos[0]},{colunas[1]} {tipos[1]},{colunas[2]} {tipos[2]},{colunas[3]} {tipos[3]})";
            cmd = new SqlCommand(createTable, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            //Opção2
            //Console.WriteLine("Qual o nome da tabela?");
            //string nomeTabela = Console.ReadLine();
            //Console.WriteLine("Qual o nome das 4 colunas?");
            //string[] colunas = new string[4];
            //for (int i = 0; i < colunas.Length; i++)
            //{
            //	Console.WriteLine("coluna {0}", i + 1);
            //	colunas[i] = Console.ReadLine();
            //}
            //Console.WriteLine("qual o tipo?\n1-Palavra\n2-Numero");
            //string[] tipos = new string[4];
            //for (int i = 0; i < tipos.Length; i++)
            //{
            //	Console.WriteLine("Qual o tipo da {0}° coluna", i + 1);
            //	tipos[i] = Console.ReadLine();
            //	if (tipos[i].CompareTo("1") == 0)
            //	{
            //    	tipos[i] = "VARCHAR(50) NULL";
            //	}
            //	else
            //	{
            //    	tipos[i] = "INT NOT NULL";
            //	}
            //}
            //string createTable = $"create table {nomeTabela} (id INT NOT NULL IDENTITY(0,1) primary key)";
            //cmd = new SqlCommand(createTable, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //for (int i = 0; i < colunas.Length; i++)
            //{
            //	string adizionaColunnar = $"alter table {nomeTabela} add {colunas[i]} {tipos[i]}";
            //	cmd = new SqlCommand(adizionaColunnar, conn);
            //	conn.Open();
            //	cmd.ExecuteNonQuery();
            //	conn.Close();
            //}
        }
    }
}

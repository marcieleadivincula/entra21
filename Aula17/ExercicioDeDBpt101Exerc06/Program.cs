using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioDeDBpt101Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            //6) Usando o Banco de Dados do Exercício 4, Delete todos os E-mails que não são @outlook.com ou @outlook.com.br
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            //string delete = "DELETE FROM Contato WHERE Email NOT LIKE '%@outlook.com' AND Email NOT LIKE '%@outlook.com.br'";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            string select = "SELECT * FROM Contato";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Id : {0}", dr["Id"]);
                Console.WriteLine("Email: {0}", dr["Email"]);
                Console.WriteLine("-----------------//------------------");
            }
            conn.Close();

            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}

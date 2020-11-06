using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioDeDBpt101Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Crie um Banco de Dados para armazenar 10 E-mails , Após inserir todos os E-mails Mostre somente aqueles que possuem @outlook.com ou @outlook.com.br
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira o e-mail número: {0}", (i + 1));
                Console.Write("Email: ");
                string email = Console.ReadLine();

                string insert = $"INSERT INTO Contato(Email) values('{email}')";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            string select = "SELECT * FROM Contato WHERE Email LIKE '%@outlook.com' OR Email LIKE '%@outlook.com.br'";
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


            //OPÇÃO 2 para buscar email com @outlook.com e @outlook.com.br
            //select = "SELECT * FROM Emails";
            //cmd = new SqlCommand(select, conn);
            //conn.Open();
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    char[] temp = new char[Convert.ToString(dr["Email"]).Length];

            //    for (int i = 0; i < Convert.ToString(dr["Email"]).Length; i++)
            //    {
            //        if (Convert.ToString(dr["Email"])[i] == '@')
            //        {
            //            string final = "";
            //            Convert.ToString(dr["Email"]).CopyTo(i, temp, 0, Convert.ToString(dr["Email"]).Length - i);

            //            //string final = Convert.ToString(temp);
            //            //string final = temp.ToString();

            //            for (int j = 0; j < temp.Length; j++)
            //            {
            //                //if (Convert.ToString(temp[j]) != null)
            //                //{
            //                //	final += Convert.ToString(temp[j]);
            //                //}
            //                //else
            //                //{
            //                //	break;
            //                //}
            //                final += Convert.ToString(temp[j]);
            //            }

            //            if (final.CompareTo("@outlook.com")  == 0 || final.CompareTo("@outlook.com.br") == 0)
            //            {
            //                Console.WriteLine("Id : {0}", dr["Id"]);
            //                Console.WriteLine("Email: {0}", dr["Email"]);
            //                Console.WriteLine("-----------------//------------------");

            //                // OU
            //                Console.WriteLine(@"email Fofo >\\\< : {0}", dr["Email"]);
            //            }
            //            break;
            //        }
            //    }

            //}
            //conn.Close();
            //Console.WriteLine("Fim do programa...");
            //Console.ReadLine();
        }
    }
}

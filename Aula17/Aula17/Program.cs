using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            //SqlCommand cmd;
            //SqlDataReader dr;

            //string trunc = "TRUNCATE TABLE Cliente";
            //cmd = new SqlCommand(trunc, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //string update = "UPDATE Cliente SET Nome = 'João', Email = 'joao@gmail.com' WHERE Id = 6";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //string delete = "DELETE FROM Cliente WHERE Id = 6";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
        }
    }
}

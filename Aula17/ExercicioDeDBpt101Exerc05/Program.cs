using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioDeDBpt101Exerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Usando o Banco de Dados do Exercício 3, Atualize o Salário de todos os Funcionários que Possuem Menos de 3000 para exatamente 3000.
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            string update = "UPDATE Funcionario SET Salario = 3000 WHERE Salario < 3000";
            cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            string select = "SELECT * FROM Funcionario";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Id : {0}", dr["Id"]);
                Console.WriteLine("Nome do funcionário: {0}", dr["Nome"]);
                Console.WriteLine("Cargo do funcionário: {0}", dr["Cargo"]);
                Console.WriteLine("Salário do funcionário: {0}", dr["Salario"]);
                Console.WriteLine("-----------------//------------------");
            }
            conn.Close();

            Console.ReadLine();
        }
    }
}

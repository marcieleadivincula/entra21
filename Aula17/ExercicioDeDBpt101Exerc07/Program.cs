using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioDeDBpt101Exerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            //7) Baseado no Banco De Dados do Exercício 5, TODOS os Funcionários ganharam um aumento de 25,93 %, caso após o aumento algum funcionário possua mais que 5000 reduza o salário em 5,76 %
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

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

            string update = "UPDATE Funcionario SET Salario = 3000";
            conn.Open();
            cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            select = "SELECT * FROM Funcionario";
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

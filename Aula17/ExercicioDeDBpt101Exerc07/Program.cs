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
            //7) Baseado no Banco De Dados do Exercício 5, TODOS os Funcionários ganharam um aumento de 25,93 % (0,2593), caso após o aumento algum funcionário possua mais que 5000 reduza o salário em 5,76 %
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            string select, update;

            //select = "SELECT * FROM Funcionario";
            //cmd = new SqlCommand(select, conn);
            //conn.Open();
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine("Id : {0}", dr["Id"]);
            //    Console.WriteLine("Nome do funcionário: {0}", dr["Nome"]);
            //    Console.WriteLine("Cargo do funcionário: {0}", dr["Cargo"]);
            //    Console.WriteLine("Salário do funcionário: {0}", dr["Salario"]);
            //    Console.WriteLine("-----------------//------------------");
            //}
            //conn.Close();

            ////Atualiza salário para Salário + 25,93%
            //update = "UPDATE Funcionario SET Salario = Salario * 1.2593";
            //conn.Open();
            //cmd = new SqlCommand(update, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();


            //Console.WriteLine("-----------------//------------------");
            //Console.WriteLine("LISTA DE SALÁRIOS ATUALIZADA");
            //Console.WriteLine("-----------------//------------------");
            ////Seleciona todos os funcionários
            //select = "SELECT * FROM Funcionario";
            //cmd = new SqlCommand(select, conn);
            //conn.Open();
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine("Id : {0}", dr["Id"]);
            //    Console.WriteLine("Nome do funcionário: {0}", dr["Nome"]);
            //    Console.WriteLine("Cargo do funcionário: {0}", dr["Cargo"]);
            //    Console.WriteLine("Salário do funcionário: {0}", dr["Salario"]);
            //    Console.WriteLine("-----------------//------------------");
            //}
            //conn.Close();

            //Seleciona todos os funcionários com salário acima de 5000
            //select = "SELECT * FROM Funcionario WHERE Salario > 5000";
            //cmd = new SqlCommand(select, conn);
            //conn.Open();
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine("Id : {0}", dr["Id"]);
            //    Console.WriteLine("Nome do funcionário: {0}", dr["Nome"]);
            //    Console.WriteLine("Cargo do funcionário: {0}", dr["Cargo"]);
            //    Console.WriteLine("Salário Atual do funcionário: {0}", dr["Salario"]);
            //    Console.WriteLine("-----------------//------------------");
            //}
            //conn.Close();

            //Atualiza salário para Salário - 5,76%
            //update = "UPDATE Funcionario SET Salario = Salario - (Salario * 0.0576)";
            //conn.Open();
            //cmd = new SqlCommand(update, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            Console.WriteLine("-----------------//------------------");
            Console.WriteLine("LISTA ATUALIZADA");
            Console.WriteLine("-----------------//------------------");
            //Seleciona todos os funcionários
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

            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}

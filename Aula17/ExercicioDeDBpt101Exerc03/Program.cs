using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioDeDBpt101Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Crie um Banco de Dados para armazenar 3 Funcionarios de uma empresa, cada Funcionario possui nome,cargo e Salario(INT).Após Inserir todos os Funcionarios mostre apenas aqueles que possuem Salario > 3000
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            string nome, cargo, select;
            int salario;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Insira o funcionário número: {0}", (i + 1));
                Console.Write("Nome do funcionário: ");
                nome = Console.ReadLine();
                Console.Write("Cargo do funcionário: ");
                cargo = Console.ReadLine();
                Console.Write("Salário do funcionário: ");
                salario = int.Parse(Console.ReadLine());

                string insert = $"INSERT INTO Funcionario(Nome, Cargo, Salario) values('{nome}', '{cargo}', {salario})";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            select = "SELECT * FROM Funcionario WHERE Salario > 3000";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioDeDBpt101Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Crie um Banco de Dados para armazenar 3 Cachorros de uma PetShop, cada Cachorro possui nome,nomeDoDono e telefoneDoDono.Após Inserir todos os Cachorros, Mostre esses Cachorros na Tela
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            string nome, nomeDoDono, telefone, select;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Insira o cachorro número: {0}", (i + 1));
                Console.Write("Nome do cão: ");
                nome = Console.ReadLine();
                Console.Write("Nome do dono: ");
                nomeDoDono = Console.ReadLine();
                Console.Write("Telefone do dono: ");
                telefone = Console.ReadLine();

                string insert = $"INSERT INTO Cachorro(Nome, NomeDoDono, TelefoneDoDono) values('{nome}', '{nomeDoDono}', {telefone})";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            Console.WriteLine();

            select = "SELECT * FROM Cachorro";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Id : {0}", dr["Id"]);
                Console.WriteLine("Nome do cão : {0}", dr["Nome"]);
                Console.WriteLine("Nome do dono : {0}", dr["NomeDoDono"]);
                Console.WriteLine("Telefone do dono : {0}", dr["TelefoneDoDono"]);
                Console.WriteLine("-----------------//------------------");
            }

            conn.Close();

            Console.ReadLine();
        }
    }
}

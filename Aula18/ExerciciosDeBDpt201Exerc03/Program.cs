using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ExerciciosDeBDpt201Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Crie uma tabela pedindo pro cliente o que deseja, para isso, começe pedindo o nome da tabela e quantos elementos vai armazenar, após isso, coluna por coluna peça as seguintes informações, o nome da coluna e qual o tipo(palavra ou número)
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ExerciciosDeBDpt201Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Baseado no Exercicio 1 , pergunte se o usuario deseja adicionar mais uma coluna, se sim, peça pro usuario qual o nome e qual o tipo(palavra ou numérico), se nao, encerre o programa
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;


        }
    }
}

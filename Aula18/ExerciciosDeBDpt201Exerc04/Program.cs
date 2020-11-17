using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ExerciciosDeBDpt201Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Baseado no Exercicio 3, pergunte se o usuario deseja adicionar, remover ou alterar uma coluna, peça pro usuario qual o nome e qual o tipo(palavra ou numérico) para adições e alterações, para remover, basta dizer o nome da coluna(nunca permita uma remoção da coluna id)
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
        }
    }
}

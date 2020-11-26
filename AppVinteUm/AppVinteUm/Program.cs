using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppVinteUm
{
    class Program
    {
        static void Main(string[] args)
        {

            FuncaoMenu.Menu();

            Console.WriteLine("Execução finalizada...");
            Console.WriteLine("Tecle ENTER para sair.");
            Console.ReadLine();
        }
    }
}

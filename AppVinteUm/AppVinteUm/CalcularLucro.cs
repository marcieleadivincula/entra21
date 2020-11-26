using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public static class CalcularLucro
    {
        public static void CalculaLucro()
        {
            double ganho, prejuizo;
            bool repeat = false;

            ClienteDAL clientedal = new ClienteDAL();
            FuncionarioDAL funcionariodal = new FuncionarioDAL();
            FornecedorDAL fornecedordal = new FornecedorDAL();
            SocioDAL sociodal = new SocioDAL();

            Console.WriteLine("Saldo total do cliente NORMAL");
            clientedal.getBySumSaldo();
            Console.WriteLine("Saldo total do cliente SÓCIO");
            sociodal.getBySumSaldo();
            Console.WriteLine("Quantidade total fornecida ao mês");
            fornecedordal.getBySumQtdProdutos();
            Console.WriteLine("Saldo total do FUNCIONÁRIO");
            funcionariodal.getBySumSaldo();
        }
    }
}

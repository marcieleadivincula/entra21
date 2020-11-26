using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    class GeraOutrosDados
    {
        private static Random ran = new Random();

        //Gera int TipoCliente, sendo 1 para NORMAL e 2 para SÓCIO e 0 para indefinido
        public static string TipoClienteNormal()
        {
            int escolha = ran.Next(1, 2);
            string tipoCliente;

            switch (escolha)
            {
                case 1:
                    tipoCliente = "Nomal";
                    break;
                default:
                    tipoCliente = "";
                    break;
            }

            return tipoCliente;
        }

        public static string TipoClienteSocio()
        {
            int escolha = ran.Next(1, 2);
            string tipoCliente;

            switch (escolha)
            {
                case 1:
                    tipoCliente = "Sócio";
                    break;
                default:
                    tipoCliente = "";
                    break;
            }

            return tipoCliente;
        }

        //Gera string Cargo
        public static string Cargo()
        {
            int escolha = ran.Next(1, 21);
            string cargo;

            switch (escolha)
            {
                case 1:
                    cargo = "Desenvolvedor Júnior";
                    break;
                case 2:
                    cargo = "Estagiário";
                    break;
                case 3:
                    cargo = "Desenvolvedor Pleno";
                    break;
                case 4:
                    cargo = "Diretor";
                    break;
                case 5:
                    cargo = "Gerente";
                    break;
                case 6:
                    cargo = "Tech Líder";
                    break;
                case 7:
                    cargo = "Scrum Master";
                    break;
                case 8:
                    cargo = "BA";
                    break;
                case 9:
                    cargo = "PO";
                    break;
                case 10:
                    cargo = "CTO";
                    break;
                case 11:
                    cargo = "CEO";
                    break;
                case 12:
                    cargo = "Desenvolvedor Mobile";
                    break;
                case 13:
                    cargo = "Desenvolvedor C#";
                    break;
                case 14:
                    cargo = "Desenvolvedor Java";
                    break;
                case 15:
                    cargo = "Desenvolvedor Android";
                    break;
                case 16:
                    cargo = "Desenvolvedor Frontend";
                    break;
                case 17:
                    cargo = "Desenvolvedor Backend";
                    break;
                case 18:
                    cargo = "Desenvolvedor Full Stack";
                    break;
                case 19:
                    cargo = "Desenvolvedor iOS";
                    break;
                case 20:
                    cargo = "Desenvolvedor Sênior";
                    break;
                default:
                    cargo = "";
                    break;
            }
            return cargo;
        }

        // Gera um Tipo de Produto de 1 a 6
        //O tipoDeProduto gera um custo para loja, o custo é dado na tabela abaixo
        public static int TipoProduto()
        {
            int tipoProduto = ran.Next(1, 7);
            double valorProduto;

            switch (tipoProduto)
            {
                case 1:
                    valorProduto = 5.45;
                    break;
                case 2:
                    valorProduto = 6.78;
                    break;
                case 3:
                    valorProduto = 1.43;
                    break;
                case 4:
                    valorProduto = 2.68;
                    break;
                case 5:
                    valorProduto = 3.78;
                    break;
                case 6:
                    valorProduto = 2.96;
                    break;
                default:
                    valorProduto = 0.0;
                    break;
            }

            return (int)valorProduto;
        }

        // Gera um quantidade fornecida ao mês de 1 a 6
        public static int QuantidadeFornecidaAoMes()
        {
            double qtdFornecidaAoMes = ran.Next(200, 2000) + ran.NextDouble();
            return (int)qtdFornecidaAoMes;
        }

        // Gera um QtdAcoes de 1 a 10 (clientes) de até no máximo de 4.95% das ações
        public static float QtdAcoes()
        {
            double qtdAcoes = ran.Next(1, 10);
            return (int)qtdAcoes;
        }

        // Gera um cnpj no padrao 00.000.000/0000-00
        //Exemplo: CNPJ: 42.318.949/0001-84
        public static string Cnpj()
        {
            string cnpj = "";
            for (int i = 0; i < 18; i++)
            {
                if (i % 4 == 0)
                {
                    if (i == 15)
                    {
                        cnpj += "-";
                    }
                }
                else
                {
                    cnpj += ran.Next(0, 10);
                }
            }
            return cnpj;
        }

        // Gera um saldo aleatório por hora
        public static double SalarioPorHora()
        {
            //double valorHora = ran.Next(0, 5);
            //double valorDiario = ran.Next(5, 35);
            //double valorMensal = ran.Next(151, 1046);

            double saldoPorHora = ran.Next(1, 6) + ran.NextDouble();
            return saldoPorHora;
        }

    }
}

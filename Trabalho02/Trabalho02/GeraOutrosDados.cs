using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho02
{
    static class GeraOutrosDados
    {
        private static Random ran = new Random();

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
            int escolha = ran.Next(1, 6);
            double tipoProduto;

            switch (escolha)
            {
                case 1:
                    tipoProduto = 5.45;
                    break;
                case 2:
                    tipoProduto = 6.78;
                    break;
                case 3:
                    tipoProduto = 1.43;
                    break;
                case 4:
                    tipoProduto = 2.68;
                    break;
                case 5:
                    tipoProduto = 3.78;
                    break;
                case 6:
                    tipoProduto = 2.96;
                    break;
                default:
                    tipoProduto = 0.0;
                    break;
            }

            return (int)tipoProduto;
        }

        // Gera um quantidade fornecida ao mês de 1 a 6
        public static int QuantidadeFornecidaAoMes()
        {
            return ran.Next(1, 6);
        }

        // Gera um QtdAcoes de 1 a 10
        public static double QtdAcoes()
        {
            return ran.Next(1, 10);
        }

        // Gera um cnpj no padrao 00.000.000/0000-00
        //Exemplo: CNPJ: 42.318.949/0001-84
        public static string Cnpj()
        {
            string cnpj = "";
            for (int i = 1; i < 18; i++)
            {
                if (i % 4 == 0)
                {
                    if (i == 9)
                    {
                        cnpj += "/";
                    }
                    else if (i == 14)
                    {
                        cnpj += "-";
                    }
                    else
                    {
                        cnpj += ".";
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
            double valorHora = ran.Next(0, 5);
            double valorDiario = ran.Next(5, 35);
            double valorMensal = ran.Next(151, 1046);

            double saldoPorHora = ran.Next(200, 2000) + ran.NextDouble();
            return saldoPorHora;
        }
    }
}

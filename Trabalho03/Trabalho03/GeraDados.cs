using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho03
{
    public static class GeraDados
    {
        private static Random ran = new Random();
        public static void ColunaA()
        {
            int escolha = ran.Next(1, 2);
            string letra;

            switch (escolha)
            {
                case 1:
                    letra = "A";
                    break;
                case 2:
                    letra = "B";
                    break;
                default:
                    letra = "";
                    break;
            }
        }

        public static void ColunaB()
        {
            int escolha = ran.Next(1, 2);
            string letra;

            switch (escolha)
            {
                case 1:
                    letra = "A";
                    break;
                case 2:
                    letra = "B";
                    break;
                default:
                    letra = "";
                    break;
            }
        }

        public static void ColunaC()
        {
            int escolha = ran.Next(1, 2);
            string letra;

            switch (escolha)
            {
                case 1:
                    letra = "A";
                    break;
                case 2:
                    letra = "B";
                    break;
                default:
                    letra = "";
                    break;
            }
        }
    }
}

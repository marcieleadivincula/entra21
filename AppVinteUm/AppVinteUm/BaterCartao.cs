using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public static class BaterCartao
    {
        public static void BaterPonto()
        {
            bool repeat = false;
            string cpf;
            int diaOuMes, hrEntrada, hrSaida;

            FuncionarioDAL funcionariodal = new FuncionarioDAL();

            while (repeat == false)
            {
                Console.WriteLine("Lista de todos os funcionários: ");
                funcionariodal.getAll();
                Console.WriteLine("-------------------------------//-----------------------");
                Console.WriteLine("Qual funcionário está  batendo cartão? ");
                Console.Write("Digite o CPF: ");
                cpf = Console.ReadLine();

                //, peça se esta batendo o cartao do dia ou de 30 dias, caso for do dia, *peça qual a hora de entrada e qual a hora de saida*
                if (!string.IsNullOrWhiteSpace(cpf))
                {
                    Console.WriteLine("Está batendo o cartão do dia ou de 30 dias? \nDigite: \n1 - Dia \n2 - Mês(30 dias)");
                    Console.Write("Digite uma opção: ");
                    diaOuMes = int.Parse(Console.ReadLine());

                    if (diaOuMes == 1)
                    {
                        Console.WriteLine("Qual a hora de entrada?");
                        hrEntrada = int.Parse(Console.ReadLine());


                        Console.WriteLine("Qual a hora de saída?");
                        hrSaida = int.Parse(Console.ReadLine());


                    }
                    else
                    {
                        // * 30 dias
                    }

                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public static class ComprarItem
    {
        public static void Comprar()
        {
            int userChoice;
            string cpf;
            bool repeat = false;

            ClienteDAL clientedal = new ClienteDAL();
            SocioDAL sociodal = new SocioDAL();

            double quantidade, resultado, desconto;
            Console.Clear();
            Console.WriteLine("Qual cliente está comprando?");
            Console.Write("Menu principal: \n1 - Cliente Normal \n2 - Cliente Sócio \n3 - Sair \n");
            Console.WriteLine();
            Console.Write("Escolha uma opção:");
            userChoice = int.Parse(Console.ReadLine());

            while (repeat == false)
            {
                if (userChoice == 1)
                {
                    Cliente cliente = new Cliente();
                    Console.WriteLine("-------------------------------//-----------------------");
                    Console.WriteLine("Listando clientes normais: ");
                    clientedal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
                    Console.WriteLine("-------------------------------//-----------------------");

                    Console.WriteLine("Qual cliente está comprando? ");
                    Console.Write("Digite o CPF: ");
                    cpf = Console.ReadLine();

                    cliente = clientedal.getByCpf(cpf);

                    Console.Write("Quanto está comprando? ");
                    quantidade = int.Parse(Console.ReadLine());
                    //cliente = clientedal.getBySaldo(quantidade);

                    if (quantidade > 0)
                    {
                        clientedal.update(cliente); //ver como se comporta, se atualiza um apenas ou tudo
                    }
                    else
                    {
                        break;
                    }

                    repeat = true;
                }
                else if (userChoice == 2)
                {
                    Socio socio = new Socio();
                    Console.WriteLine("Listando clientes sócios: ");
                    sociodal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
                    Console.WriteLine("-------------------------------//-----------------------");

                    Console.WriteLine("Qual cliente está comprando? ");
                    Console.Write("Digite o CPF: ");
                    cpf = Console.ReadLine();

                    socio = sociodal.getByCpf(cpf);

                    if (string.IsNullOrWhiteSpace(cpf))
                    {
                        Console.Write("Quanto está comprando? ");
                        quantidade = int.Parse(Console.ReadLine());

                        desconto = quantidade * 0.20;
                        resultado = quantidade - desconto;

                        if (resultado > 0)
                        {
                            sociodal.update(socio);  //ver como se comporta, se atualiza um apenas ou tudo
                        }
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

using System;

namespace ExerciciosOOpt102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 2");

            //1
            //Cliente[] cliente = new Cliente[4];

            //for (int i = 0; i < cliente.Length; i++)
            //{
            //    Console.WriteLine("Insira o nome, CPF e VIP do {0}° cliente", (i + 1));
            //    cliente[i] = new Cliente();

            //    Console.Write("Digite o nome do cliente: ");
            //    cliente[i].nome = Console.In.ReadLine();
            //    Console.Write("Digite o CPF do cliente: ");
            //    cliente[i].cpf = Console.In.ReadLine();
            //    Console.Write("Digite v para vip ou n para não: ");
            //    cliente[i].vip = Convert.ToChar(Console.In.ReadLine());
            //}

            //if (cliente[0].vip == 'v')
            //{
            //    cliente[0].nome = cliente[0].nome + "#_#";
            //}

            //for (int i = 0; i < cliente.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (cliente[j - 1].vip < cliente[j].vip)
            //        {
            //            cliente[j].nome = cliente[j].nome + "#_#";
            //            Cliente temp = new Cliente();
            //            cliente[j] = cliente[j - 1];
            //            cliente[j - 1] = temp;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}

            //for (int i = 0; i < cliente.Length; i++)
            //{
            //    if (cliente[i].vip == 'v')
            //    {
            //        Console.WriteLine("{0} {1}", cliente[i].nome + "#_#", cliente[i].cpf);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} {1}", cliente[i].nome, cliente[i].cpf);
            //    }
            //}

            //2
            //Estacionamento[] estacionamento = new Estacionamento[5];

            //for (int i = 0; i < estacionamento.Length; i++)
            //{
            //    Console.WriteLine("Insira o nome do dono e a placa do {0}° carro", (i+1));
            //    estacionamento[i] = new Estacionamento();

            //    Console.Write("Nome do dono: ");
            //    estacionamento[i].nomeDono = Console.In.ReadLine();
            //    Console.Write("Placa do carro: ");
            //    estacionamento[i].placaCarro = Console.In.ReadLine();
            //}

            //for (int i = 0; i < estacionamento.Length; i++)
            //{
            //    if (estacionamento[i].nomeDono != "")
            //    {
            //        Console.WriteLine("{0} {1}", estacionamento[i].nomeDono, estacionamento[i].placaCarro);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} {1}", estacionamento[i].nomeDono ,estacionamento[i].placaCarro);
            //    }
            //}

            //3
            //Hotel[] hotel = new Hotel[5];

            //for (int i = 0; i < hotel.Length; i++)
            //{
            //    hotel[i] = new Hotel();
            //    Console.WriteLine("Insira o nome e o número de quartos: ");

            //    Console.Write("Nome: ");
            //    hotel[i].nome = Console.In.ReadLine();
            //    Console.Write("Quantidade de quartos de solteiro: ");
            //    hotel[i].qtdSolteiro = Convert.ToInt32(Console.In.ReadLine());
            //    Console.Write("Quantidade de quartos de casal: ");
            //    hotel[i].qtdCasal = Convert.ToInt32(Console.In.ReadLine());
            //}

            //for (int i = 0; i < hotel.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if ((hotel[j-1].qtdCasal * 2) + (hotel[j - 1].qtdSolteiro) < (hotel[j].qtdCasal * 2) + (hotel[j].qtdSolteiro))
            //        {
            //            Hotel ht = hotel[j];
            //            hotel[j - 1] = hotel[j-1];
            //            hotel[j - 1] = ht;
            //        }
            //    }
            //}

            //for (int i = 0; i < hotel.Length; i++)
            //{
            //    Console.WriteLine("{0} {1} {2}", hotel[i].nome, hotel[i].qtdSolteiro, hotel[i].qtdCasal);
            //}

            //4
            Pessoa[] pes = new Pessoa[10];

            for (int i = 0; i < pes.Length; i++)
            {
                Console.WriteLine("Insira a {0}° pessoa", (i + 1));
                pes[i] = new Pessoa();
                Console.Write("Nome: ");
                pes[i].nome = Console.In.ReadLine();
                Console.Write("Idade: ");
                pes[i].idade = Convert.ToInt32(Console.In.ReadLine());
            }

            //&& EhAdult() == "true"
            for (int i = 0; i < pes.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (pes[j - 1].idade < pes[j].idade)
                    {
                        Pessoa temp = pes[j - 1];
                        pes[j - 1] = pes[j];
                        pes[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < pes.Length; i++)
            {
                if (pes[i].EhAdult() == true)
                {
                    Console.WriteLine("{0} {1}", pes[i].nome, pes[i].idade);
                }
            }
        }
    }
}

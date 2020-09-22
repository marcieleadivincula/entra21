using System;

namespace ExerciciosOOpt102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1.02");

            //1 Crie 4 clientes com nome,cpf e VIP. Peça para o usuario preencher os clientes, em seguida, mostre todos os clientes começando pelos VIP’s e com um selo(qualque símbolo serve).
            Cliente[] clientes = new Cliente[4];

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Insira o nome, CPF e VIP do {0}° cliente", (i + 1));

                Console.Write("Digite o nome do cliente: ");
                string nome = Console.In.ReadLine();
                Console.Write("Digite o CPF do cliente: ");
                string cpf = Console.In.ReadLine();
                Console.Write("Digite v para vip ou n para não: ");
                char vip = Convert.ToChar(Console.In.ReadLine());

                clientes[i] = new Cliente(nome, cpf, vip);
            }

            if (clientes[0].GetVip() == 'v')
            {
                clientes[0].GetNome() = clientes[0].GetNome() + "#_#";
            }

            for (int i = 0; i < clientes.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (clientes[j - 1].GetVip() < clientes[j].GetVip())
                    {
                        clientes[j].GetNome() = clientes[j].GetNome() + "#_#";
                        Cliente temp = new Cliente();
                        clientes[j] = clientes[j - 1];
                        clientes[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].GetVip() == 'v')
                {
                    Console.WriteLine("{0} {1}", clientes[i].GetNome() + "#_#", clientes[i].GetCpf());
                }
                else
                {
                    Console.WriteLine("{0} {1}", clientes[i].GetNome(), clientes[i].GetCpf());
                }
            }

            //2 ) Crie 5 vagas de estacionamento com placa do veículo e nome do dono. Peça para o usuário preencher as vagas(pode-se deixar vazio), em seguida, mostre todas as vagas preenchidas.
            //Estacionamento[] estacionamento = new Estacionamento[5];

            //for (int i = 0; i < estacionamento.Length; i++)
            //{
            //    Console.WriteLine("Insira o nome do dono e a placa do {0}° carro", (i + 1));

            //    Console.Write("Nome do dono: ");
            //    string nomeDono = Console.In.ReadLine();
            //    Console.Write("Placa do carro: ");
            //    string placaCarro = Console.In.ReadLine();

            //    estacionamento[i] = new Estacionamento(nomeDono, placaCarro);
            //}

            //for (int i = 0; i < estacionamento.Length; i++)
            //{
            //    if (estacionamento[i].GetNomeDono() != "")
            //    {
            //        Console.WriteLine("{0} {1}", estacionamento[i].GetNomeDono(), estacionamento[i].GetPlacaCarro());
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} {1}", estacionamento[i].GetNomeDono(), estacionamento[i].GetPlacaCarro());
            //    }
            //}

            //3 Crie 5 hotéis com nome,quantidade de quartos de solteiro e quantidade de quartos de casal e peça para o usuário preencher os hotéis, após isso, mostre na tela do hotel com mais vaga disponível para o com menos vaga disponível
            //OBS: Considere que os hotéis estão vazios, Cada quarto de casal representa duas vagas e o quarto de solteiro uma vaga.

            //Hotel[] hotel = new Hotel[5];

            //for (int i = 0; i < hotel.Length; i++)
            //{
            //    Console.WriteLine("Insira o nome e o número de quartos: ");

            //    Console.Write("Nome: ");
            //   string nome = Console.In.ReadLine();
            //    Console.Write("Quantidade de quartos de solteiro: ");
            //   int qtdSolteiro = Convert.ToInt32(Console.In.ReadLine());
            //    Console.Write("Quantidade de quartos de casal: ");
            //   int qtdCasal = Convert.ToInt32(Console.In.ReadLine());

            //    hotel[i] = new Hotel(nome, qtdSolteiro, qtdCasal);
            //}

            //for (int i = 0; i < hotel.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if ((hotel[j - 1].MultiplicaQtdCasal()) + (hotel[j - 1].GetQtdSolteiro()) < (hotel[j].MultiplicaQtdCasal()) + (hotel[j].GetQtdSolteiro()))
            //        {
            //            Hotel ht = hotel[j];
            //            hotel[j - 1] = hotel[j - 1];
            //            hotel[j - 1] = ht;
            //        }
            //    }
            //}

            //for (int i = 0; i < hotel.Length; i++)
            //{
            //    Console.WriteLine("{0} {1} {2}", hotel[i].GetNome(), hotel[i].GetQtdSolteiro(), hotel[i].GetQtdCasal());
            //}

            //4 Crie 10 pessoas com nome,idade e uma função que retorna verdadeiro caso a pessoa seja adulta. Peça para o usuário preencher todas as pessoas, em seguida, mostre em ordem do mais velho para o mais novo apenas aqueles que são adultos
            //ps: deve - se usar o retorno da função para avalaiar se é adulto ou não
            //Pessoa[] pes = new Pessoa[10];

            //for (int i = 0; i < pes.Length; i++)
            //{
            //    Console.WriteLine("Insira a {0}° pessoa", (i + 1));
            //    Console.Write("Nome: ");
            //    string nome = Console.In.ReadLine();
            //    Console.Write("Idade: ");
            //    int idade = Convert.ToInt32(Console.In.ReadLine());

            //    pes[i] = new Pessoa(nome, idade);
            //    Console.WriteLine();
            //}

            ////&& EhAdult() == "true"
            //for (int i = 0; i < pes.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (pes[j - 1].GetIdade() < pes[j].GetIdade())
            //        {
            //            Pessoa temp = pes[j - 1];
            //            pes[j - 1] = pes[j];
            //            pes[j] = temp;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}

            //for (int i = 0; i < pes.Length; i++)
            //{
            //    if (pes[i].EhAdult() == true)
            //    {
            //        Console.WriteLine("Nome: {0}, Idade: {1}", pes[i].GetNome(), pes[i].GetIdade());
            //    }
            //}
        }
    }
}

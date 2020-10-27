using System;
using System.Collections.Generic;
using System.Threading;

namespace ExerciciosDeVAOpt101Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - Variáveis Avançadas");
            //4) A proway esta criando um sistema de login, para isso, crie 1 Lista de Conta com 5 posições, por padrão, tem a senha do administrador que é : user: Admin   pas-sword: @proway , caso um usuario faça login, avise que o login foi efetuado com sucesso e em seguida faça “logout” (volta pro inicio onde pede user e password) ca-so o login foi feito pelo administrador, apareça as seguintes opções:
            //1 - Criar User: para criar, mostre os users atuais, peça ao usuário qual espaço do array ele deseja armazenar um novo user e password, em seguida peça o user e password a ser armazenado.
            //2 - Deletar User: para deletar, mostre os users atuais, em seguida, peça qual user deseja - se deletar, após isso, delete o user
            //3 - LogOut : volte para o inicio onde pede user e password

            //PS:Conta Possui Login e senha.
            List<Conta> contas = new List<Conta>();

            contas.Add(new Conta("Admin", "@proway"));
            contas.Add(new Conta("Joeslei", ""));
            contas.Add(new Conta("SuperXandão", "CacadorDeDemonios"));
            contas.Add(new Conta("Pedro", "Petigru"));
            contas.Add(new Conta("Coringa", "SomAutomotivo"));

            Console.WriteLine("Tela de Login: ");
            do
            {
                bool userAchado = false;
                bool senhaAchado = false;
                Console.Write("Insira seu login ou 0(zero) para terminar ");
                string escolha = Console.ReadLine();

                if (escolha == "0")
                {
                    break;
                }
                else
                {
                    foreach (var item in contas)
                    {
                        if (item.Login == escolha)
                        {
                            userAchado = true;
                            senhaAchado = true;

                            Console.Write("Insira sua senha: ");
                            escolha = Console.ReadLine();

                            if (item.Senha == escolha)
                            {
                                bool fim = false;
                                if (item.Login == "Admin")
                                {
                                    do
                                    {
                                        Console.WriteLine("***_MENU_***");
                                        Console.WriteLine("1 - Criar Login");
                                        Console.WriteLine("2 - Deletar Login");
                                        Console.WriteLine("3 - Logout");

                                        int choose = int.Parse(Console.ReadLine());

                                        switch (choose)
                                        {
                                            case 1:
                                                MostraLista(contas);

                                                Console.WriteLine("Em qual vaga irá inserir?");
                                                choose = int.Parse(Console.ReadLine());

                                                Console.WriteLine("Insira as informações do novo usuário:");
                                                string login, senha;

                                                Console.Write("Insira seu login: ");
                                                login = Console.ReadLine();
                                                Console.Write("Insira sua senha: ");
                                                senha = Console.ReadLine();

                                                //contas.Add(new Conta(login, senha));
                                                //contas.Insert(choose, new Conta(login, senha));
                                                contas[choose] = new Conta(login, senha);

                                                Console.WriteLine("Criando login");
                                                Thread.Sleep(1500);
                                                Console.Clear();

                                                break;
                                            case 2:
                                                MostraLista(contas);

                                                Console.WriteLine("Quem você deseja excluir?");
                                                choose = int.Parse(Console.ReadLine());

                                                //contas.Insert(choose, new Conta());
                                                contas[choose] = new Conta();

                                                Console.WriteLine("Removendo usuário");
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                                break;
                                            case 3:
                                                fim = true;
                                                break;
                                            default:
                                                Console.WriteLine("Opção inválida, voltando ao MENU!");
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                                break;
                                        }
                                    } while (fim == false);

                                    if (fim == true)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if (userAchado == false)
                    {
                        Console.WriteLine("Login incorreto!");
                    }
                    else if (senhaAchado == false)
                    {
                        Console.WriteLine("Senha incorreta!");
                    }
                }
            } while (true);

            Console.WriteLine("Programa encerrado com sucesso!");
        }

        public static void MostraLista(List<Conta> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Login);
                Console.WriteLine(item.Senha);
                Console.WriteLine("==============================");
            }
        }

        //foreach (var item1 in contas)
        //{
        //    if (item1.Senha == escolha)
        //    {

        //    }
        //}
    }
}

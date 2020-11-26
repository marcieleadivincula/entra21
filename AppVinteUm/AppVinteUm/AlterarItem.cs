using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public static class AlterarItem
    {
        public static void Alterar()
        {
            int idade, tipoProduto, qtdFornecidaAoMes, userChoice, idOrCpf, id;
            string cpf, nome, nomeEmpresa, cargo, tipoCliente, cnpj, cpfOrCnpj;
            double saldo, qtdAcoes, salarioPorHora;
            bool repeat = false;

            ClienteDAL clientedal = new ClienteDAL();
            FuncionarioDAL funcionariodal = new FuncionarioDAL();
            FornecedorDAL fornecedordal = new FornecedorDAL();
            SocioDAL sociodal = new SocioDAL();

            Cliente cliente = new Cliente();
            Socio socio = new Socio();
            Funcionario funcionario = new Funcionario();
            Fornecedor fornecedor = new Fornecedor();

            Console.Clear();
            Console.WriteLine("O que será alterado?");
            Console.Write("Menu principal: \n1 - Cliente Normal \n2 - Cliente Sócio \n3 - Funcionário  \n4 - Fornecedor \n5 - Sair \n");
            Console.WriteLine();
            Console.Write("Escolha uma opção:");
            userChoice = int.Parse(Console.ReadLine());

            while (repeat == false)
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("Quer alterar cliente por ID ou CPF? \n1 - ID \n2 - CPF \nEscolha uma opção: ");
                    idOrCpf = int.Parse(Console.ReadLine());

                    if (idOrCpf == 1)
                    {
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista de todos os clientes normais: ");
                        clientedal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual será alterado? ");
                        Console.Write("Digite o ID: ");
                        id = int.Parse(Console.ReadLine());

                        //cliente = clientedal.getById(id);

                        Console.WriteLine("Dados a serem alterados: ");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("CPF: ");
                        cpf = Console.ReadLine();
                        Console.Write("Idade: ");
                        idade = int.Parse(Console.ReadLine());
                        Console.Write("Saldo: ");
                        saldo = double.Parse(Console.ReadLine());
                        Console.Write("TipoCliente: ");
                        tipoCliente = Console.ReadLine();

                        cliente = new Cliente(nome, cpf, idade, saldo, tipoCliente);

                        try
                        {
                            clientedal.update(cliente);
                            cliente = clientedal.getLastRegister();
                        }
                        catch (Exception)
                        {
                            clientedal.delete(cliente);
                            Console.WriteLine("ERRO ao tentar atualizar este cliente.");
                        }
                        finally
                        {
                            clientedal.getById(id);
                            Console.WriteLine("Atualização terminada.");
                        }
                    }
                    else
                    {
                        clientedal = new ClienteDAL();
                        Console.WriteLine("Lista de todos os clientes normais: ");
                        clientedal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
                        Console.WriteLine("-------------------------------//-----------------------");

                        Console.WriteLine("Qual será alterado? ");
                        Console.Write("Digite o CPF: ");
                        cpfOrCnpj = Console.ReadLine();

                        clientedal.getByCpf(cpfOrCnpj);

                        Console.WriteLine("Dados a serem alterados: ");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("CPF: ");
                        cpf = Console.ReadLine();
                        Console.Write("Idade: ");
                        idade = int.Parse(Console.ReadLine());
                        Console.Write("Saldo: ");
                        saldo = double.Parse(Console.ReadLine());
                        Console.Write("TipoCliente: ");
                        tipoCliente = Console.ReadLine();

                        cliente = new Cliente(nome, cpf, idade, saldo, tipoCliente);

                        try
                        {
                            clientedal.update(cliente);
                        }
                        catch (Exception)
                        {
                            clientedal.delete(cliente);
                            Console.WriteLine("ERRO ao tentar atualizar este cliente.");
                        }
                        finally
                        {
                            clientedal.getByCpf(cpfOrCnpj);
                            Console.WriteLine("Atualização terminada.");
                        }

                    }

                    repeat = true;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Listando clientes sócios: ");
                    sociodal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
                    Console.WriteLine("-------------------------------//-----------------------");

                    Console.WriteLine("Qual será alterado? ");
                    Console.Write("Digite o CPF: ");
                    cpfOrCnpj = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(cpfOrCnpj))
                    {
                        sociodal = new SocioDAL();
                        sociodal.getByCpf(cpfOrCnpj);

                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("CPF: ");
                        cpf = Console.ReadLine();
                        Console.Write("Idade: ");
                        idade = int.Parse(Console.ReadLine());
                        Console.Write("Saldo: ");
                        saldo = double.Parse(Console.ReadLine());
                        Console.Write("TipoCliente: ");
                        tipoCliente = Console.ReadLine();
                        Console.Write("Quantidade de Ações: ");
                        qtdAcoes = double.Parse(Console.ReadLine());

                        try
                        {
                            sociodal.update(new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente));
                        }
                        catch (Exception)
                        {
                            sociodal.delete(new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente));
                            Console.WriteLine("ERRO ao tentar atualizar este cliente.");
                        }
                        finally
                        {
                            sociodal.getByCpf(cpfOrCnpj);
                            Console.WriteLine("Atualização terminada.");
                        }
                    }

                    repeat = true;
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Listando funcionários: ");
                    funcionariodal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
                    Console.WriteLine("-------------------------------//-----------------------");

                    Console.WriteLine("Qual será alterado? ");
                    Console.Write("Digite o CPF: ");
                    cpfOrCnpj = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(cpfOrCnpj))
                    {
                        funcionariodal = new FuncionarioDAL();
                        funcionariodal.getByCpf(cpfOrCnpj);

                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("CPF: ");
                        cpf = Console.ReadLine();
                        Console.Write("Idade: ");
                        idade = int.Parse(Console.ReadLine());
                        Console.Write("Salário por Hora: ");
                        salarioPorHora = double.Parse(Console.ReadLine());
                        Console.Write("Cargo: ");
                        cargo = Console.ReadLine();
                        Console.Write("Saldo: ");
                        saldo = double.Parse(Console.ReadLine());

                        try
                        {
                            funcionariodal.update(new Funcionario(nome, cpf, idade, salarioPorHora, cargo, saldo));
                        }
                        catch (Exception)
                        {
                            funcionariodal.delete(new Funcionario(nome, cpf, idade, salarioPorHora, cargo, saldo));
                            Console.WriteLine("ERRO ao tentar atualizar este funcionário.");
                        }
                        finally
                        {
                            funcionariodal.getByCpf(cpfOrCnpj);
                            Console.WriteLine("Atualização terminada.");
                        }
                    }

                    repeat = true;
                }
                else if (userChoice == 4)
                {
                    fornecedordal = new FornecedorDAL();
                    Console.WriteLine("Listando fornecedores: ");
                    fornecedordal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
                    Console.WriteLine("-------------------------------//-----------------------");

                    Console.WriteLine("Qual será alterado? ");
                    Console.Write("Digite o CNPJ: ");
                    cpfOrCnpj = Console.ReadLine();

                    fornecedor = fornecedordal.getByCnpj(cpfOrCnpj);

                    if (fornecedor.CNPJ == cpfOrCnpj)
                    {
                        Console.WriteLine("Insira os novos dados: ");
                        Console.Write("Nome da Empresa: ");
                        nomeEmpresa = Console.ReadLine();
                        Console.Write("Tipo de Produto: ");
                        tipoProduto = int.Parse(Console.ReadLine());
                        Console.Write("Quantidade Fornecida ao Mês: ");
                        qtdFornecidaAoMes = int.Parse(Console.ReadLine());
                        Console.Write("CNPJ: ");
                        cnpj = Console.ReadLine();

                        fornecedor = new Fornecedor(nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes);

                        try
                        {
                            fornecedordal.update(fornecedor);
                        }
                        catch (Exception)
                        {
                            fornecedordal.delete(fornecedor);
                            Console.WriteLine("ERRO ao tentar atualizar este fornecedor.");
                        }
                        finally
                        {
                            fornecedordal.getLastRegister();
                            Console.WriteLine("Atualização terminada.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("CNPJ inválido, tente novamente.");
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

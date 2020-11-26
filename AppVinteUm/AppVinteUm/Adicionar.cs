using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public static class Adicionar
    {
        public static void AdicionarItem()
        {
            int idade, tipoProduto, qtdFornecidaAoMes, userChoice, createOrInsert, qtdCreates;
            string cpf, nome, nomeEmpresa, cargo, tipoCliente, cnpj;
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
            Console.WriteLine("Menu principal");
            Console.Write("Quem deseja adicionar? \n1 - Cliente Normal \n2 - Cliente Sócio \n3 - Funcionário  \n4 - Fornecedor \n5 - Sair \n ");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");
            userChoice = int.Parse(Console.ReadLine());

            while (repeat == false)
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("Quer geradar dados do cliente ou inserir dados? \n1 - Inserir dados \n2 - Gerar dados \nEscolha uma opção: ");
                    createOrInsert = int.Parse(Console.ReadLine());

                    if (createOrInsert == 1)
                    {
                        Console.WriteLine("Quantos clientes quer inserir? \nInsira um número:");
                        qtdCreates = int.Parse(Console.ReadLine());

                        for (int i = 0; i < qtdCreates; i++)
                        {
                            clientedal = new ClienteDAL();

                            Console.WriteLine("Dados a serem inseridos: ");
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
                                clientedal.insert(cliente);
                            }
                            catch (Exception)
                            {
                                clientedal.delete(cliente);
                                Console.WriteLine("ERRO ao tentar inserir este cliente.");
                            }
                            finally
                            {
                                clientedal.getLastRegister();
                                Console.WriteLine("Inserção concluída com sucesso.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quantos clientes quer gerar? \nInsira um número:");
                        qtdCreates = int.Parse(Console.ReadLine());

                        Console.WriteLine("Inserindo dados do cliente.");
                        for (int i = 0; i < qtdCreates; i++)
                        {
                            clientedal = new ClienteDAL();

                            idade = Gerador.Idade();
                            cpf = Gerador.Cpf();
                            nome = Gerador.NomePessoa();
                            saldo = Gerador.Saldo();
                            tipoCliente = GeraOutrosDados.TipoClienteNormal();

                            cliente = new Cliente(nome, cpf, idade, saldo, tipoCliente);

                            try
                            {
                                clientedal.insert(cliente);
                            }
                            catch (Exception)
                            {
                                clientedal.delete(cliente);
                                Console.WriteLine("ERRO ao tentar inserir este cliente.");
                            }
                            finally
                            {
                                clientedal.getLastRegister();
                                Console.WriteLine("Inserção concluída com sucesso.");
                            }
                        }
                    }

                    repeat = true;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Quer geradar dados do sócio ou inserir dados? \n1 - Inserir dados \n2 - Gerar dados \nDigite um número: ");
                    createOrInsert = int.Parse(Console.ReadLine());

                    if (createOrInsert == 1)
                    {
                        Console.WriteLine("Quantos clientes quer inserir? \nInsira um número:");
                        qtdCreates = int.Parse(Console.ReadLine());

                        for (int i = 0; i < qtdCreates; i++)
                        {
                            sociodal = new SocioDAL();

                            Console.WriteLine("Dados a serem inseridos: ");
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
                            Console.Write("Quantidade de ações: ");
                            qtdAcoes = double.Parse(Console.ReadLine());

                            socio = new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente);

                            try
                            {
                                sociodal.insert(socio);
                            }
                            catch (Exception)
                            {
                                sociodal.delete(socio);
                                Console.WriteLine("ERRO ao tentar inserir este sócio.");
                            }
                            finally
                            {
                                sociodal.getLastRegister();
                                Console.WriteLine("Inserção concluída com sucesso.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quantos sócios quer gerar? \nInsira um número:");
                        qtdCreates = int.Parse(Console.ReadLine());

                        Console.WriteLine("Inserindo dados do sócio.");
                        for (int i = 0; i < qtdCreates; i++)
                        {
                            sociodal = new SocioDAL();

                            idade = Gerador.Idade();
                            cpf = Gerador.Cpf();
                            nome = Gerador.NomePessoa();
                            saldo = Gerador.Saldo();
                            tipoCliente = GeraOutrosDados.TipoClienteSocio();
                            qtdAcoes = GeraOutrosDados.QtdAcoes();

                            socio = new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente);

                            try
                            {
                                sociodal.insert(socio);
                            }
                            catch (Exception)
                            {
                                sociodal.delete(socio);
                                Console.WriteLine("ERRO ao tentar inserir este sócio.");
                            }
                            finally
                            {
                                sociodal.getLastRegister();
                                Console.WriteLine("Inserção concluída com sucesso.");
                            }
                        }
                    }

                    repeat = true;
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Quer geradar dados do funcionário ou inserir dados? Digite: \n1 - Inserir dados \n2 - Gerar dados \nNúmero:");
                    createOrInsert = int.Parse(Console.ReadLine());

                    if (createOrInsert == 1)
                    {
                        Console.WriteLine("Quantos funcionários quer inserir? \nInsira um número:");
                        qtdCreates = int.Parse(Console.ReadLine());

                        for (int i = 0; i < qtdCreates; i++)
                        {
                            funcionariodal = new FuncionarioDAL();

                            Console.WriteLine("Insira os dados abaixo:");
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

                            funcionario = new Funcionario(nome, cpf, idade, salarioPorHora, cargo, saldo);

                            try
                            {
                                funcionariodal.insert(funcionario);
                            }
                            catch (Exception)
                            {
                                funcionariodal.delete(funcionario);
                                Console.WriteLine("ERRO ao tentar inserir este funcionário.");
                            }
                            finally
                            {
                                funcionariodal.getLastRegister();
                                Console.WriteLine("Inserção concluída com sucesso.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quantos funcionários quer gerar? \nInsira um número:");
                        qtdCreates = int.Parse(Console.ReadLine());

                        Console.WriteLine("Inserindo dados do funcionário.");
                        for (int i = 0; i < qtdCreates; i++)
                        {
                            funcionariodal = new FuncionarioDAL();

                            idade = Gerador.Idade();
                            cpf = Gerador.Cpf();
                            nome = Gerador.NomePessoa();
                            saldo = Gerador.Saldo();
                            cargo = GeraOutrosDados.Cargo();
                            salarioPorHora = GeraOutrosDados.SalarioPorHora();

                            funcionario = new Funcionario(nome, cpf, idade, salarioPorHora, cargo, saldo);

                            try
                            {
                                funcionariodal.insert(funcionario);
                            }
                            catch (Exception)
                            {
                                funcionariodal.delete(funcionario);
                                Console.WriteLine("ERRO ao tentar inserir este funcionário.");
                            }
                            finally
                            {
                                funcionariodal.getLastRegister();
                                Console.WriteLine("Inserção concluída com sucesso.");
                            }
                        }
                    }

                    repeat = true;
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("Quer geradar dados do fornecedor ou inserir dados? Digite: \n1 - Inserir dados \n2 - Gerar dados");
                    Console.Write("Número: ");
                    createOrInsert = int.Parse(Console.ReadLine());

                    if (createOrInsert == 1)
                    {
                        Console.WriteLine("Quantos fornecedores quer inserir? \nInsira um número:");
                        qtdCreates = int.Parse(Console.ReadLine());

                        for (int i = 0; i < qtdCreates; i++)
                        {
                            fornecedordal = new FornecedorDAL();

                            Console.WriteLine("Insira os dados abaixo:");
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
                                fornecedordal.insert(fornecedor);
                            }
                            catch (Exception)
                            {
                                fornecedordal.delete(fornecedor);
                                Console.WriteLine("ERRO ao tentar inserir este fornecedor.");
                            }
                            finally
                            {
                                fornecedordal.getLastRegister();
                                Console.WriteLine("Inserção concluída com sucesso.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quantos fornecedores quer inserir? \nInsira um número:");
                        qtdCreates = int.Parse(Console.ReadLine());

                        for (int i = 0; i < qtdCreates; i++)
                        {
                            fornecedordal = new FornecedorDAL();

                            nomeEmpresa = Gerador.NomeEmpresa();
                            tipoProduto = GeraOutrosDados.TipoProduto();
                            qtdFornecidaAoMes = GeraOutrosDados.QuantidadeFornecidaAoMes();
                            cnpj = GeraOutrosDados.Cnpj();

                            fornecedor = new Fornecedor(nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes);

                            try
                            {
                                fornecedordal.insert(fornecedor);
                            }
                            catch (Exception)
                            {
                                fornecedordal.delete(fornecedor);
                                Console.WriteLine("ERRO ao tentar inserir este fornecedor.");
                            }
                            finally
                            {
                                fornecedordal.getLastRegister();
                                Console.WriteLine("Inserção concluída com sucesso.");
                            }
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

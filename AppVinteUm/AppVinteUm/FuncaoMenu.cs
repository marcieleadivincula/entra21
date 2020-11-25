using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public static class FuncaoMenu
    {
        public static void Adicionar()
        {
            int idade, tipoProduto, qtdFornecidaAoMes, userChoice, createOrInsert, qtdCreates;
            string cpf, nome, nomeEmpresa, cargo, tipoCliente, cnpj;
            double saldo, qtdAcoes, salarioPorHora;
            bool repeat = false;

            ClienteDAL clientedal = new ClienteDAL();
            FuncionarioDAL funcionariodal = new FuncionarioDAL();
            FornecedorDAL fornecedordal = new FornecedorDAL();
            SocioDAL sociodal = new SocioDAL();

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

                            try
                            {
                                clientedal.insert(new Cliente(nome, cpf, idade, saldo, tipoCliente));
                            }
                            catch (Exception)
                            {
                                clientedal.delete(new Cliente(nome, cpf, idade, saldo, tipoCliente));
                                Console.WriteLine("ERRO ao tentar inserir este cliente.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída com sucesso.");
                                clientedal.getLastRegister();
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
                            tipoCliente = GeraOutrosDados.TipoCliente();

                            try
                            {
                                clientedal.insert(new Cliente(nome, cpf, idade, saldo, tipoCliente));
                            }
                            catch (Exception)
                            {
                                clientedal.delete(new Cliente(nome, cpf, idade, saldo, tipoCliente));
                                Console.WriteLine("ERRO ao tentar inserir este cliente.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída com sucesso.");
                                clientedal.getLastRegister();
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

                            try
                            {
                                sociodal.insert(new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente));
                            }
                            catch (Exception)
                            {
                                sociodal.delete(new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente));
                                Console.WriteLine("ERRO ao tentar inserir este sócio.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída com sucesso.");
                                sociodal.getLastRegister();
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
                            tipoCliente = GeraOutrosDados.TipoCliente();
                            qtdAcoes = GeraOutrosDados.QtdAcoes();

                            try
                            {
                                sociodal.insert(new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente));
                            }
                            catch (Exception)
                            {
                                sociodal.delete(new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente));
                                Console.WriteLine("ERRO ao tentar inserir este sócio.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída com sucesso.");
                                sociodal.getLastRegister();
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

                            try
                            {
                                funcionariodal.insert(new Funcionario(nome, cpf, idade, salarioPorHora, cargo, saldo));
                            }
                            catch (Exception)
                            {
                                funcionariodal.delete(new Funcionario(nome, cpf, idade, salarioPorHora, cargo, saldo));
                                Console.WriteLine("ERRO ao tentar inserir este funcionário.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída com sucesso.");
                                funcionariodal.getLastRegister();
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

                            try
                            {
                                funcionariodal.insert(new Funcionario(nome, cpf, idade, salarioPorHora, cargo, saldo));
                            }
                            catch (Exception)
                            {
                                funcionariodal.delete(new Funcionario(nome, cpf, idade, salarioPorHora, cargo, saldo));
                                Console.WriteLine("ERRO ao tentar inserir este funcionário.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída com sucesso.");
                                funcionariodal.getLastRegister();
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

                            try
                            {
                                fornecedordal.insert(new Fornecedor(nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes));
                            }
                            catch (Exception)
                            {
                                fornecedordal.delete(new Fornecedor(nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes));
                                Console.WriteLine("ERRO ao tentar inserir este fornecedor.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída com sucesso.");
                                fornecedordal.getLastRegister();
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

                            try
                            {
                                fornecedordal.insert(new Fornecedor(nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes));
                            }
                            catch (Exception)
                            {
                                fornecedordal.delete(new Fornecedor(nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes));
                                Console.WriteLine("ERRO ao tentar inserir este fornecedor.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída com sucesso.");
                                fornecedordal.getLastRegister();
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

        public static void Remover()
        {
            int userChoice, idOrCpf, id;
            string cpfOrCnpj, cnpj, cpf;
            bool repeat = false;

            ClienteDAL clientedal = new ClienteDAL();
            FuncionarioDAL funcionariodal = new FuncionarioDAL();
            FornecedorDAL fornecedordal = new FornecedorDAL();
            SocioDAL sociodal = new SocioDAL();

            Console.Clear();
            Console.WriteLine("MENU PRINCIPAL: ");
            Console.Write("O que será removido? \n1 - Cliente Normal \n2 - Cliente Sócio \n3 - Funcionário  \n4 - Fornecedor \n5 - Sair \n");
            Console.WriteLine();
            Console.Write("Escolha uma opção:");
            userChoice = int.Parse(Console.ReadLine());

            while (repeat == false)
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("Quer remover cliente por ID ou CPF? \n1 - ID \n2 - CPF \nEscolha uma opção: ");
                    idOrCpf = int.Parse(Console.ReadLine());

                    if (idOrCpf == 1)
                    {
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os clientes normais: ");
                        clientedal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o ID: ");
                        id = int.Parse(Console.ReadLine());

                        Cliente cliente = new Cliente();
                        cliente = clientedal.getById(id);

                        try
                        {
                            clientedal.delete(cliente);
                        }
                        catch (Exception e)
                        {
                            clientedal.getById(id);
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("O elemento [" + id + "] foi removido com sucesso.");
                        }
                    }
                    else if (idOrCpf == 2)
                    {
                        Cliente cliente = new Cliente();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os clientes normais: ");
                        clientedal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o CPF: ");
                        cpf = Console.ReadLine();

                        cliente = clientedal.getByCpf(cpf);

                        try
                        {
                            clientedal.delete(cliente);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("O elemento [" + cpf + "] foi removido com sucesso.");
                        }
                    }
                    else
                    {
                        break;
                    }

                    repeat = true;
                    Console.Clear(); //REVER
                    //VOLTAR AO MENU PRINCIPAL
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Quer remover sócio por ID ou CPF? \n1 - ID \n2 - CPF \nEscolha uma opção: ");
                    idOrCpf = int.Parse(Console.ReadLine());

                    if (idOrCpf == 1)
                    {
                        Socio socio = new Socio();
                        sociodal = new SocioDAL();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os clientes sócios: ");
                        sociodal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o ID: ");
                        id = int.Parse(Console.ReadLine());

                        socio = sociodal.getById(id);

                        try
                        {
                            sociodal.delete(socio);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("O elemento [" + id + "] foi removido com sucesso.");
                        }
                    }
                    else if (idOrCpf == 2)
                    {
                        Socio socio = new Socio();
                        sociodal = new SocioDAL();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os clientes sócios: ");
                        sociodal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o CPF: ");
                        cpf = Console.ReadLine();

                        socio = sociodal.getByCpf(cpf);

                        try
                        {
                            sociodal.delete(socio);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("O elemento [" + cpf + "] foi removido com sucesso.");
                        }
                    }
                    else
                    {
                        FuncaoMenu.Sair(); //REVER
                        break;
                    }
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Quer remover funcionário por ID ou CPF? \n1 - ID \n2 - CPF \nEscolha uma opção: ");
                    idOrCpf = int.Parse(Console.ReadLine());

                    if (idOrCpf == 1)
                    {
                        Funcionario funcionario = new Funcionario();
                        funcionariodal = new FuncionarioDAL();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os funcionários: ");
                        funcionariodal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o ID: ");
                        id = int.Parse(Console.ReadLine());
                        funcionario = funcionariodal.getById(id);

                        try
                        {
                            funcionariodal.delete(funcionario);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("O elemento [" + id + "] foi removido com sucesso.");
                        }


                    }
                    else if (idOrCpf == 2)
                    {
                        Funcionario funcionario = new Funcionario();
                        funcionariodal = new FuncionarioDAL();
                        Console.WriteLine("Lista todos os funcionários: ");
                        funcionariodal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o CPF: ");
                        cpf = Console.ReadLine();

                        funcionario = funcionariodal.getByCpf(cpf);

                        try
                        {
                            funcionariodal.delete(funcionario);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("O elemento [" + cpf + "] foi removido com sucesso.");
                        }
                    }
                    else
                    {
                        break;
                    }

                    repeat = true;
                }
                else if (userChoice == 4)
                {
                    Fornecedor fornecedor = new Fornecedor();
                    Console.WriteLine("Quer remover funcionário por ID ou CNPJ? \n1 - ID \n2 - CNPJ \nEscolha uma opção: ");
                    idOrCpf = int.Parse(Console.ReadLine());

                    if (idOrCpf == 1)
                    {
                        fornecedordal = new FornecedorDAL();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os fornecedores: ");
                        fornecedordal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o ID: ");
                        id = int.Parse(Console.ReadLine());

                        fornecedor = fornecedordal.getById(id);

                        try
                        {
                            fornecedordal.delete(fornecedor);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("O elemento [" + id + "] foi removido com sucesso.");
                        }

                        repeat = true;
                    }
                    else
                    {
                        fornecedordal = new FornecedorDAL();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os fornecedores: ");
                        fornecedordal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o CNPJ: ");
                        cnpj = Console.ReadLine();

                        fornecedor = fornecedordal.getByCnpj(cnpj);

                        try
                        {
                            fornecedordal.delete(fornecedor);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("O elemento [" + cnpj + "] foi removido com sucesso.");
                        }

                        repeat = true;
                    }
                }
                else
                {
                    repeat = false;
                }
            }
        }

        public static void Comprar()
        {
            int userChoice;
            string cpf;
            bool repeat = false;

            ClienteDAL clientedal = new ClienteDAL();
            SocioDAL sociodal = new SocioDAL();

            double quantidade, resultado;
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
                    Console.WriteLine("Listando elementos deste cliente: ");
                    clientedal.getAll();
                    Console.WriteLine("-------------------------------//-----------------------");

                    Console.WriteLine("Qual cliente está comprando? ");
                    Console.Write("Digite o CPF: ");
                    cpf = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(cpf))
                    {
                        clientedal.getByCpf(cpf);

                        Console.Write("Quanto está comprando? ");
                        quantidade = int.Parse(Console.ReadLine());

                        if (quantidade > 0)
                        {
                            clientedal.update(new Cliente(quantidade)); //ver como se comporta, se atualiza um apenas ou tudo
                        }
                    }

                    repeat = true;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Listando elementos deste cliente: ");
                    sociodal.getAll();
                    Console.WriteLine("-------------------------------//-----------------------");

                    Console.WriteLine("Qual cliente está comprando? ");
                    Console.Write("Digite o CPF: ");
                    cpf = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(cpf))
                    {
                        Console.Write("Quanto está comprando? ");
                        quantidade = int.Parse(Console.ReadLine());
                        //resultado = quantidade - 0.20;
                        resultado = quantidade * 1.20;

                        if (resultado > 0)
                        {
                            sociodal.update(new Socio(resultado));  //ver como se comporta, se atualiza um apenas ou tudo
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

        public static void BaterCartao()
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

        public static void Alterar()
        {
            int idade, tipoProduto, qtdFornecidaAoMes, userChoice;
            string cpf, nome, nomeEmpresa, cargo, tipoCliente, cnpj, cpfOrCnpj;
            double saldo, qtdAcoes, salarioPorHora;
            bool repeat = false;

            ClienteDAL clientedal = new ClienteDAL();
            FuncionarioDAL funcionariodal = new FuncionarioDAL();
            FornecedorDAL fornecedordal = new FornecedorDAL();
            SocioDAL sociodal = new SocioDAL();

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
                    Console.WriteLine("Listando clientes normais: ");
                    clientedal.getAll();
                    Console.WriteLine("-------------------------------//-----------------------");

                    Console.WriteLine("Qual será alterado? ");
                    Console.Write("Digite o CPF: ");
                    cpfOrCnpj = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(cpfOrCnpj)) //REVER
                    {
                        clientedal = new ClienteDAL();
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

                        try
                        {
                            clientedal.update(new Cliente(nome, cpf, idade, saldo, tipoCliente));
                        }
                        catch (Exception)
                        {
                            clientedal.delete(new Cliente(nome, cpf, idade, saldo, tipoCliente));
                            Console.WriteLine("ERRO ao tentar atualizar este cliente.");
                        }
                        finally
                        {
                            clientedal.getByCpf(cpfOrCnpj);
                            Console.WriteLine("Atualização terminada.");
                        }
                    }
                    else
                    {
                        break;
                    }

                    repeat = true;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Listando clientes sócios: ");
                    sociodal.getAll();
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
                    funcionariodal.getAll();
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
                    Console.WriteLine("Listando fornecedores: ");
                    fornecedordal.getAll();
                    Console.WriteLine("-------------------------------//-----------------------");

                    Console.WriteLine("Qual será alterado? ");
                    Console.Write("Digite o CNPJ: ");
                    cpfOrCnpj = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(cpfOrCnpj))
                    {
                        fornecedordal = new FornecedorDAL();
                        fornecedordal.getByCnpj(cpfOrCnpj);

                        Console.Write("Nome da Empresa: ");
                        nomeEmpresa = Console.ReadLine();
                        Console.Write("Tipo de Produto: ");
                        tipoProduto = int.Parse(Console.ReadLine());
                        Console.Write("Quantidade Fornecida ao Mês: ");
                        qtdFornecidaAoMes = int.Parse(Console.ReadLine());
                        Console.Write("CNPJ: ");
                        cnpj = Console.ReadLine();

                        try
                        {
                            fornecedordal.insert(new Fornecedor(nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes));
                        }
                        catch (Exception)
                        {
                            fornecedordal.delete(new Fornecedor(nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes));
                            Console.WriteLine("ERRO ao tentar atualizar este fornecedor.");
                        }
                        finally
                        {
                            fornecedordal.getByCnpj(cpfOrCnpj);
                            Console.WriteLine("Atualização terminada.");
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

        public static void CalcularLucro()
        {
            double ganho, prejuizo;
            bool repeat = false;

            ClienteDAL clientedal = new ClienteDAL();
            FuncionarioDAL funcionariodal = new FuncionarioDAL();
            FornecedorDAL fornecedordal = new FornecedorDAL();
            SocioDAL sociodal = new SocioDAL();

            Console.WriteLine("Saldo total do cliente NORMAL");
            clientedal.getBySumSaldo();
            Console.WriteLine("Saldo total do cliente SÓCIO");
            sociodal.getBySumSaldo();
            Console.WriteLine("Quantidade total fornecida ao mês");
            fornecedordal.getBySumQtdProdutos();
            Console.WriteLine("Saldo total do FUNCIONÁRIO");
            funcionariodal.getBySumSaldo();
        }

        public static void Sair()
        {
            Console.WriteLine("Obrigado por usar nosso programa.");
            Console.WriteLine("Encerrando programa...");
            //RETORNAR AO MENU PRINCIPAL
        }
    }
}

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

            List<Cliente> clientes = new List<Cliente>();
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Socio> socios = new List<Socio>();
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            ClienteDAL clientedal = new ClienteDAL();
            FuncionarioDAL funcionariodal = new FuncionarioDAL();
            FornecedorDAL fornecedordal = new FornecedorDAL();
            SocioDAL sociodal = new SocioDAL();

            Console.Clear();
            Console.WriteLine("Quem deseja adicionar?");
            Console.Write("Menu principal: \n1 - Cliente Normal \n2 - Cliente Sócio \n3 - Funcionário  \n4 - Fornecedor \n5 - Sair \n");
            Console.WriteLine();
            Console.Write("Escolha uma opção:");
            userChoice = int.Parse(Console.ReadLine());

            while (repeat == false)
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("Quer geradar dados do cliente ou inserir dados? \nDigite: \n1 - Inserir dados \n2 - Gerar dados");
                    Console.Write("Número: ");
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
                                clientedal.update(new Cliente(nome, cpf, idade, saldo, tipoCliente));
                            }
                            catch (Exception)
                            {
                                clientedal.delete(new Cliente(nome, cpf, idade, saldo, tipoCliente));
                                Console.WriteLine("ERRO ao tentar inserir este cliente.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída. Cliente " + clientedal.getLastRegister() + "inserido com sucesso.");
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
                           
                            clientes[i] = new Cliente(nome, cpf, idade, saldo, tipoCliente);

                            try
                            {
                                clientedal.insert(new Cliente(clientes[i].Nome, clientes[i].CPF, clientes[i].Idade, clientes[i].Saldo, clientes[i].TipoCliente));
                            }
                            finally
                            {
                                clientedal.delete(clientes[i]);
                            }
                        }
                    }

                    repeat = true;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Quer geradar dados do sócio ou inserir dados? \nDigite: \n1 - Inserir dados \n2 - Gerar dados");
                    Console.Write("Número: ");
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
                                sociodal.update(new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente));
                            }
                            catch (Exception)
                            {
                                sociodal.delete(new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente));
                                Console.WriteLine("ERRO ao tentar inserir este sócio.");
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída. Sócio " + sociodal.getLastRegister() + "inserido com sucesso.");
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
                            
                            socios[i] = new Socio(qtdAcoes, nome, cpf, idade, saldo, tipoCliente);

                            try
                            {
                                sociodal.insert(new Socio(socios[i].QtdAcoes, socios[i].Nome, socios[i].CPF, socios[i].Idade, socios[i].Saldo, socios[i].TipoCliente));
                            }
                            finally
                            {
                                sociodal.delete(socios[i]);
                            }
                        }
                    }

                    repeat = true;
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Quer geradar dados do funcionário ou inserir dados? \nDigite: \n1 - Inserir dados \n2 - Gerar dados");
                    Console.Write("Número: ");
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
                                Console.WriteLine("Inserção concluída. Funcionário " + funcionariodal.getLastRegister() + "inserido com sucesso.");
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
                            idade = Gerador.Idade();
                            cpf = Gerador.Cpf();
                            nome = Gerador.NomePessoa();
                            saldo = Gerador.Saldo();
                            cargo = GeraOutrosDados.Cargo();
                            salarioPorHora = GeraOutrosDados.SalarioPorHora();

                            funcionariodal = new FuncionarioDAL();
                            funcionarios[i] = new Funcionario(nome, cpf, idade, salarioPorHora, cargo, saldo);

                            try
                            {
                                funcionariodal.insert(new Funcionario(funcionarios[i].Nome, funcionarios[i].CPF, funcionarios[i].Idade, funcionarios[i].SalarioPorHora, funcionarios[i].Cargo, funcionarios[i].Saldo));
                            }
                            finally
                            {
                                Console.WriteLine("Inserção concluída. Funcionário " + funcionariodal.getLastRegister() + "inserido com sucesso.");
                            }
                        }
                    }

                    repeat = true;
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("Quer geradar dados do fornecedor ou inserir dados? \nDigite: \n1 - Inserir dados \n2 - Gerar dados");
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
                                Console.WriteLine("Inserção concluída. Fornecedor " + fornecedordal.getLastRegister() + "inserido com sucesso.");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < fornecedores.Count; i++)
                        {
                            nomeEmpresa = Gerador.NomeEmpresa();
                            tipoProduto = GeraOutrosDados.TipoProduto();
                            qtdFornecidaAoMes = GeraOutrosDados.QuantidadeFornecidaAoMes();
                            cnpj = GeraOutrosDados.Cnpj();

                            fornecedordal = new FornecedorDAL();
                            fornecedores[i] = new Fornecedor(nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes);

                            try
                            {
                                fornecedordal.insert(new Fornecedor(fornecedores[i].Nome, fornecedores[i].CNPJ, fornecedores[i].TipoDeProduto, fornecedores[i].QuantidadeFornecidaAoMes));
                            }
                            finally
                            {
                                fornecedordal.delete(fornecedores[i]);
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
            int userChoice;
            string cpfOrCnpj;
            bool repeat = false;

            ClienteDAL clientedal = new ClienteDAL();
            FuncionarioDAL funcionariodal = new FuncionarioDAL();
            FornecedorDAL fornecedordal = new FornecedorDAL();
            SocioDAL sociodal = new SocioDAL();

            Console.Clear();
            Console.WriteLine("O que será removido?");
            Console.Write("Menu principal: \n1 - Cliente Normal \n2 - Cliente Sócio \n3 - Funcionário  \n4 - Fornecedor \n5 - Sair \n");
            Console.WriteLine();
            Console.Write("Escolha uma opção:");
            userChoice = int.Parse(Console.ReadLine());

            while (repeat == false)
            {
                switch (userChoice)
                {
                    case 1:
                        clientedal = new ClienteDAL();
                        Console.WriteLine("Lista todos os clientes normais: ");
                        clientedal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");

                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o CPF: ");
                        cpfOrCnpj = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(cpfOrCnpj))
                        {
                            clientedal.getByCpf(cpfOrCnpj);

                            try
                            {
                                clientedal.delete(new Cliente());
                            }
                            finally
                            {
                                Console.WriteLine("O elemento [" + cpfOrCnpj + "] foi removido com sucesso.");
                            }
                        }

                        repeat = true;
                        break;
                    case 2:
                        sociodal = new SocioDAL();
                        Console.WriteLine("Lista todos os clientes sócios: ");
                        sociodal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");

                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o CPF: ");
                        cpfOrCnpj = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(cpfOrCnpj))
                        {
                            sociodal.getByCpf(cpfOrCnpj);

                            try
                            {
                                sociodal.delete(new Socio());
                            }
                            finally
                            {
                                Console.WriteLine("O elemento [" + cpfOrCnpj + "] foi removido com sucesso.");
                            }
                        }

                        repeat = true;
                        break;
                    case 3:
                        funcionariodal = new FuncionarioDAL();
                        Console.WriteLine("Lista todos os funcionários: ");
                        funcionariodal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");

                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o CPF: ");
                        cpfOrCnpj = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(cpfOrCnpj))
                        {
                            funcionariodal.getByCpf(cpfOrCnpj);

                            try
                            {
                                funcionariodal.delete(new Funcionario());
                            }
                            finally
                            {
                                Console.WriteLine("O elemento [" + cpfOrCnpj + "] foi removido com sucesso.");
                            }
                        }

                        repeat = true;
                        break;
                    case 4:
                        fornecedordal = new FornecedorDAL();
                        Console.WriteLine("Lista todos os fornecedores: ");
                        fornecedordal.getAll();
                        Console.WriteLine("-------------------------------//-----------------------");

                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o CNPJ: ");
                        cpfOrCnpj = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(cpfOrCnpj))
                        {
                            fornecedordal.getByCnpj(cpfOrCnpj);

                            try
                            {
                                fornecedordal.delete(new Fornecedor());
                            }
                            finally
                            {
                                Console.WriteLine("O elemento [" + cpfOrCnpj + "] foi removido com sucesso.");
                            }
                        }

                        repeat = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        repeat = false;
                        break;
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
        }
    }
}

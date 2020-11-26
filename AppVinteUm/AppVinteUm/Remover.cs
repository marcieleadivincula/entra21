using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public static class Remover
    {
        public static void RemoverItem()
        {
            int userChoice, idOrCpf, id;
            string cnpj, cpf;
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
                        Cliente cliente = new Cliente();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os clientes normais: ");
                        clientedal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o ID: ");
                        id = int.Parse(Console.ReadLine());

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
                        clientedal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
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
                        sociodal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
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
                        sociodal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
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
                        Sair.EncerrarExecucao(); //REVER
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
                        funcionariodal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
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
                        funcionariodal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
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
                        FornecedorBLL fornecedorbll = new FornecedorBLL();
                        fornecedordal = new FornecedorDAL();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os fornecedores: ");
                        fornecedordal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Qual elemento será removido?");
                        Console.Write("Digite o ID: ");
                        id = int.Parse(Console.ReadLine());

                        fornecedor = fornecedordal.getById(id);
                        fornecedorbll.getById(fornecedor);

                        if (id < 0 || id != 0)
                        {
                            //VOLTAR AO MENU PRINCIPAL
                            break;
                        }
                        else
                        {
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
                        }

                        repeat = true;
                    }
                    else
                    {
                        fornecedordal = new FornecedorDAL();
                        Console.WriteLine("-------------------------------//-----------------------");
                        Console.WriteLine("Lista todos os fornecedores: ");
                        fornecedordal.getAll().ForEach(x => { Console.WriteLine(x.GetDados()); });
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

    }
}

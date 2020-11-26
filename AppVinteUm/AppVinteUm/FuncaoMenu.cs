using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppVinteUm
{
    public static class FuncaoMenu
    {
        public static void Menu()
        {
            int userChoice;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ MENU PRINCIPAL ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("             ╔═════════════════ OPÇÕES ══════════════════════╗    ");
            Console.WriteLine("             ║ 1 ADICIONAR                                   ║    ");
            Console.WriteLine("             ║                                               ║    ");
            Console.WriteLine("             ║ 2 REMOVER                                     ║    ");
            Console.WriteLine("             ║                                               ║    ");
            Console.WriteLine("             ║ 3 COMPRAR                                     ║    ");
            Console.WriteLine("             ║                                               ║    ");
            Console.WriteLine("             ║ 4 BATER CARTÃO                                ║    ");
            Console.WriteLine("             ║                                               ║    ");
            Console.WriteLine("             ║ 5 ALTERAR                                     ║    ");
            Console.WriteLine("             ║                                               ║    ");
            Console.WriteLine("             ║ 6 CALCULAR LUCRO                              ║    ");
            Console.WriteLine("             ║                                               ║    ");
            Console.WriteLine("             ║ 7 SAIR                                        ║    ");
            Console.WriteLine("             ╚═══════════════════════════════════════════════╝    ");
            Console.WriteLine(" ");

            Console.Write("Digite uma opção:");
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Adicionar.AdicionarItem();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Remover.RemoverItem();
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    ComprarItem.Comprar();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    BaterCartao.BaterPonto();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 5:
                    Console.Clear();
                    AlterarItem.Alterar();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 6:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    CalcularLucro.CalculaLucro();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 7:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Sair.EncerrarExecucao();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }


        public static void Truncate()
        {
            //LIMPA BASE DE DADOS
            SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            SqlCommand cmd;

            string truncate = "TRUNCATE TABLE Cliente";
            cmd = new SqlCommand(truncate, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Tabela de clientes limpa.");

            truncate = "TRUNCATE TABLE Fornecedor";
            cmd = new SqlCommand(truncate, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Tabela de Fornecedor limpa.");

            truncate = "TRUNCATE TABLE Funcionario";
            cmd = new SqlCommand(truncate, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Tabela de Funcionario limpa.");

            //Console.WriteLine(GeraOutrosDados.Cnpj());
            //ClienteDAL clienteDAL = new ClienteDAL();
            //List<Cliente> clientes = new List<Cliente>();
            //Cliente cliente = new Cliente();
            //clienteDAL.getAll();

            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marci\source\repos\entra21\AppVinteUm\AppVinteUm\Database1.mdf;Integrated Security=True");
            //SqlCommand command;
            //SqlDataReader dr;

            //string select = "SELECT * FROM Cliente";
            //command = new SqlCommand(select, conn);
            //conn.Open();
            //dr = command.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine("LISTA DE CLIENTES");
            //    Console.WriteLine("----------------------//---------------------------");
            //    Console.WriteLine("Id: {0}", dr["Id"]);
            //    Console.WriteLine("Nome: {0}", dr["Nome"]);
            //    Console.WriteLine("CPF: {0}", dr["CPF"]);
            //    Console.WriteLine("Idade: {0}", dr["Idade"]);
            //    Console.WriteLine("Saldo: {0}", dr["Saldo"]);
            //    Console.WriteLine("TipoCliente: {0}", dr["TipoCliente"]);
            //    Console.WriteLine("----------------------//---------------------------");
            //}
            //conn.Close();

            //TESTE
            //ClienteDAL clientedal = new ClienteDAL();
            //SocioDAL sociodal = new SocioDAL();
            //FuncionarioDAL funcionariodall = new FuncionarioDAL();
            //FornecedorDAL fornecedordal = new FornecedorDAL();

            //ClienteBLL clientebll = new ClienteBLL();
            //SocioBLL sociobll = new SocioBLL();
            //FuncionarioBLL fornecedorbll = new FuncionarioBLL();
            //FornecedorBLL fornecedorBLL = new FornecedorBLL();

            //Cliente cliente = new Cliente();
            //Socio socio = new Socio();
            //Funcionario funcionario = new Funcionario();
            //Fornecedor fornecedor = new Fornecedor();

            //try
            //{
            //    clientedal.insert(new Cliente("Cliente Teste", "012345", 45, 1578.45, "Normal"));
            //    cliente = clientedal.getLastRegister();

            //    sociodal.insert(new Socio(2.5,"Sócio Teste", "541320", 28, 2548.63, "Sócio"));
            //    socio = sociodal.getLastRegister();

            //    funcionariodall.insert(new Funcionario("Funcionário Teste", "789456", 38, 5, "Desenvolvedor Júnior", 4587.15));
            //    funcionario = funcionariodall.getLastRegister();

            //    fornecedordal.insert(new Fornecedor("Fornecedor Teste", "42.156.145/4563-23", 5, 458));
            //    fornecedor = fornecedordal.getLastRegister();
            //}
            //finally
            //{
            //    clientedal.delete(cliente);
            //    sociodal.delete(socio);
            //    funcionariodall.delete(funcionario);
            //    fornecedordal.delete(fornecedor);
            //}

        }

        public static void CreateTables()
        {
            //public void create()
            //{
            //    //SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            //    //SqlCommand cmd;

            //    ////CRIA TABELA Cliente
            //    //string create = "CREATE TABLE Cliente (" +
            //    //    "[Id] INT IDENTITY(1,1) NOT NULL, " +
            //    //    "[Nome] VARCHAR(60), " +
            //    //    "[CPF] VARCHAR(20), " +
            //    //    "[Idade] INT NOT NULL, " +
            //    //    "[Saldo] FLOAT NOT NULL, " +
            //    //    "[TipoCliente] VARCHAR(20), " +
            //    //    "[QtdAcoes] FLOAT," +
            //    //    "PRIMARY KEY CLUSTERED([Id] ASC))";

            //    //cmd = new SqlCommand(create, conn);
            //    //conn.Open();
            //    //cmd.ExecuteNonQuery();
            //    //conn.Close();



            ////    CREATE Cliente
            ////for (int i = 0; i < 1; i++)
            ////    {
            ////        clientedal = new ClienteDAL();
            ////        clientell = new ClienteBLL();

            ////        try
            ////        {
            ////            clientedal.create();
            ////            cliente[i] = clientedal.getLastRegister();
            ////            cliente[i] = clientell.getLastRegister();
            ////        }
            ////        catch (Exception)
            ////        {
            ////            throw new Exception("Erro no DB, contate o administrador.");
            ////        }
            ////        finally
            ////        {
            ////            clientedal.getAll();
            ////            clientell.getAll();
            ////        }
            ////    }


            //    SqlConnection conn = new SqlConnection(DBConfig.CONNECTION_STRING);
            //    SqlCommand command = new SqlCommand();
            //    command.Connection = conn;
            //    command.CommandText = "CREATE TABLE Cliente ([Id] INT IDENTITY(1,1) NOT NULL, [Nome] VARCHAR(60), [CPF] VARCHAR(20), [Idade] INT NOT NULL, [Saldo] FLOAT NOT NULL, [TipoCliente] VARCHAR(20), [QtdAcoes] FLOAT,  PRIMARY KEY CLUSTERED([Id] ASC)) VALUES(@Nome, @CPF, @Idade, @Saldo, @TipoCliente, @QtdAcoes)";
            //    try
            //    {
            //        conn.Open();
            //        command.ExecuteNonQuery();

            //        return "Cliente criado com sucesso!";
            //    }
            //    catch (Exception)
            //    {

            //        throw new Exception("Erro no DB, contate o administrador.");
            //    }
            //    finally
            //    {
            //        conn.Dispose();
            //    }
            //}
        }

    }
}

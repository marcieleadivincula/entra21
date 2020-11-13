using System;
using System.Data.SqlClient;
namespace Trabalho02
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            string insert, select, update, create, delete;

            //TESTE
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Pessoa: ");
            //    Console.WriteLine(Gerador.NomePessoa());
            //    Console.Write("CPF: ");
            //    Console.WriteLine(Gerador.Cpf());
            //    Console.Write("Idade: ");
            //    Console.WriteLine(Gerador.Idade());
            //    Console.Write("Saldo: ");
            //    Console.WriteLine(Gerador.Saldo());
            //    Console.Write("Empresas: ");
            //    Console.WriteLine(Gerador.NomeEmpresa());
            //    Console.WriteLine("------------//---------------");
            //}


            ////CRIA TABELA TipoCliente
            //create = "CREATE TABLE TipoCliente (" +
            //    "[Id] INT IDENTITY(1,1) NOT NULL, " +
            //    "[TipoCliente] VARCHAR(60), " +
            //    "[QuantidadeAcoes] FLOAT," +
            //    "PRIMARY KEY CLUSTERED([Id] ASC))";

            //cmd = new SqlCommand(create, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //update = "ALTER TABLE Cliente ADD CONSTRAINT FK_Cliente_TipoCliente FOREIGN KEY(Id) REFERENCES TipoCliente(Id)";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            ////Inclui dados na tabela
            //Console.WriteLine("Inserindo dos dados do TipoCliente: ");
            //insert = $"INSERT INTO TipoCliente(TipoCliente, QuantidadeAcoes) VALUES('Normal', 0)";
            //cmd = new SqlCommand(insert, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //insert = $"INSERT INTO TipoCliente(TipoCliente, QuantidadeAcoes) VALUES('Sócio', 0)";
            //cmd = new SqlCommand(insert, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            string nome = "", cpf = "", empresa = "";
            int idade = 0;
            double saldo = 0.0;

            //nome = Gerador.NomePessoa();
            //cpf = Gerador.Cpf();
            //idade = Gerador.Idade();
            //saldo = Gerador.Saldo();
            //empresa = Gerador.NomeEmpresa();

            //na primeira execução DEVE-SE  conter ao menos 5 Cliente Normal, 2 Cliente Socio, 5 Funcionario
            Cliente[] customer = new Cliente[5];
            Cliente[] socio = new Socio[2];
            Funcionario[] func = new Funcionario[5];
            Fornecedor[] forn = new Fornecedor[2];

            //Gerando clientes do tipo NORMAL
            for (int i = 0; i < customer.Length; i++)
            {
                customer[i] = new Cliente();

                nome = Gerador.NomePessoa();
                cpf = Gerador.Cpf();
                idade = Gerador.Idade();
                saldo = Gerador.Saldo();
            }

            //Gerando clientes do tipo SÓCIO
            for (int i = 0; i < socio.Length; i++)
            {
                socio[i] = new Socio();

                nome = Gerador.NomePessoa();
                cpf = Gerador.Cpf();
                idade = Gerador.Idade();
                saldo = Gerador.Saldo();
                //double QtdAcoes
            }

            for (int i = 0; i < customer.Length; i++)
            {
                customer[i] = new Cliente();

                customer[i].Nome = nome;
                customer[i].CPF = cpf;
                customer[i].Idade = idade;
                customer[i].Saldo = saldo;

                //customer[i].CreateCliente();
                customer[i].InsertCliente();
            }

            for (int i = 0; i < customer.Length; i++)
            {
                customer[i].SelectCliente();
            }

            //FUNCIONÁRIO
            //Funcionario[] func = new Funcionario[2];

            //for (int i = 0; i < func.Length; i++)
            //{
            //    func[i] = new Funcionario();
            //    Console.WriteLine("Criando funcionário...");
            //    func[i].CreateFuncionario();
            //    Console.WriteLine("Funcionário criado com sucesso...");
            //}

            //for (int i = 0; i < func.Length; i++)
            //{
            //    func[i] = new Funcionario();

            //    func[i].Nome = Gerador.NomePessoa();
            //    func[i].CPF = Gerador.Cpf();
            //    func[i].Idade = Gerador.Idade();
            //    func[i].SalarioPorHora = Gerador.Saldo();
            //    func[i].Cargo = Gerador.NomeEmpresa();
            //    func[i].Saldo = Gerador.Saldo();

            //    Console.WriteLine("Inserindo funcionário: ");
            //    func[i].InsertFuncionario();
            //    Console.WriteLine("Fucionário inserindo com sucesso...");
            //}

            //for (int i = 0; i < func.Length; i++)
            //{
            //    func[i] = new Funcionario();
            //    func[i].SelectFuncionario();
            //}

            //FORNECEDOR
            //for (int i = 0; i < forn.Length; i++)
            //{
            //    forn[i] = new Fornecedor();
            //    Console.WriteLine("Criando fornecedor...");
            //    forn[i].CreateFornecedor();
            //    Console.WriteLine("Fornecedor criado com sucesso...");
            //}

            //for (int i = 0; i < forn.Length; i++)
            //{
            //    forn[i] = new Fornecedor();

            //    forn[i].Nome = Gerador.NomePessoa();
            //    forn[i].CNPJ = Gerador.Cpf();
            //    forn[i].TipoDeProduto = Gerador.Idade();
            //    forn[i].QuantidadeFornecidaAoMes = Gerador.Saldo();

            //    Console.WriteLine("Inserindo fornecedor: ");
            //    forn[i].InsertFornecedor();
            //    Console.WriteLine("Fornecedor inserindo com sucesso...");
            //}

            //for (int i = 0; i < forn.Length; i++)
            //{
            //    forn[i] = new Fornecedor();
            //    forn[i].SelectFornecedor();
            //}

            Console.WriteLine("Programa encerrado...");
            Console.ReadLine();
        }
    }
}

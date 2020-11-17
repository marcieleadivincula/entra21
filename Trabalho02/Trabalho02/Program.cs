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

            //Console.WriteLine(GeraOutrosDados.Cnpj());
            //Console.WriteLine(GeraOutrosDados.QtdAcoes());
            //Console.WriteLine(GeraOutrosDados.QuantidadeFornecidaAoMes());

            ////Gerando clientes do tipo NORMAL
            //for (int i = 0; i < customer.Length; i++)
            //{
            //    customer[i] = new Cliente();

            //    nome = Gerador.NomePessoa();
            //    cpf = Gerador.Cpf();
            //    idade = Gerador.Idade();
            //    saldo = Gerador.Saldo();
            //}

            ////Gerando clientes do tipo SÓCIO
            //for (int i = 0; i < socio.Length; i++)
            //{
            //    socio[i] = new Socio();

            //    nome = Gerador.NomePessoa();
            //    cpf = Gerador.Cpf();
            //    idade = Gerador.Idade();
            //    saldo = Gerador.Saldo();
            //    //double QtdAcoes
            //}

            //for (int i = 0; i < socio.Length; i++)
            //{
            //    socio[i].SelectCliente();
            //}

            //for (int i = 0; i < customer.Length; i++)
            //{
            //    customer[i] = new Cliente();

            //    customer[i].Nome = nome;
            //    customer[i].CPF = cpf;
            //    customer[i].Idade = idade;
            //    customer[i].Saldo = saldo;

            //    customer[i].CreateCliente();
            //    customer[i].InsertCliente();
            //}

            //for (int i = 0; i < customer.Length; i++)
            //{
            //    customer[i].SelectCliente();
            //}


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

            Console.Write("Escolha uma opção: \t1- Adicionar \t2- Remover \t3- Comprar \t4- Bater Cartão \t5- Alterar \t6- Calcular \t7- Sair");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    //Adicionar : primeiro, pede-se o que será adicionado (Cliente Normal, Cliente Socio, etc…) e depois peça as devidas informações.
                    break;
                case 2:
                    //Remover : primeiro, pede-se o que será removido (Cliente Normal, Cliente Socio, etc…) e depois peça qual elemento será removido (deve ser feito por cpf ou cnpj)
                    break;
                case 3:
                    //Comprar: primeiro, pede-se qual Cliente esta comprando (Cliente Normal, Cliente Socio) após isso, mostre todos daquele elemento e peça qual esta comprando(deve ser feito por cpf ou cnpj) , após isso, peça quanto esta comprando caso seja um Cliente Socio aplica-se 20% de desconto na compra.
                    break;
                case 4:
                    //BaterCartao: Mostre todos os Funcionarios, em seguida peça qual esta batendo cartao(deve ser feito por cpf) , em seguida , peça se esta batendo o cartao do dia ou de 30 dias, caso for do dia, *peça qual a hora de entrada e qual a hora de saida* 
                    break;
                case 5:
                    //Alterar: primeiro, pede-se o que será alterado (Cliente Normal, Cliente Socio, etc…) e depois mostre todos os elementos daquele conjunto, e então, peça qual será alterado (deve ser feito por cpf ou cnpj) e então, as devidas informações novas  
                    break;
                case 6:
                    //Calcular Lucro: Primeiro Passo, Devemos calcular o ganho, que é dado pela soma do Saldo de TODOS os Clientes, Agora vamos calcular o prejuízo que é dado por (Soma do Saldo de TODOS os Funcionarios + *os Fornecedores*) - *os Cliente Socio*, após isso, subtraia um pelo outro, caso der valor positivo, deve-se tirar a porção dos |dos Cliente Socio| , após o lucro ser calculado, armazene em uma variável chamado CAIXA e então Zere o Saldo de todos(Cliente e Funcioario) e Metade dos produtos de cada fornecedor(arredondado para cima)
                    break;
                case 7:
                    //Sair: Agradeça e encerre o programa 
                    break;
                default:
                    break;
            }

            Console.WriteLine("Programa encerrado...");
            Console.ReadLine();
        }
    }
}

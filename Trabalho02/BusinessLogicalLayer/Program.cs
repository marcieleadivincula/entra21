using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Trabalho02\Trabalho02\trabalho02.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            string insert, select, update, create, delete;
            int menu, id, idTipoCliente, idade, tipoCliente;
            string nome, cpf, cargo;
            float qtdAcoes;
            double saldo, salarioPorHora;

            nome = Gerador.NomePessoa();
            cpf = Gerador.Cpf();
            idade = Gerador.Idade();
            salarioPorHora = GeraOutrosDados.SalarioPorHora();
            cargo = GeraOutrosDados.Cargo();
            saldo = Gerador.Saldo();

            //na primeira execução DEVE-SE  conter ao menos 5 Cliente Normal, 2 Cliente Socio, 5 Funcionario
            //Cliente[] customer = new Cliente[5];
            //Socio[] socio = new Socio[2];

            ////Gerando clientes do tipo NORMAL
            //for (int i = 0; i < customer.Length; i++)
            //{
            //    customer[i] = new Cliente();

            //    nome = Gerador.NomePessoa();
            //    cpf = Gerador.Cpf();
            //    idade = Gerador.Idade();
            //    saldo = Gerador.Saldo();

            //    customer[i].Nome = nome;
            //    customer[i].CPF = cpf;
            //    customer[i].Idade = idade;
            //    customer[i].Saldo = (float)saldo;

            //    //Inclui dados na tabela
            //    Console.WriteLine("Inserindo dos dados do cliente: ");
            //    customer[i].InsertCliente();
            //}

            //for (int i = 0; i < customer.Length; i++)
            //{
            //    customer[i].SelectCliente();
            //}


            ////Gerando clientes do tipo SÓCIO
            //for (int i = 0; i < socio.Length; i++)
            //{
            //    socio[i] = new Socio();

            //    nome = Gerador.NomePessoa();
            //    cpf = Gerador.Cpf();
            //    idade = Gerador.Idade();
            //    saldo = Gerador.Saldo();
            //    qtdAcoes = GeraOutrosDados.QtdAcoes();

            //    socio[i].Nome = nome;
            //    socio[i].CPF = cpf;
            //    socio[i].Idade = idade;
            //    socio[i].Saldo = (float)saldo;
            //    socio[i].QtdAcoes = qtdAcoes;

            //    socio[i].InsertCliente();
            //}

            //for (int i = 0; i < socio.Length; i++)
            //{
            //    socio[i].SelectCliente();
            //}

            //FUNCIONÁRIO
            Funcionario[] func = new Funcionario[2];

            for (int i = 0; i < func.Length; i++)
            {
                Console.WriteLine("Insira o funcionário número: {0}", (i + 1));
                func[i] = new Funcionario();

                func[i].Nome = nome;
                func[i].CPF = cpf;
                func[i].Idade = idade;
                func[i].SalarioPorHora = salarioPorHora;
                func[i].Cargo = cargo;
                func[i].Saldo = saldo;

                //Console.WriteLine(func[i].GetDados());

                Console.WriteLine("Inserindo funcionário: ");
                func[i].InsertFuncionario();
                Console.WriteLine("Fucionário inserindo com sucesso...");
            }

            for (int i = 0; i < func.Length; i++)
            {
                func[i].SelectFuncionario();
            }

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

            //TRUNCATE
            //string truncate = "TRUNCATE TABLE Cliente";
            //cmd = new SqlCommand(truncate, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();


            //Console.Clear();
            //Console.Write("Menu principal: \n1 - Adicionar \n2 - Remover \n3 - Comprar  \n4 - Bater Cartão \n5 - Alterar \n6 - Calcular \n7 - Sair \n");
            //Console.WriteLine();
            //Console.Write("Escolha uma opção:");
            //menu = int.Parse(Console.ReadLine());

            //switch (menu)
            //{
            //    case 1:
            //        //Adicionar : primeiro, pede-se o que será adicionado (Cliente Normal, Cliente Socio, etc…) e depois peça as devidas informações.
            //        //Mostra: Mostra todos os clientes
            //        Console.WriteLine("-----------------//------------------");
            //        Console.WriteLine("LISTA DE CLIENTES: ");
            //        Console.WriteLine("-----------------//------------------");
            //        select = "SELECT * FROM Cliente";
            //        cmd = new SqlCommand(select, conn);
            //        conn.Open();
            //        dr = cmd.ExecuteReader();

            //        while (dr.Read())
            //        {
            //            Console.WriteLine("Id : {0}", dr["Id"]);
            //            Console.WriteLine("Nome: {0}", dr["Nome"]);
            //            Console.WriteLine("CPF: {0}", dr["CPF"]);
            //            Console.WriteLine("Idade: {0}", dr["Idade"]);
            //            Console.WriteLine("Saldo: {0}", dr["Saldo"]);
            //            Console.WriteLine("IdTipoCliente: {0}", dr["IdTipoCliente"]);
            //            Console.WriteLine("-----------------//------------------");
            //        }
            //        conn.Close();

            //        Console.WriteLine("Insira os dados do cliente: ");
            //        Console.Write("Nome: ");
            //        nome = Console.ReadLine();
            //        Console.Write("CPF: ");
            //        cpf = Console.ReadLine();
            //        Console.Write("Idade: ");
            //        idade = int.Parse(Console.ReadLine());
            //        Console.Write("Saldo: ");
            //        saldo = float.Parse(Console.ReadLine());
            //        Console.Write("IdTipoCliente: ");
            //        idTipoCliente = int.Parse(Console.ReadLine());

            //        //Mostra: Mostra todos os tipos de clientes
            //        //Console.WriteLine("-----------------//------------------");
            //        //Console.WriteLine("LISTA DE TIPO DE CLIENTES: ");
            //        //Console.WriteLine("-----------------//------------------");
            //        //select = "SELECT * FROM TipoCliente";
            //        //cmd = new SqlCommand(select, conn);
            //        //conn.Open();
            //        //dr = cmd.ExecuteReader();

            //        //while (dr.Read())
            //        //{
            //        //    Console.WriteLine("Id : {0}", dr["Id"]);
            //        //    Console.WriteLine("TipoCliente: {0}", dr["TipoCliente"]);
            //        //    Console.WriteLine("QuantidadeAcoes: {0}", dr["QuantidadeAcoes"]);
            //        //    Console.WriteLine("-----------------//------------------");
            //        //}
            //        //conn.Close();

            //        //Adicionar: Adiciona um cliente no BD
            //        insert = $"INSERT INTO Cliente(Nome, CPF, Idade, Saldo, IdTipoCliente) VALUES('{nome}', '{cpf}', {idade}, {saldo}, {idTipoCliente})";
            //        cmd = new SqlCommand(insert, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        //Mostra: Mostra todos os clientes
            //        Console.WriteLine("-----------------//------------------");
            //        Console.WriteLine("LISTA DE CLIENTES: ");
            //        Console.WriteLine("-----------------//------------------");
            //        select = "SELECT * FROM Cliente";
            //        cmd = new SqlCommand(select, conn);
            //        conn.Open();
            //        dr = cmd.ExecuteReader();

            //        while (dr.Read())
            //        {
            //            Console.WriteLine("Id : {0}", dr["Id"]);
            //            Console.WriteLine("Nome: {0}", dr["Nome"]);
            //            Console.WriteLine("CPF: {0}", dr["CPF"]);
            //            Console.WriteLine("Idade: {0}", dr["Idade"]);
            //            Console.WriteLine("Saldo: {0}", dr["Saldo"]);
            //            Console.WriteLine("IdTipoCliente: {0}", dr["IdTipoCliente"]);
            //            Console.WriteLine("-----------------//------------------");
            //        }
            //        conn.Close();
            //        break;
            //    case 2:
            //        //Remover : primeiro, pede-se o que será removido (Cliente Normal, Cliente Socio, etc…) e depois peça qual elemento será removido (deve ser feito por cpf ou cnpj)
            //        //Mostra: Mostra todos os produtos
            //        Console.WriteLine("-----------------//------------------");
            //        Console.WriteLine("LISTA DE CLIENTES: ");
            //        Console.WriteLine("-----------------//------------------");
            //        select = "SELECT * FROM Cliente";
            //        cmd = new SqlCommand(select, conn);
            //        conn.Open();
            //        dr = cmd.ExecuteReader();

            //        while (dr.Read())
            //        {
            //            Console.WriteLine("Id : {0}", dr["Id"]);
            //            Console.WriteLine("Nome: {0}", dr["Nome"]);
            //            Console.WriteLine("CPF: {0}", dr["CPF"]);
            //            Console.WriteLine("Idade: {0}", dr["Idade"]);
            //            Console.WriteLine("Saldo: {0}", dr["Saldo"]);
            //            Console.WriteLine("IdTipoCliente: {0}", dr["IdTipoCliente"]);
            //            Console.WriteLine("-----------------//------------------");
            //        }
            //        conn.Close();

            //        Console.WriteLine("Qual cliente deseja remover: ");
            //        Console.Write("Id: ");
            //        id = int.Parse(Console.ReadLine());
            //        Console.WriteLine();

            //        //Remover: Pergunta qual produto deseja remover(pode ser pelo nome)
            //        delete = $"DELETE FROM Cliente WHERE Id = {id}";
            //        cmd = new SqlCommand(delete, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        //Mostra: Mostra todos os produtos
            //        Console.WriteLine("-----------------//------------------");
            //        Console.WriteLine("LISTA DE CLIENTES: ");
            //        Console.WriteLine("-----------------//------------------");
            //        select = "SELECT * FROM Cliente";
            //        cmd = new SqlCommand(select, conn);
            //        conn.Open();
            //        dr = cmd.ExecuteReader();

            //        while (dr.Read())
            //        {
            //            Console.WriteLine("Id : {0}", dr["Id"]);
            //            Console.WriteLine("Nome: {0}", dr["Nome"]);
            //            Console.WriteLine("CPF: {0}", dr["CPF"]);
            //            Console.WriteLine("Idade: {0}", dr["Idade"]);
            //            Console.WriteLine("Saldo: {0}", dr["Saldo"]);
            //            Console.WriteLine("IdTipoCliente: {0}", dr["IdTipoCliente"]);
            //            Console.WriteLine("-----------------//------------------");
            //        }
            //        conn.Close();
            //        break;
            //    case 3:
            //        //Comprar: primeiro, pede-se qual Cliente esta comprando (Cliente Normal, Cliente Socio) após isso, mostre todos daquele elemento e peça qual esta comprando(deve ser feito por cpf ou cnpj) , após isso, peça quanto esta comprando caso seja um Cliente Socio aplica-se 20% de desconto na compra.
            //        break;
            //    case 4:
            //        //BaterCartao: Mostre todos os Funcionarios, em seguida peça qual esta batendo cartao(deve ser feito por cpf) , em seguida , peça se esta batendo o cartao do dia ou de 30 dias, caso for do dia, *peça qual a hora de entrada e qual a hora de saida* 
            //        break;
            //    case 5:
            //        //Alterar: primeiro, pede-se o que será alterado (Cliente Normal, Cliente Socio, etc…) e depois mostre todos os elementos daquele conjunto, e então, peça qual será alterado (deve ser feito por cpf ou cnpj) e então, as devidas informações novas
            //        //Mostra: Mostra todos os produtos
            //        Console.WriteLine("-----------------//------------------");
            //        Console.WriteLine("LISTA DE CLIENTES: ");
            //        Console.WriteLine("-----------------//------------------");
            //        select = "SELECT * FROM Cliente";
            //        cmd = new SqlCommand(select, conn);
            //        conn.Open();
            //        dr = cmd.ExecuteReader();

            //        while (dr.Read())
            //        {
            //            Console.WriteLine("Id : {0}", dr["Id"]);
            //            Console.WriteLine("Nome: {0}", dr["Nome"]);
            //            Console.WriteLine("CPF: {0}", dr["CPF"]);
            //            Console.WriteLine("Idade: {0}", dr["Idade"]);
            //            Console.WriteLine("Saldo: {0}", dr["Saldo"]);
            //            Console.WriteLine("IdTipoCliente: {0}", dr["IdTipoCliente"]);
            //            Console.WriteLine("-----------------//------------------");
            //        }
            //        conn.Close();

            //        Console.WriteLine("Insira os dados do cliente: ");
            //        Console.Write("Id: ");
            //        id = int.Parse(Console.ReadLine());
            //        Console.Write("Nome: ");
            //        nome = Console.ReadLine();
            //        Console.Write("CPF: ");
            //        cpf = Console.ReadLine();
            //        Console.Write("Saldo: ");
            //        saldo = float.Parse(Console.ReadLine());

            //        //Atualiza: Mostre os produtos, pergunte qual deseja alterar e em seguida, peça as informações novas
            //        update = $"UPDATE Produto SET Nome = '{nome}', CPF = '{cpf}', Saldo =  {saldo} WHERE Id = {id}";
            //        cmd = new SqlCommand(update, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        //Mostra: Mostra todos os produtos
            //        Console.WriteLine("-----------------//------------------");
            //        Console.WriteLine("LISTA DE CLIENTES: ");
            //        Console.WriteLine("-----------------//------------------");
            //        select = "SELECT * FROM Cliente";
            //        cmd = new SqlCommand(select, conn);
            //        conn.Open();
            //        dr = cmd.ExecuteReader();

            //        while (dr.Read())
            //        {
            //            Console.WriteLine("Id : {0}", dr["Id"]);
            //            Console.WriteLine("Nome: {0}", dr["Nome"]);
            //            Console.WriteLine("CPF: {0}", dr["CPF"]);
            //            Console.WriteLine("Idade: {0}", dr["Idade"]);
            //            Console.WriteLine("Saldo: {0}", dr["Saldo"]);
            //            Console.WriteLine("IdTipoCliente: {0}", dr["IdTipoCliente"]);
            //            Console.WriteLine("-----------------//------------------");
            //        }
            //        conn.Close();
            //        break;
            //    case 6:
            //        //Calcular Lucro: Primeiro Passo, Devemos calcular o ganho, que é dado pela soma do Saldo de TODOS os Clientes, Agora vamos calcular o prejuízo que é dado por (Soma do Saldo de TODOS os Funcionarios + *os Fornecedores*) - *os Cliente Socio*, após isso, subtraia um pelo outro, caso der valor positivo, deve-se tirar a porção dos |dos Cliente Socio| , após o lucro ser calculado, armazene em uma variável chamado CAIXA e então Zere o Saldo de todos(Cliente e Funcioario) e Metade dos produtos de cada fornecedor(arredondado para cima)
            //        break;
            //    case 7:
            //        //Sair: Agradeça e encerre o programa 
            //        break;
            //    default:
            //        Console.WriteLine("Opção inválida!");
            //        break;
            //}

            Console.WriteLine("Programa encerrado...");
            Console.ReadLine();

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
        }
    }
}

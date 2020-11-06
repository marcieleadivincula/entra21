using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True

            //string trunc = "TRUNCATE TABLE Contato";
            //cmd = new SqlCommand(trunc, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //string update = "UPDATE Cliente SET Nome = 'João', Email = 'joao@gmail.com' WHERE Id = 6";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //string delete = "DELETE FROM Cliente WHERE Id = 6";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();


            //1) Crie um Banco de Dados para criar produtos de um mercado, cada produto possui nome, preco(INT) e quantidade no estoque(INT).
            //a) Crie o Menu do Dono que tem as seguintes funções:
            //Adicionar: Adiciona um produto no BD
            //Remover: Pergunta qual produto deseja remover(pode ser pelo nome)
            //Atualiza: Mostre os produtos, pergunte qual deseja alterar e em seguida, peça as informações novas
            //Mostra: Mostra todos os produtos
            //Sair: Encerre o programa
            //b) Agora que criamos os produtos, vamos usá-los num caixa de mercado, peça ao usuario os produtos(pode ser por id ou nome) para o usuario poder escolher mostre apenas o nome e id de todos os produtos no bd(apenas aqueles que possuem ao menos 1 no estoque) e para cada produto escolhido reduza 1 no estoque e aumente o valor do carrinho, quando não houver mais produtos digite -1 para parar e então mostre o valor final da compra, após terminar a compra, pergunte se tem outra compra, se sim, repita o processo caso nao, encerre o programa
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Desktop\marciele\entra21\Aula17\Aula17\Database1.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            string insert, select, update, create, delete;
            int menu = 0;

            //CRIA TABELA PRODUTO
            //create = "CREATE TABLE Produto (" +
            //    "[Id] INT IDENTITY(1,1) NOT NULL, " +
            //    "[Nome] VARCHAR(60), " +
            //    "[Preco] INT NOT NULL, " +
            //    "[QtdEstoque] INT NOT NULL," +
            //    "PRIMARY KEY CLUSTERED([Id] ASC))";

            //cmd = new SqlCommand(create, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            switch (menu)
            {
                case 1:
                    //Adicionar: Adiciona um produto no BD
                    insert = $"INSERT INTO Produto(Nome, Preco, QtdEstoque) VALUES('{nome}', {preco}, {qtdEstoque})";
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    break;
                case 2:
                    //Remover: Pergunta qual produto deseja remover(pode ser pelo nome)
                    delete = $"DELETE FROM Produto WHERE Id = {id}";
                    cmd = new SqlCommand(delete, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    break;
                case 3:
                    //Atualiza: Mostre os produtos, pergunte qual deseja alterar e em seguida, peça as informações novas
                    update = $"UPDATE Produto SET Nome = '{nome}', Preco = {preco}, QtdEstoque =  {qtdEstoque} WHERE Id = {id}";
                    cmd = new SqlCommand(update, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    break;
                case 4:
                    //Mostra: Mostra todos os produtos
                    select = "SELECT * FROM Produto";
                    cmd = new SqlCommand(select, conn);
                    conn.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Console.WriteLine("Id : {0}", dr["Id"]);
                        Console.WriteLine("Nome: {0}", dr["Nome"]);
                        Console.WriteLine("Preço: {0}", dr["Preco"]);
                        Console.WriteLine("Quantidade estoque: {0}", dr["QtdEstoque"]);
                        Console.WriteLine("-----------------//------------------");
                    }
                    conn.Close();
                    break;
                case 5:
                    //Sair: Encerre o programa
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}

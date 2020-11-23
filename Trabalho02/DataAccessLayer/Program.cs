using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccessLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteDAL clientedal = new ClienteDAL();
            FuncionarioDAL funcionariodal = new FuncionarioDAL();
            FornecedorDAL fornecedordal = new FornecedorDAL();

            int idade = Gerador.Idade();
            string cpf = Gerador.Cpf();
            string nome = Gerador.NomePessoa();
            double saldo = Gerador.Saldo();
            string nomeEmpresa = Gerador.NomeEmpresa();

            string cargo = GeraOutrosDados.Cargo();
            int tipoCliente = GeraOutrosDados.TipoCliente();
            int tipoProduto = GeraOutrosDados.TipoProduto();
            int qtdFornecidaAoMes = GeraOutrosDados.QuantidadeFornecidaAoMes();
            double qtdAcoes = GeraOutrosDados.QtdAcoes();
            string cnpj = GeraOutrosDados.Cnpj();
            double salarioPorHora = GeraOutrosDados.SalarioPorHora();
       

            //Cliente cliente = new Cliente(1, "Maria Alves", "456.789.123-58", 56, 3548.45, 1);
            //Funcionario funcionario = new Funcionario(1, "Joaquim da Silva", "159.753.852-23", 48, 4.95, "Diretor", 4580.15);
            //Fornecedor fornecedor = new Fornecedor(1, "LopesECia", "1547869235253636", 5, 150);

            Cliente cliente = new Cliente(1, nome, cpf, idade, saldo, tipoCliente);
            Funcionario funcionario = new Funcionario(1, nome, cpf, idade, salarioPorHora, cargo, saldo);
            Fornecedor fornecedor = new Fornecedor(1, nomeEmpresa, cnpj, tipoProduto, qtdFornecidaAoMes);


            try
            {
                clientedal.InsertCliente(new Cliente(1, "Cliente Teste"));
                cliente = clientedal.getLastRegister();

                funcionariodal.InsertFuncionario(new Funcionario(1, "Funcionario Teste"));
                funcionario = funcionariodal.getLastRegister();

                fornecedordal.InsertFornecedor(new Fornecedor(1, "Fornecedor Teste"));
                fornecedor = fornecedordal.getLastRegister();
           
            }
            finally
            {
                clientedal.DeleteCliente(cliente);
                funcionariodal.DeleteFuncionario(funcionario);
                fornecedordal.DeleteFornecedor(fornecedor);
            }
        }
    }
}

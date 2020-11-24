using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppVinteUm
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteDAL clidal = new ClienteDAL();
            clidal.create();
            FuncionarioDAL fundal = new FuncionarioDAL();
            fundal.create();
            FornecedorDAL forndal = new FornecedorDAL();
            forndal.create();

            int userChoice;
            Console.Clear();
            Console.Write("userChoice principal: \n1 - Adicionar \n2 - Remover \n3 - Comprar  \n4 - Bater Cartão \n5 - Alterar \n6 - Calcular \n7 - Sair \n");
            Console.WriteLine();
            Console.Write("Escolha uma opção:");
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    //Adicionar : primeiro, pede-se o que será adicionado (Cliente Normal, Cliente Socio, etc…) e depois peça as devidas informações.
                    Console.Clear();
                    FuncaoMenu.Adicionar();
                    break;
                case 2:
                    //Remover : primeiro, pede-se o que será removido (Cliente Normal, Cliente Socio, etc…) e depois peça qual elemento será removido (deve ser feito por cpf ou cnpj)
                    Console.Clear();
                    FuncaoMenu.Remover();
                    break;
                case 3:
                    //Comprar: primeiro, pede-se qual Cliente esta comprando (Cliente Normal, Cliente Socio) após isso, mostre todos daquele elemento e peça qual esta comprando(deve ser feito por cpf ou cnpj) , após isso, peça quanto esta comprando caso seja um Cliente Socio aplica-se 20% de desconto na compra.
                    Console.Clear();
                    FuncaoMenu.Comprar();
                    break;
                case 4:
                    //BaterCartao: Mostre todos os Funcionarios, em seguida peça qual esta batendo cartao(deve ser feito por cpf) , em seguida , peça se esta batendo o cartao do dia ou de 30 dias, caso for do dia, *peça qual a hora de entrada e qual a hora de saida* 
                    FuncaoMenu.BaterCartao();
                    Console.Clear();
                    break;
                case 5:
                    //Alterar: primeiro, pede-se o que será alterado (Cliente Normal, Cliente Socio, etc…) e depois mostre todos os elementos daquele conjunto, e então, peça qual será alterado (deve ser feito por cpf ou cnpj) e então, as devidas informações novas
                    FuncaoMenu.Alterar();
                    Console.Clear();
                    break;
                case 6:
                    //Calcular Lucro: Primeiro Passo, Devemos calcular o ganho, que é dado pela soma do Saldo de TODOS os Clientes, Agora vamos calcular o prejuízo que é dado por (Soma do Saldo de TODOS os Funcionarios + *os Fornecedores*) - *os Cliente Socio*, após isso, subtraia um pelo outro, caso der valor positivo, deve-se tirar a porção dos |dos Cliente Socio| , após o lucro ser calculado, armazene em uma variável chamado CAIXA e então Zere o Saldo de todos(Cliente e Funcioario) e Metade dos produtos de cada fornecedor(arredondado para cima)
                    FuncaoMenu.CalcularLucro();
                    Console.Clear();
                    break;
                case 7:
                    //Sair: Agradeça e encerre o programa 
                    FuncaoMenu.Sair();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Execução finalizada...");
            Console.ReadLine();
        }
    }
}

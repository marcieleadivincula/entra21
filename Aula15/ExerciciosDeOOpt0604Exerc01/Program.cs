using System;

namespace ExerciciosDeOOpt0604Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //1)	Vamos criar uma classe Conta, que possua um atributo saldo os métodos pa-ra pegar saldo, depositar e sacar.

            //-O metodo depositar adiciona o valor do deposito ao saldo
            //- O metodo sacar decrementa o valor do saque do valor do saldo
            //- O metodo getSaldo retorna o saldo da conta

            //a)	Adicione um método atualizarSaldo na classe Conta, que atualiza o saldo dessa con-ta de acordo com uma taxa percentual fornecida.

            //b)	Crie duas subclasses da classe Conta: ContaCorrente e ContaPoupanca.Ambas terão o método atualizaSaldo reescrito: 

            //-A ContaCorrente deve atualizar - se com o dobro da taxa
            //- A ContaPoupanca deve atualizar - se com o triplo da taxa.

            //Além disso, a ContaCorrente deve reescrever o método deposita, a fim de reti - rar uma taxa bancária de dez centavos de cada depósito.

            //C) Na classe ContaCorrente, reescreva o método deposita para descontar a taxa bancária de dez centavos:

            //Dica: class ContaCorrente : Conta 

            //d)	Peça ao usuário Criar 5 contas(pode ser corrente ou poupança) , mostre todas as contas para poder escolher uma e então execute o seguinte Menu :
            //1 - Depositar : pede quanto deseja depositar e então use o método depositar
            //2 - Sacar : pede quanto deseja sacar e então use o método sacar
            //3 - Extrato: chame a função getSaldo
            //4 - Retornar: volta para o menu de escolher contas
            //5 - Sair: Encerre o programa



        }
    }
}

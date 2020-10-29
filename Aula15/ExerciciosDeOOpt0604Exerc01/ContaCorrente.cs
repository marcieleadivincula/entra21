using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0604Exerc01
{
    class ContaCorrente : Conta
    {
        public void atualiza(double taxa)
        {
            this.saldo += this.saldo * taxa * 2;
        }

        public void deposita(double valor)
        {
            this.saldo += valor - 0.10;
        }
    }
}

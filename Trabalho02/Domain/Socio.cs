using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Socio : Cliente
    {
        public double QtdAcoes { get; set; }

        public void GeraQtdAcoes()
        {

        }

        public Socio(double qtdAcoes, string nome, string cpf, int idade, double saldo, string tipoCliente) : base(nome, cpf, idade, saldo, tipoCliente)
        {
            QtdAcoes = qtdAcoes;
        }
        public double GetAcoes()
        {
            return QtdAcoes;
        }

        public void SetAcoes(double qtdAcoes)
        {
            QtdAcoes = qtdAcoes;
        }
    }
}

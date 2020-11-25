using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public class Socio: Cliente
    {
        public double QtdAcoes { get; set; }

        public Socio()
        {

        }

        public Socio(string cpf)
        {

        }


        public Socio(double saldo)
        {

        }
        public Socio(double qtdAcoes, int id, string nome, string cpf, int idade, double saldo, string tipoCliente) : base(id, nome, cpf, idade, saldo, tipoCliente)
        {
            QtdAcoes = qtdAcoes;
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

        public string GetDados()
        {
            return $"Id: {Id} Nome: {Nome} CPF: {CPF} Idade: {Idade} Saldo: {Saldo} QtdAcoes: {QtdAcoes}";
        }

        public void SetDados(string nome, string cpf, int idade, double saldo, double qtdAcoes)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Saldo = saldo;
            QtdAcoes = qtdAcoes;
        }
    }
}

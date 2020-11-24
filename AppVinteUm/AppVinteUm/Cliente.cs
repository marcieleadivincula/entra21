using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public double Saldo { get; set; } //Quanto gastou no mês
        public string TipoCliente { get; set; }

        public Cliente(int id, string nome, string cpf, int idade, double saldo, string tipoCliente)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Saldo = saldo;
            TipoCliente = tipoCliente;
        }

        public Cliente(string nome, string cpf, int idade, double saldo, string tipoCliente)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Saldo = saldo;
            TipoCliente = tipoCliente;
        }

        public Cliente()
        {

        }

        public Cliente(double saldo)
        {
            Saldo = saldo;
        }

        public string GetDados()
        {
            return $"Id: {Id} Nome: {Nome} CPF: {CPF} Idade: {Idade} Saldo: {Saldo} Tipo de cliente: {TipoCliente}";
        }

        public void SetDados(string nome, string cpf, int idade, double saldo, string tipoCliente)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Saldo = saldo;
            TipoCliente = tipoCliente;
        }
    }
}

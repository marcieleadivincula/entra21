using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public double Saldo { get; set; }
        public int IdTipoCliente { get; set; }

        public Cliente(int id, string nome, string cpf, int idade, double saldo, int idTipoCliente)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Saldo = saldo;
            IdTipoCliente = idTipoCliente;
        }

        public Cliente()
        {
        }

        public string GetDados()
        {
            return $"Id: {Id} Nome: {Nome} CPF: {CPF} Idade: {Idade} Saldo: {Saldo} Tipo de Cliente: {IdTipoCliente}";
        }

        public void SetDados(string nome, string cpf, int idade, double saldo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Saldo = saldo;
        }
    }
}

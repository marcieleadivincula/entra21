using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public double SalarioPorHora { get; set; }
        public string Cargo { get; set; }
        public double Saldo { get; set; }

        public Funcionario(int id, string nome, string cpf, int idade, double salarioPorHora, string cargo, double saldo)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            SalarioPorHora = salarioPorHora;
            Cargo = cargo;
            Saldo = saldo;
        }

        public Funcionario()
        {
        }

        public string GetDados()
        {
            return $"Id: {Id}  Nome: {Nome} CPF: {CPF} Idade: {Idade} Salário por Hora: {SalarioPorHora} Cargo: {Cargo} Saldo: {Saldo}";
        }

        public void SetDados(int id, string nome, string cpf, int idade, double salarioPorHora, string cargo, double saldo)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            SalarioPorHora = salarioPorHora;
            Cargo = cargo;
            Saldo = saldo;
        }

        public string GetCargoSalario()
        {
            return $"Cargo: {Cargo} Salário por Hora: {SalarioPorHora}";
        }

        public void SetCargoSalario(string cargo, double salario)
        {
            Cargo = cargo;
            SalarioPorHora = salario / 8.0;
        }

        //public BatePonto(string hrEntrada, string hrSaida)
        //{
        //    //calcula o ganho do funcionário naquele dia de trabalho e adiciona no saldo dele

        //}
        public string HoraEntrada { get; set; }
        public string HoraSaida { get; set; }
        public void SetHorario(string hrEntrada, string hrSaida)
        {
            HoraEntrada = hrEntrada;
            HoraSaida = hrSaida;
        }

        public string GetHorario()
        {
            //FAZER CALCULO DE HORAS TRABALHAS
            string horasTrabalhas = HoraEntrada + HoraSaida;
            return horasTrabalhas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc01
{
    class Carro : Dados
    {
        //herda Endereco e herda Dados
        public string Modelo { get; set; }
        public int CavalosVapor { get; set; }

        public Carro(string modelo, int cavalosVapor, string nome, int idade, string cpf, string cnpj, string rg, string rua, string numero, string cep, string bairro, string cidade, string estado) : base(nome, idade, cpf, cnpj, rg, rua, numero, cep, bairro, cidade, estado)
        {
            Modelo = modelo;
            CavalosVapor = cavalosVapor;
        }
    }
}

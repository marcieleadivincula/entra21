using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc01
{
    class Dados : Endereco
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Rg { get; set; }

        public Dados(string nome, int idade, string cpf, string cnpj, string rg, string rua, string numero, string cep, string bairro, string cidade, string estado) : base(rua, numero, cep, bairro, cidade, estado)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Cnpj = cnpj;
            Rg = rg;
        }
        public Dados()
        {

        }
    }
}

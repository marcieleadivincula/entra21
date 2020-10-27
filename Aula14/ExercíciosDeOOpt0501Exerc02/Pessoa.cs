using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc02
{
    class Pessoa : Endereco
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }

        public Pessoa(string nome, int idade, string cpf, string rua, string numero, string cep, string bairro, string cidade, string estado) : base(rua, numero, cep, bairro, cidade, estado)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
        }
    }
}

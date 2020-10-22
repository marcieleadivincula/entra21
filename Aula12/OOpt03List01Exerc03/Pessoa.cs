using System;
using System.Collections.Generic;
using System.Text;

namespace OOpt03List01Exerc03
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, string cpf, int idade)
        {
            Nome = nome;
            Cpf = cpf;
            Idade = idade;
        }
    }
}

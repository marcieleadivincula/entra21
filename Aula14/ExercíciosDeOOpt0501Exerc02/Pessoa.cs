using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc02
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }

        public Pessoa(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
        }
    }
}

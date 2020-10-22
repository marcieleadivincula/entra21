using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc01
{
    class Dados
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Rg { get; set; }

        public Dados(string nome, int idade, string cpf, string cnpj, string rg)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Cnpj = cnpj;
            Rg = rg;
        }
    }
}

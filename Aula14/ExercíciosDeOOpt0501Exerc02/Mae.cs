using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc02
{
    class Mae : Pessoa
    {
        //herda Endereco e herda Pessoa
        public string NomeConjuge { get; set; }
        public int QtdFilhos { get; set; }

        public Mae(string nomeConjuge, int qtdFilhos, string nome, int idade, string cpf, string rua, string numero, string cep, string bairro, string cidade, string estado) : base(nome, idade, cpf, rua, numero, cep, bairro, cidade, estado)
        {
            NomeConjuge = nomeConjuge;
            QtdFilhos = qtdFilhos;
        }
    }
}

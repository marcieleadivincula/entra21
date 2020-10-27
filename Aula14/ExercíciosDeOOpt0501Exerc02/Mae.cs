using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc02
{
    class Mae
    {
        //herda Endereco e herda Pessoa
        public string NomeConjuge { get; set; }
        public int QtdFilhos { get; set; }

        public Mae(string nomeConjuge, int qtdFilhos)
        {
            NomeConjuge = nomeConjuge;
            QtdFilhos = qtdFilhos;
        }
    }
}

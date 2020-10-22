using System;
using System.Collections.Generic;
using System.Text;

namespace Aula16
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }

        public Pessoa(string nome, string sobrenome, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
        }
    }
}

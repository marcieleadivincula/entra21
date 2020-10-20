using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt201Exerc01
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }

        public Pessoa(string nome, int idade, string cpf, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Endereco = endereco;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt401Exerc02
{
    class Pessoa : Endereco
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        private string _cpf;

        public Pessoa(string nome, int idade, string cpf, string rua, string numero, string bairro, string cidade, string estado) : base(rua, numero, bairro, cidade, estado)
        {
            Nome = nome;
            Idade = idade;
            this._cpf = cpf;
        }

        public string GetCpf()
        {
            return this._cpf;
        }

        public void SetCpf(string cpf)
        {
            this._cpf = cpf;
        }
    }
}

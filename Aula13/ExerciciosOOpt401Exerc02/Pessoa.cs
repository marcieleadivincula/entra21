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

        public Pessoa()
        {

        }

        public Pessoa(string cpf)
        {
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

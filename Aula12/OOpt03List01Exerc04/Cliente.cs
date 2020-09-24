using System;
using System.Collections.Generic;
using System.Text;

namespace OOpt03List01Exerc04
{
    class Cliente
    {
        private string _nome, _cpf;
        private string[] _consultas;

        public Cliente()
        {

        }

        public Cliente(string nome, string cpf, string[] consultas)
        {
            this._nome = nome;
            this._cpf = cpf;
            this._consultas = consultas;
        }

        public void SetNome(string nome)
        {
            this._nome = nome;
        }

        public string GetNome()
        {
            return this._nome;
        }

        public void SetCpf(string cpf)
        {
            this._cpf = cpf;
        }

        public string GetCpf()
        {
            return this._cpf;
        }

        public void SetConsultas(string[] consultas)
        {
            this._consultas = consultas;
        }

        public string[] GetConsultas()
        {
            return this._consultas;
        }
    }
}

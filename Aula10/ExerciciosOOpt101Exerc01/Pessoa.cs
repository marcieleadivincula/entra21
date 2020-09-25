using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt101Exerc01
{
    class Pessoa
    {
        private string _nome;
        private string _cpf;
        private int _idade;
        private Endereco _endereco;

        public Pessoa(string nome, string cpf, int idade, Endereco endereco)
        {
            this._nome = nome;
            this._cpf = cpf;
            this._idade = idade;
            this._endereco = endereco;
        }

        //public string Name => $"{_firstName} {_lastName}";

        //public string Nome
        //{
        //    //get => _nome;
        //    get { return this._nome; }
        //    //set => _nome = value;
        //    set { this._nome = value; }
        //}

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

        public void SetIdade(int idade)
        {
            this._idade = idade;
        }

        public int GetIdade()
        {
            return this._idade;
        }

        public void SetEndereco(Endereco endereco)
        {
            this._endereco = endereco;
        }

        public Endereco GetEndereco()
        {
            return this._endereco;
        }
    }
}

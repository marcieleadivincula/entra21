using System;
using System.Collections.Generic;
using System.Text;

namespace AulaConstrutor
{
    class Pessoa
    {
        private string _nome, _cpf; //FIELD
        private int _idade; //FIELD

        //public string Nome //PROPERTY
        //{
        //    get { return _nome; } //get method
        //    set { _nome = value; } //set method
        //}

        public string Nome //PROPERTY
        {
            get => _nome; //get method
            set => _nome = value;  //set method
        }

        //Construtor sem parâmetros
        public Pessoa()
        {

        }

        //Construtor com parâmetros
        public Pessoa(string nome, string cpf, int idade)
        {
            this._nome = nome;
            this._cpf = cpf;
            this._idade = idade;
        }

        public string getNome(){
            return _nome;
        }

        public string getCpf()
        {
            return _cpf;
        }

        public int getIdade()
        {
            return _idade;
        }

        public void setNome(string nome)
        {
            this._nome = nome;
        }

        public void setCpf(string cpf)
        {
            this._cpf = cpf;
        }

        public void setIdade(int idade)
        {
            this._idade = idade;
        }
    }
}

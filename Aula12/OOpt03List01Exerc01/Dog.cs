using System;
using System.Collections.Generic;
using System.Text;

namespace OOpt03List01Exerc01
{
    class Dog
    {
        private string _nome;
        private int _idade;
        private string _raca;

        public Dog(string nome, int idade, string raca)
        {
            this._nome = nome;
            this._idade = idade;
            this._raca = raca;
        }

        public void SetNome(string nome)
        {
            this._nome = nome;
        }

        public string GetNome()
        {
            return this._nome;
        }

        public void SetIdade(int idade)
        {
            this._idade = idade;
        }

        public int GetIdade()
        {
            return this._idade;
        }

        public void SetRaca(string raca)
        {
            this._raca = raca;
        }

        public string GetRaca()
        {
            return this._raca;
        }
    }
}

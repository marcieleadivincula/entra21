using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt102
{
    class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa(string nome, int idade)
        {
            this._nome = nome;
            this._idade = idade;
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

        public bool EhAdult()
        {
            if (this.GetIdade() >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

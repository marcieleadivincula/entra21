using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt101Exerc02
{
    class Dog
    {
        private string _nome;
        private string _nomeDono;
        private int _idade;

        public Dog(string nome, string nomeDono, int idade)
        {
            this._nome = nome;
            this._nomeDono = nomeDono;
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

        public void SetNomeDono(string nomeDono)
        {
            this._nomeDono = nomeDono;
        }

        public string GetNomeDono()
        {
            return this._nomeDono;
        }

        public void SetIdade(int idade)
        {
            this._idade = idade;
        }

        public int GetIdade()
        {
            return this._idade;
        }

        public bool EhSeis()
        {
            if (this.GetIdade() > 6)
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

using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto03
{
    class Dog
    {
        private string nome;
        private string raca;
        private int idade;

        public Dog(string nome, string raca, int idade)
        {
            this.nome = nome;
            this.raca = raca;
            this.idade = idade;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetRaca(string raca)
        {
            this.raca = raca;
        }

        public string GetRaca()
        {
            return this.raca;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public int GetIdade()
        {
            return this.idade;
        }
    }
}

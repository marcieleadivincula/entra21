using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt101Exerc03
{
    class Person
    {
        private string _nome;
        private int _idade;
        private char _genero;

        public Person(string nome, int idade, char genero)
        {
            this._nome = nome;
            this._idade = idade;
            this._genero = genero;
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

        public void SetGenero(char genero)
        {
            this._genero = genero;
        }

        public char GetGenero()
        {
            return this._genero;
        }

        public bool SeuGenero()
        {
            if (this.GetGenero() == 'f')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MaiorIdade()
        {
            double maiorIdade = 0;

            if (this.GetIdade() > maiorIdade)
            {
                maiorIdade = GetIdade();
            }
            else
            {
                Console.WriteLine("Erro na comparação das idades!"); ;
            }
        }
    }
}

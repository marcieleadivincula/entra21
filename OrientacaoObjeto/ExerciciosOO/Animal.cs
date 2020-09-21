using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOO
{
    class Animal
    {
        private string _nome;
        private string _especie;
        private int _tempoZoo; //em dias

        //Construtor com parâmetros
        public Animal(string nome, string especie, int tempoZoo)
        {
            this._nome = nome;
            this._especie = especie;
            this._tempoZoo = tempoZoo;
        }

        public void SetNome(string nome)
        {
            this._nome = nome;
        }

        public string GetNome()
        {
            return this._nome;
        }

        public void SetEspecie(string especie)
        {
            this._especie = especie;
        }

        public string GetEspecie()
        {
            return this._especie;
        }

        public void SetTempoZoo(int tempoZoo)
        {
            this._tempoZoo = tempoZoo;
        }

        public int GetTempoZoo()
        {
            return this._tempoZoo;
        }
    }
}

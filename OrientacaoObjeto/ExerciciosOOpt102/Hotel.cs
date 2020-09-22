using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt102
{
    class Hotel
    {
        private string _nome;
        private int _qtdSolteiro;
        private int _qtdCasal;

        public Hotel(string nome, int qtdSolteiro, int qtdCasal)
        {
            this._nome = nome;
            this._qtdSolteiro = qtdSolteiro;
            this._qtdCasal = qtdCasal;
        }

        public void SetNome(string nome)
        {
            this._nome = nome;
        }

        public string GetNome()
        {
            return this._nome;
        }

        public void SetQtdSolteiro(int qtdSolteiro)
        {
            this._qtdSolteiro =  qtdSolteiro;
        }

        public int GetQtdSolteiro()
        {
            return this._qtdSolteiro;
        }

        public void SetQtdCasal(int qtdCasal)
        {
            this._qtdCasal = qtdCasal;
        }

        public int GetQtdCasal()
        {
            return this._qtdCasal;
        }

        public int MultiplicaQtdCasal()
        {
            return GetQtdCasal() * 2;
        }
    }
}

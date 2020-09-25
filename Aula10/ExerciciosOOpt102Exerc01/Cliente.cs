using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt102Exerc01
{
    class Cliente
    {
        private string _nome;
        private string _cpf;
        private char _vip;

        public Cliente()
        {

        }

        public Cliente(string nome, string cpf, char vip)
        {
            this._nome = nome;
            this._cpf = cpf;
            this._vip = vip;
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

        public void SetVip(char vip)
        {
            this._vip = vip;
        }

        public char GetVip()
        {
            return this._vip;
        }
    }
}

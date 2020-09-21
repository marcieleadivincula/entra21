using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ExerciciosOO
{
    class Pessoa
    {
        private string _nome;
        private int _idade;
        private double _salario;
        private Endereco _endereco;

        public Pessoa(string nome, int idade, double salario, Endereco endereco)
        {
            this._nome = nome;
            this._idade = idade;
            this._salario = salario;
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

        public string GetNome()
        {
            return this._nome;
        }

        public void SetNome(string nome)
        {
            this._nome = nome;
        }

        public void SetIdade(int idade)
        {
            this._idade = idade;
        }

        public int GetIdade()
        {
            return this._idade;
        }

        public void SetSalario(double salario)
        {
            this._salario = salario;
        }

        public double GetSalario()
        {
            return this._salario;
        }

        public void SetEndereco(Endereco endereco)
        {
            this._endereco = endereco;
        }

        public Endereco GetEndereco()
        {
            return this._endereco;
        }

        public double Aumento()
        {
            return GetSalario() * 0.10;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOO
{
    class Endereco
    {
        private string _logradouro;
        private string _numero;
        private string _bairro;
        private string _cep;
        private string _cidade;
        private string _estado;

        public Endereco(string logradouro, string numero, string bairro, string cep, string cidade, string estado)
        {
            this._logradouro = logradouro;
            this._numero = numero;
            this._bairro = bairro;
            this._cep = cep;
            this._cidade = cidade;
            this._estado = estado;
        }

        public void SetLogradouro(string logradouro)
        {
            this._logradouro = logradouro;
        }

        public string GetLogradouro()
        {
            return this._logradouro;
        }

        public void SetNumero(string numero)
        {
            this._numero = numero;
        }

        public string GetNumero()
        {
            return this._numero;
        }

        public void SetBairro(string bairro)
        {
            this._bairro = bairro;
        }

        public string GetBairro()
        {
            return this._bairro;
        }

        public void SetCep(string cep)
        {
            this._cep = cep;
        }

        public string GetCep()
        {
            return this._cep;
        }

        public void SetCidade(string cidade)
        {
            this._cidade = cidade;
        }

        public string GetCidade()
        {
            return this._cidade;
        }

        public void SetEstado(string estado)
        {
            this._estado = estado;
        }

        public string GetEstado()
        {
            return this._estado;
        }

    }
}

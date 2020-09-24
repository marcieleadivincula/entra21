using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt101Exerc01
{
    class Endereco
    {
        private string _logradouro;
        private string _numero;
        //private string _complemento;
        //private string _cep;
        //private string _bairro;
        //private string _cidade;
        //private string _estado;
        //private string _pais;

        ///public Endereco(string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string estado, string pais)
        public Endereco(string logradouro, string numero)
        {
            this._logradouro = logradouro;
            this._numero = numero;
            //this._complemento = complemento;
            //this._cep = cep;
            //this._bairro = bairro;
            //this._cidade = cidade;
            //this._estado = estado;
            //this._pais = pais;
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

        //public void SetComplemento(string complemento)
        //{
        //    this._complemento = complemento;
        //}

        //public string GetComplemento()
        //{
        //    return this._complemento;
        //}

        //public void SetCep(string cep)
        //{
        //    this._cep = cep;
        //}

        //public string GetCep()
        //{
        //    return this._cep;
        //}

        //public void SetBairro(string bairro)
        //{
        //    this._bairro = bairro;
        //}

        //public string GetBairro()
        //{
        //    return this._bairro;
        //}

        //public void SetCidade(string cidade)
        //{
        //    this._cidade = cidade;
        //}

        //public string GetCidade()
        //{
        //    return this._cidade;
        //}

        //public void SetEstado(string estado)
        //{
        //    this._estado = estado;
        //}

        //public string GetEstado()
        //{
        //    return this._estado;
        //}

        //public void SetPais(string pais)
        //{
        //    this._pais = pais;
        //}

        //public string GetPais()
        //{
        //    return this._pais;
        //}
    }
}

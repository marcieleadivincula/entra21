using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt201Exerc01
{
    class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(string logradouro, string numero, string cep, string bairro, string cidade, string estado)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}

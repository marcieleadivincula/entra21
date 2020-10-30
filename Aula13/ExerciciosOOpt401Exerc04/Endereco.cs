using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt401Exerc04
{
    class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(string rua, string numero, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        public Endereco()
        {

        }
    }
}

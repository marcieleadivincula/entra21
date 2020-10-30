using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt401Exerc03
{
    class Empresa : Endereco
    {
        public string Nome { get; set; }
        public int QtdFuncionarios { get; set; }

        public Empresa(string nome, int qtdFuncionarios, string rua, string numero, string bairro, string cidade, string estado) : base(rua, numero, bairro, cidade, estado)
        {
            Nome = nome;
            QtdFuncionarios = qtdFuncionarios;
        }

        public Empresa()
        {

        }
    }
}

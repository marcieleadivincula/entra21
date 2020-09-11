using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public double salario;
        public bool genero;


        public double Aumento()
        {
            return salario * 0.10;
        }
    }
}

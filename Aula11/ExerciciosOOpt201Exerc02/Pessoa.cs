using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosOOpt201Exerc02
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Genero { get; set; }

        public Pessoa(string nome, int idade, char genero)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
        }
        public bool ValidaGenero()
        {
            if (Genero == 'f')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

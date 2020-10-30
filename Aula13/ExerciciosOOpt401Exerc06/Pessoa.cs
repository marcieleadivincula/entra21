using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt401Exerc06
{
    class Pessoa : Comportamento
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Dopamina { get; set; }
        public double Dinheiro { get; set; }

        public Pessoa(string nome, int idade, int dopamina, double dinheiro)
        {
            Nome = nome;
            Idade = idade;
            Dopamina = dopamina;
            Dinheiro = dinheiro;
        }
        public Pessoa()
        {

        }
    }
}

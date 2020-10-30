using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt401Exerc07
{
    class Cachorro : Comportamento
    {
        public string Nome { get; set; }
        public int Dopamina { get; set; }
        public int Conforto { get; set; }

        public Cachorro(string nome, int dopamina, int conforto)
        {
            Nome = nome;
            Dopamina = dopamina;
            Conforto = conforto;
        }

        public Cachorro()
        {

        }
    }
}

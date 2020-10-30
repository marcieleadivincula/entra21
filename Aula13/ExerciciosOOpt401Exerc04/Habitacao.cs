using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt401Exerc04
{
    class Habitacao : Endereco
    {
        public string TipoHabitacao { get; set; }
        public string NomeDono { get; set; }

        public Habitacao(string tipoHabitacao, string nomeDono)
        {
            TipoHabitacao = tipoHabitacao;
            NomeDono = nomeDono;
        }

        public Habitacao()
        {

        }
    }
}

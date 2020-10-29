using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc02
{
    class Tecnico: Assistente
    {
        public double BonusSalarial { get; set; }

        public Tecnico(double bonusSalarial, int numeroMatricula) : base(numeroMatricula)
        {
            BonusSalarial = bonusSalarial;
        }
    }
}

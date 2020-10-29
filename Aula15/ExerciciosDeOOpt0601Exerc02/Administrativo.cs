using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeOOpt0601Exerc02
{
    class Administrativo: Assistente
    {
        // turno(dia ou noite) e um adicional noturno
        public string Turno { get; set; }
        public double AdicionalNoturno { get; set; }

        public Administrativo(string turno, double adicionalNoturno, int numeroMatricula) : base(numeroMatricula)
        {
            Turno = turno;
            AdicionalNoturno = adicionalNoturno;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeExcecaopt301Exerc04
{
    public class Cargo
    {
        public int IdJobTitle { get; set; }
        public string JobTitle { get; set; }

        enum Cargos {
            desenvolvedor,
            estagiario,
            estudante,
            designer
        }

        public Cargo(int id, string job)
        {
            IdJobTitle = id;
            JobTitle = job;
        }
    }
}

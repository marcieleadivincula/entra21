using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOO
{
    class Person
    {
        public string nome;
        public int idade;
        public char genero;

        public bool SeuGenero()
        {
            if (this.genero == 'f')
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

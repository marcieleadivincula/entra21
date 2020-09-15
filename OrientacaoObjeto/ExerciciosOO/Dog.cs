using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOO
{
    class Dog
    {
        public string nome;
        public string nomeDono;
        public int idade;

        public bool EhSeis()
        {
            if (this.idade > 6)
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

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt102
{
    class Pessoa
    {
        public string nome;
        public int idade;

        public bool EhAdult()
        {
            if (this.idade >= 18)
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

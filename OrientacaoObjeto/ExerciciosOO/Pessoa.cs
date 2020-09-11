using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOO
{
    class Pessoa
    {
        private string nome { get; set; }
        private int idade { get; set; }
        private double salario { get; set; }

        //private string _firstName;
        //private string _lastName;

        //public Person(string first, string last)
        //{
        //    _firstName = first;
        //    _lastName = last;
        //}

        //public string Name => $"{_firstName} {_lastName}";

        public double Aumento()
        {
            return salario * 0.10;
        }


    }
}

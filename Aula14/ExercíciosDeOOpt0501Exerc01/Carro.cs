using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDeOOpt0501Exerc01
{
    class Carro : Endereco
    {
        //herda Endereco e herda Dados
        public string Modelo { get; set; }
        public string CavalosVapor { get; set; }

        public Carro(string modelo, string cavalosVapor)
        {
            Modelo = modelo;
            CavalosVapor = cavalosVapor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt401Exerc05
{
    class Comportamento
    {
        //Funcoes: Comer(double quantidade de kilos), Descansar(int horas) e Trabalhar(int horas)
        //Comer: para cada kilo de alimento, ganha 250 de dopamina
        //Descansar: para cada hora de descanso, ganha 100 de conforto
        //Trabalhar: para cada hora de trabalho, ganha R$ 24,52 de dinheiro no bolso

        public double Comer(double qtdKlFood)
        {
            double dopaminaPorKilo = qtdKlFood * 250;

            return dopaminaPorKilo;
        }

        public int Descansar(int horas)
        {
            int confortoPorHora = horas * 100;

            return confortoPorHora;
        }

        public double Trabalhar(int horas)
        {
            double dinheiroPorHora = horas * 24.52;

            return dinheiroPorHora;
        }
    }
}

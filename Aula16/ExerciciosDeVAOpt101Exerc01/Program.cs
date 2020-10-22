using System;
using System.Collections.Generic;

namespace ExerciciosDeVAOpt101Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - Variáveis Avançadas");
            //1) Crie uma Lista que armazena 2 Inputs quaisquer vindo do usuário, depois, mostre pro usuário.

            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            //List<int> lista = new List<int> { 0, 1,2, 3, 4};
            //List<string> lista = new List<string> { input1, input2};
            List<string> lista = new List<string>(2);

            lista.Add(input2);
            lista.Add(input1);

            Console.WriteLine("{0} {1}", lista[0], lista[1]);
        }
    }
}

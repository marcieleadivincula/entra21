using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - Aula");

            List<Pessoa> listaPes = new List<Pessoa>();

            listaPes.Capacity = 10;

            foreach (var pes in listaPes)
            {
                listaPes.Add(pes); //sempre adiciona no FIM da lista
            }

            int j = listaPes.Count;

            Console.WriteLine(j); 
            Console.WriteLine(listaPes[0]); 
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exerc 01
            Console.Write("Insira um número: ");
            int j;
            bool fim = false;

            while (!fim)
            {
                try
                {
                    j = int.Parse(Console.ReadLine());
                    fim = true;
                }
                catch (FormatException f)
                {
                    Debug.Print(f.ToString());
                    Console.WriteLine("Insira apenas números!");
                    Console.WriteLine(f.Message);
                    fim = false;
                }
                catch (OverflowException o)
                {
                    Debug.Print(o.ToString());
                    Console.WriteLine("Este número é gigantesco!");
                    Console.WriteLine(o.Message);
                    fim = false;
                }
                finally
                {
                    Console.WriteLine("Execução finalizada...Tecle enter para sair.");
                }
            }

            Console.ReadLine();

        }
    }
}

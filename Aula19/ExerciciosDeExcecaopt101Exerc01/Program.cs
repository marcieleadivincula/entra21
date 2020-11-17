using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeExcecaopt101Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Para os codigos a seguir,se houver, qual o tipo de exceção ?
            //Char[] c = new char[3]; c[3] = ‘2’;

            //int j = 1122455115522;

            //string palavra = “Carlos”

            //double d = a;

            //Char[] c = new char[3]; 
            //c[3] = '2';

            //int j = 1122455115522;
            //string palavra = "Carlos";
            //double d = a;

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

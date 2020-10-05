using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Fixação – Introdução à Programação");
            //Desenvolva os algoritmos, fluxogramas e codificação em C# dos seguintes programas:

            //int inteiro = 10;
            //double pontoFlutuante = 4;
            //string palavra = "5";

            //Console.WriteLine("Int+double " + inteiro + pontoFlutuante);
            //Console.WriteLine("Int+double " + inteiro + pontoFlutuante);
            //Console.WriteLine("Int+string " + inteiro + palavra);
            //Console.WriteLine("string+double " + palavra + pontoFlutuante);

            //Exercício 
            //int a = Convert.ToInt32(Console.In.ReadLine());;
            //string palavras;
            //a = Convert.ToInt32(Console.In.ReadLine());
            //palavras = Console.In.ReadLine();
            //a = Convert.ToInt32(palavras);

            //Console.WriteLine(a);
            //Console.WriteLine(palavras);

            //Exercício avançado
            //Joeslei = 20 pontos de vida, ataque entre 3 a 10;
            //Goblin = 5 pontos de vida, ataque entre 1 a 4;
            //Orc = 9 pontos de vida, ataque entre 4 a 8;
            //Troll = 20 pontos de vida, ataque entre 9 a 15;
            //ran.Next(valor é incluído, valor é excluído);

            Random ran = new Random();
            int ataqueMinimo = 0, ataqueMaximo = 15;
            int j = ran.Next(ataqueMinimo, ataqueMaximo);
            int g = ran.Next(ataqueMinimo, ataqueMaximo);
            int o = ran.Next(ataqueMinimo, ataqueMaximo);
            int t = ran.Next(ataqueMinimo, ataqueMaximo);

            Console.WriteLine("Joeslei = " + j);
            Console.WriteLine("Goblin = " + g);
            Console.WriteLine("Orc = " + o);
            Console.WriteLine("Troll = " + t);

            if (ataqueMinimo >= 3 && ataqueMaximo <= 10)
            {

            }
            else if (ataqueMinimo >= 1 && ataqueMaximo <= 4)
            {

            }
            else if (ataqueMinimo >= 4 && ataqueMaximo <= 8)
            {

            }
            else if (ataqueMinimo >= 9 && ataqueMaximo <= 15)
            {

            }
        }
    }
}

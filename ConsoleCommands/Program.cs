using System;

namespace ConsoleCommands
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //Exercício A
            //int a = Convert.ToInt32(Console.In.ReadLine());
            //Console.WriteLine("========================================================================================");
            //Console.WriteLine("Valor digitado = " + a);

            //Exercício B
            //int x = Convert.ToInt32(Console.In.ReadLine());
            //int y = Convert.ToInt32(Console.In.ReadLine());
            //int z = Convert.ToInt32(Console.In.ReadLine());
            //Console.WriteLine("================================================================================================");
            //Console.WriteLine("Valor de X = " + x);
            //Console.WriteLine("Valor de Y = " + y);
            //Console.WriteLine("Valor de Z = " + z);

            //Exercício C
            //int a = Convert.ToInt32(Console.In.ReadLine());
            //a = a * a;
            //Console.WriteLine("Valor ao quadrado = " + a );

            //Exercício D
            //int a = Convert.ToInt32(Console.In.ReadLine());
            //int b = Convert.ToInt32(Console.In.ReadLine());
            //a = a * a;
            //b = b * b;
            //Console.WriteLine("================================================================================================");
            //Console.WriteLine("Resultado ao quadrado " + (a + b));

            //Exercício E
            //Console.WriteLine("Digite o valor para conversão: ");
            //int totalDolar = Convert.ToInt32(Console.In.ReadLine());
            //Console.WriteLine("Digite o valor da cotação: ");
            //int cotacaoDolar = Convert.ToInt32(Console.In.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Resultado = " + (totalDolar * cotacaoDolar) + " reais");
            //Console.WriteLine("Quantidade de dólares = " + totalDolar);

            //Exercício F
            //Console.WriteLine("Digite o valor para conversão: ");
            //double totalReal = Convert.ToDouble(Console.In.ReadLine());
            //Console.WriteLine("Digite o valor da cotação: ");
            //double cotacaoReal = Convert.ToDouble(Console.In.ReadLine());
            //Console.WriteLine("================================================================================================");
            //Console.WriteLine("Resultado = " + (totalReal / cotacaoReal) + " dólares");
            //Console.WriteLine("Quantidade de reais = " + totalReal);

            //Exercício G
            //double valorArtigo = Convert.ToDouble(Console.In.ReadLine());
            //double avista = valorArtigo * 0.08, tresVezes = valorArtigo * 0.15;
            //Console.WriteLine("================================================================================================");
            //Console.WriteLine("Valor à vista = " + (valorArtigo - avista));
            //Console.WriteLine("Valor parcelado em 3x = " + (valorArtigo + tresVezes));
            //0.92 ou .92
            //int produto = Convert.ToInt32(Console.In.ReadLine());
            //Console.WriteLine("Valor à vista -> " + (produto * 0.92) + " reais" + " valor parcelado em 3x -> " + (produto * 1.15) + " reais");

            //Exercício H
            //int a = Convert.ToInt32(Console.In.ReadLine());
            //int b = Convert.ToInt32(Console.In.ReadLine());
            //int c = a;
            //a = b;
            //b = c;
            //Console.WriteLine("Valor de A = " + a);
            //Console.WriteLine("Valor de B = " + b);

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

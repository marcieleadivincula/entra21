using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lógica de Programação
            // Exemplos passados na aula
            int valor1 = 10;
            int valor2 = 3;
            double valor3 = 4;
            string palavra = "5";

            Console.WriteLine("Int+Int = " + valor1 + valor2); //13
            Console.WriteLine("Int+double = " + valor1 + valor3); //10.5
            Console.WriteLine("Int+string = " + valor1 + palavra);
            Console.WriteLine("string+double = " + palavra + valor3);

            //valor1 = valor3; //Erro
            valor1 = valor2; //valor1= 3
            valor2 = valor1; //valor2= 3
            valor3 = valor1; //valor3 = 3

            Console.WriteLine("Resultado = " + valor1 + valor2 + valor3); //9

            //Outro exemplo
            int inteiro = 5;
            double pontoFlutuante = 4;
            string palavra2 = "3";

            //inteiro = palavra; //Erro
            pontoFlutuante = inteiro + 3.5;
            Console.WriteLine(pontoFlutuante); // 8.5
            //palavra = inteiro; //Erro
            palavra2 = inteiro.ToString(); //palavra = "5"
            Console.WriteLine(palavra2); // palavra = "5"
            palavra2 = pontoFlutuante.ToString() + inteiro; //palavra = "8.55"
            Console.WriteLine(palavra2); // palavra = "8.55"
            palavra2 = inteiro.ToString() + pontoFlutuante; //palavra = "58.5"
            Console.WriteLine(palavra2); // palavra = "58.5"
        }

    }
}
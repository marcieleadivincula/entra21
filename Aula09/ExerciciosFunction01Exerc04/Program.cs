using System;

namespace ExerciciosFunction01Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 1 - Function");

            //4) Faça uma função que retorne a converção de Celsius para Fahrenheit.
            Program pro = new Program();
            Console.Write("Digite um número qualquer: ");
            int num0 = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine();
            Console.WriteLine(num0 + "C° => F°: " + pro.CelsiusToFahrenheit(num0));
            Console.WriteLine(num0 + "C° => K°: " + pro.CelsiusToKelvin(num0));
            Console.WriteLine(num0 + "F° => C°: " + pro.FahrenheitToCelsius(num0));
            Console.WriteLine(num0 + "F° => K°: " + pro.FahrenheitToKelvin(num0));
            Console.WriteLine(num0 + "K° => C°: " + pro.KelvinToCelsius(num0));
            Console.WriteLine(num0 + "K° => F°: " + pro.KelvinToFahrenheit(num0));
        }

        public double CelsiusToFahrenheit(double c)
        {
            double fahrenheit = (1.8 * c) + 32;
            return fahrenheit;
        }

        public double CelsiusToKelvin(double c)
        {
            double kelvin = c + 273.15;
            return kelvin;
        }

        public double FahrenheitToCelsius(double f)
        {
            double celsius = (f - 32) / 1.8;
            return celsius;
        }

        public double FahrenheitToKelvin(double f)
        {
            double kelvin = ((f - 32) * 5 / 9) + 273.15;
            return kelvin;
        }

        public double KelvinToCelsius(double k)
        {
            double celsius = k - 273.15;
            return celsius;
        }

        public double KelvinToFahrenheit(double k)
        {
            double kelvin = ((k - 273.15) * 5 / 9) + 32;
            return kelvin;

        }
    }
}

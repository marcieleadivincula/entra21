using System;

namespace ExerciciosFunction01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 1 - Function");

            //1) Escreva uma função que receba dois números inteiros retorne o menor número
            Program pro = new Program();
            int x, y;
            x = Convert.ToInt32(Console.In.ReadLine());
            y = Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("Este é o menor deles \n" + pro.Compara(x, y));
            Console.In.ReadLine();

            //2) Faça uma função que recebe um valor inteiro e verifica se o valor é par. A função deve retornar 1 se o número for par e 0 se for ímpar
            //Program pro = new Program();
            Console.Write("Digite um número qualquer: ");
            int numero = Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("RESULTADO: " + pro.EhPar(numero));

            //3) Faça uma função que recebe um valor inteiro e verifica se o valor é positivo, negativo ou zero. A função deve retornar 1 para valores positivos, -1 para negativos e 0 para o valor 0.
            //Program pro = new Program();
            Console.Write("Digite um número qualquer: ");
            int num = Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("RESULTADO:: " + pro.VerificaValor(num));

            //4) Faça uma função que retorne a converção de Celsius para Fahrenheit.
            //Program pro = new Program();
            Console.Write("Digite um número qualquer: ");
            int num0 = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine();
            Console.WriteLine(num0 + "C° => F°: " + pro.CelsiusToFahrenheit(num0));
            Console.WriteLine(num0 + "C° => K°: " + pro.CelsiusToKelvin(num0));
            Console.WriteLine(num0 + "F° => C°: " + pro.FahrenheitToCelsius(num0));
            Console.WriteLine(num0 + "F° => K°: " + pro.FahrenheitToKelvin(num0));
            Console.WriteLine(num0 + "K° => C°: " + pro.KelvinToCelsius(num0));
            Console.WriteLine(num0 + "K° => F°: " + pro.KelvinToFahrenheit(num0));

            //5) Escreva uma função que receba 3 notas de um aluno e uma letra. Se a letra for A a função retorna a média aritmética das notas do aluno, se for P, a sua média ponderada (pesos: 5, 3 e 2) e se for M, a sua mediana.
            //Program pro = new Program();
            double[] nota = new double[3];

            //Console.Write("Digite a nota " + i + ": ");
            //nota[i] = Convert.ToDouble(Console.In.ReadLine());
            //Console.Write("Digite a nota 2: ");
            //n2 = Convert.ToDouble(Console.In.ReadLine());
            //Console.Write("Digite a nota 3: ");
            //n3 = Convert.ToDouble(Console.In.ReadLine());

            Console.Write("Digite uma letra qualquer: ");
            string str = Console.In.ReadLine();
            Console.WriteLine();

            //Console.WriteLine("Média = " + pro.Media(vetNotas[nota], str));

            //6) Escreva uma função que recebe 5 valores e retorne o resultado da seguinte fórmula
            //Program pro = new Program();
            double num1, num2, num3, num4, num5;

            Console.Write("Digite o valor 1: ");
            num1 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite o valor 2: ");
            num2 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite o valor 3: ");
            num3 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite o valor 4: ");
            num4 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite o valor 5: ");
            num5 = Convert.ToDouble(Console.In.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Resultado: " + pro.Formula(num1, num2, num3, num4, num5));

            //7) Escreva uma função que retorne a reta da hipotenusa de um triângulo retângulo
            //Program pro = new Program();
            double valor1, valor2, valor3;
            Console.Write("Digite a valor 1: ");
            valor1 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite a valor 2: ");
            valor2 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Digite a valor 3: ");
            valor3 = Convert.ToDouble(Console.In.ReadLine());

            //Console.WriteLine("" + pro.Hipotenusa());

            //8) Escreva uma função que começa pedindo um número N ao usuário e depois pede N números. Afunção deverá mostrar na tela todos esses números ordenados do menor para o maior. Escreva sua própria função de ordenação.
            Program ordenacao = new Program();
            ordenacao.OrdenaNumeros();

            //MEU
            //Program pro = new Program();
            Console.Write("Digite um número: ");
            double numer = Convert.ToDouble(Console.In.ReadLine());

            //Console.WriteLine("Resultado: " + pro.GetNumbers(numer));
        }

        //1
        public int Compara(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        //2
        public int EhPar(int num)
        {
            if (num % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //3
         public int VerificaValor(int valor)
        {
            if (valor > 0)
            {
                return 1;
            }
            else if (valor < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


        //4 
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

        //5
        // public double Media(double[] vetNotas, string letra)
        //{
        //    double mediana = 0, mediaAritmetica = 0, soma = 0, mediaPonderada = 0;

        //    for (int i = 0; i < vetNotas.Length; i++)
        //    {
        //        soma += vetNotas[i];
        //        mediaPonderada = (nota1 + nota2 + nota3) / (nota1 + nota2 + nota3);
        //        mediana = notas[i];
        //    }
        //    mediaAritmetica = soma / 3;

        //    if (letra == "A")
        //    {
        //        return mediaAritmetica;
        //    }
        //    else if (letra == "P")
        //    {
        //        return mediaPonderada;
        //    }
        //    else if (letra == "M")
        //    {
        //        return mediana;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Valor inválido, tente novamente!");
        //    }
        //  }

        //6
         public double Formula(double a, double b, double c, double d, double e)
        {
            double resultado = (a + b + c) / (d * e);
            return resultado;
        }

        //7
        public double Hipotenusa(double a, double b, double c)
        {
            double quadradoA = a * a;
            double quadradoB = b * b;
            double quadradoC = c * c;
            quadradoC = quadradoA + quadradoB;
            double hipotenusa = quadradoA + quadradoB;

            return hipotenusa;
        }

        //8
        public void OrdenaNumeros()
        {
            Console.Write("Diga quantos números deseja inserir: ");
            int numero = Convert.ToInt32(Console.In.ReadLine());

            int[] vetNumeros = new int[numero];

            for (int i = 0; i < vetNumeros.Length; i++)
            {
                vetNumeros[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            //Escreve o vetor na tela desordenado
            for (int i = 0; i < vetNumeros.Length; i++)
            {
                Console.Write(vetNumeros[i] + " ");
            }

            for (int i = 0; i < vetNumeros.Length; i++) //seta que vai pra direita
            {
                for (int j = 0; j > 0; j++) //seta que vai pra esquerda
                {
                    if (vetNumeros[j - 1] > vetNumeros[j])
                    {
                        int temp = vetNumeros[j];
                        vetNumeros[j] = vetNumeros[j - 1];
                        vetNumeros[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();
            //Printa o vetor organizado
            for (int i = 0; i < vetNumeros.Length; i++)
            {
                Console.WriteLine(vetNumeros[i] + " ");
            }
        }

        //MEU 8
        //public double GetNumbers(double num)
        //{
        //    //double 
        //    for (int i = 0; i < num; i++)
        //    {

        //    }
        //}
    }
}

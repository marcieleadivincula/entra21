using System;

namespace ExerciciosDeSe01Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeSe01Exerc04");
            //4) Receba três valores, apresente na tela apenas o maior deles

            try
            {
                Console.Write("Valor de A: ");
                int a = Convert.ToInt32(Console.In.ReadLine());
                Console.Write("Valor de B: ");
                int b = Convert.ToInt32(Console.In.ReadLine());
                Console.Write("Valor de C: ");
                int c = Convert.ToInt32(Console.In.ReadLine());

                if (a > b && a > c)
                {
                    Console.WriteLine(a);
                }
                else if (b > a && b > c)
                {
                    Console.WriteLine(b);
                }
                else if (c > a && c > b)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine("São iguais!");
                }
            }
            catch (StackOverflowException soe)
            {
                Console.WriteLine("Overflow. {0}", soe.Message);
            }
            catch (InvalidCastException ie)
            {
                Console.WriteLine("Invalid casting. {0}", ie.Message);
            }
            catch (FormatException f)
            {
                Console.WriteLine("{0} Format Exception caught.", f.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex.Message);

                Console.WriteLine("ToString()     : " + ex.ToString());
                Console.WriteLine("Message        : " + ex.Message);
                Console.WriteLine("Source         : " + ex.Source);
                Console.WriteLine("HelpLink       : " + ex.HelpLink);
                Console.WriteLine("TargetSite     : " + ex.TargetSite);
                Console.WriteLine("Inner Exception: " + ex.InnerException);
                Console.WriteLine("Stack Trace    : " + ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            //int result = (a > b && a > c) ? a : (b > a && b > c) ? b : (c > a && c > b) ? c : (a == b && b == c) ? 0 : -1;
            //Console.WriteLine(result);
        }
    }
}

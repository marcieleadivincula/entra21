using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula do dia 06 de agosto de 2020
            string[][] matriz = new string[3][];
            matriz[0] = new string[4];
            matriz[1] = new string[5];
            matriz[2] = new string[1];

            //para percorrer toda a matriz
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = i + "." + j;
                }
            }

            //Exemplo matriz
            string[][] matrizes = new string[3][];

            for (int k = 0; k < matrizes.Length; k++)
            {
                matrizes[k] = new string[3];
            }

            for (int i = 0; i < matrizes.Length; i++)
            {
                for (int j = 0; j < matrizes[i].Length; j++)
                {
                    matrizes[i][j] = i + "." + j + "|";
                    Console.WriteLine(matrizes[i][j]);
                }
                Console.WriteLine();
            }

            //Exemplo matriz 2x4
            string[][] matriz2 = new string[2][];

            for (int i = 0; i < matriz2.Length; i++)
            {
                matriz2[i] = new string[4];
            }


            for (int i = 0; i < matriz2.Length; i++)
            {
                for (int j = 0; j < matriz2[i].Length; j++)
                {
                    matriz2[i][j] = "oi ||";
                    Console.Write(matriz2[i][j]);
                }
                Console.WriteLine();
            }

            //Exemplo
            int[][] matrix = new int[3][];
            int vF = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[3];
            }


            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = 3;
                    vF += matrix[i][j];
                }

            }
            Console.WriteLine(vF);


            //Exemplo
            int[][] matrix2 = new int[3][];
            int vF2 = 0;

            for (int i = 0; i < matrix2.Length; i++)
            {
                matrix2[i] = new int[3];
            }


            for (int i = 0; i < matrix2.Length; i++)
            {
                for (int j = 0; j < matrix2[i].Length; j++)
                {
                    matrix2[i][j] = j;
                    vF2 += matrix2[i][j];
                }

            }
            Console.WriteLine(vF2);

            //Exemplo
            int[][] matrix3 = new int[3][];
            int vF3 = 0;

            for (int i = 0; i < matrix3.Length; i++)
            {
                matrix3[i] = new int[3];
            }


            for (int i = 0; i < matrix3.Length; i++)
            {
                for (int j = 0; j < matrix3[i].Length; j++)
                {
                    if (i == j)
                    {
                        matrix3[i][j] = 10;
                        vF3 += matrix3[i][j];
                    }
                }

            }
            Console.WriteLine(vF3);

            //Exemplo
            int[][] matriz3 = new int[3][];
            int vF4 = 0;

            for (int i = 0; i < matriz3.Length; i++)
            {
                matriz3[i] = new int[3];
            }


            for (int i = 0; i < matriz3.Length; i++)
            {
                for (int j = 0; j < matriz3[i].Length; j++)
                {
                    matriz3[i][0] = 10;
                    vF4 += matriz3[i][2];
                }

            }
            Console.WriteLine(vF4); // 0


            //DICAS
            //Para acrescentar um número inteiro com zeros à esquerda com um comprimento específico
            byte byteValue = 254;
            short shortValue = 10342;
            int intValue = 1023983;
            long lngValue = 6985321;
            ulong ulngValue = UInt64.MaxValue;

            // Display integer values by calling the ToString method.
            Console.WriteLine("{0,22} {1,22}", byteValue.ToString("D8"), byteValue.ToString("X8"));
            Console.WriteLine("{0,22} {1,22}", shortValue.ToString("D8"), shortValue.ToString("X8"));
            Console.WriteLine("{0,22} {1,22}", intValue.ToString("D8"), intValue.ToString("X8"));
            Console.WriteLine("{0,22} {1,22}", lngValue.ToString("D8"), lngValue.ToString("X8"));
            Console.WriteLine("{0,22} {1,22}", ulngValue.ToString("D8"), ulngValue.ToString("X8"));
            Console.WriteLine();

            // Display the same integer values by using composite formatting.
            Console.WriteLine("{0,22:D8} {0,22:X8}", byteValue);
            Console.WriteLine("{0,22:D8} {0,22:X8}", shortValue);
            Console.WriteLine("{0,22:D8} {0,22:X8}", intValue);
            Console.WriteLine("{0,22:D8} {0,22:X8}", lngValue);
            Console.WriteLine("{0,22:D8} {0,22:X8}", ulngValue);
            // The example displays the following output:
            //                     00000254               000000FE
            //                     00010342               00002866
            //                     01023983               000F9FEF
            //                     06985321               006A9669
            //         18446744073709551615       FFFFFFFFFFFFFFFF
            //
            //                     00000254               000000FE
            //                     00010342               00002866
            //                     01023983               000F9FEF
            //                     06985321               006A9669
            //         18446744073709551615       FFFFFFFFFFFFFFFF
            //         18446744073709551615       FFFFFFFFFFFFFFFF

            //Para acrescentar um número inteiro com uma determinada quantidade de zeros à esquerda
            int value = 160934;
            int decimalLength = value.ToString("D").Length + 5;
            int hexLength = value.ToString("X").Length + 5;
            Console.WriteLine(value.ToString("D" + decimalLength.ToString()));
            Console.WriteLine(value.ToString("X" + hexLength.ToString()));
            // The example displays the following output:
            //       00000160934
            //       00000274A6

            int value2 = 160934;
            int decimalLength2 = value2.ToString("D").Length + 5;
            int hexLength2 = value2.ToString("X").Length + 5;
            Console.WriteLine(value2.ToString("D" + decimalLength2.ToString()));
            Console.WriteLine(value2.ToString("X" + hexLength2.ToString()));
            // The example displays the following output:
            //       00000160934
            //       00000274A6

            //Para acrescentar um valor numérico com zeros à esquerda com comprimento específico
            string fmt = "00000000.##";
            int intValue3 = 1053240;
            decimal decValue = 103932.52m;
            float sngValue = 1549230.10873992f;
            double dblValue = 9034521202.93217412;

            // Display the numbers using the ToString method.
            Console.WriteLine(intValue3.ToString(fmt));
            Console.WriteLine(decValue.ToString(fmt));
            Console.WriteLine(sngValue.ToString(fmt));
            Console.WriteLine(dblValue.ToString(fmt));
            Console.WriteLine();

            // Display the numbers using composite formatting.
            string formatString = " {0,15:" + fmt + "}";
            Console.WriteLine(formatString, intValue);
            Console.WriteLine(formatString, decValue);
            Console.WriteLine(formatString, sngValue);
            Console.WriteLine(formatString, dblValue);
            // The example displays the following output:
            //       01053240
            //       00103932.52
            //       01549230
            //       9034521202.93
            //
            //               01053240
            //            00103932.52
            //               01549230
            //          9034521202.93

            //Para acrescentar um valor numérico com uma determinada quantidade de zeros à esquerda
            double[] dblValues = { 9034521202.93217412, 9034521202 };
            foreach (double dblValue2 in dblValues)
            {
                string decSeparator = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
                string fmt2, formatString2;

                if (dblValue2.ToString().Contains(decSeparator))
                {
                    int digits = dblValue2.ToString().IndexOf(decSeparator);
                    fmt2 = new String('0', 5) + new String('#', digits) + ".##";
                }
                else
                {
                    fmt2 = new String('0', dblValue2.ToString().Length);
                }
                formatString2 = "{0,20:" + fmt2 + "}";

                Console.WriteLine(dblValue2.ToString(fmt2));
                Console.WriteLine(formatString2, dblValue2);
            }
            // The example displays the following output:
            //       000009034521202.93
            //         000009034521202.93
            //       9034521202
            //                 9034521202
        }
    }
}

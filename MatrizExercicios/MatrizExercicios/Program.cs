using System;

namespace MatrizExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIOS

            //1) Crie uma matriz 3x3 de inteiros e coloque o valor 4 em todos os espaços da matriz
            //int[][] matrizInteiros = new int[3][];

            //for (int i = 0; i < matrizInteiros.Length; i++)
            //{
            //    matrizInteiros[i] = new int[3];

            //    for (int j = 0; j < matrizInteiros[i].Length; j++)
            //    {
            //        matrizInteiros[i][j] = 4;
            //        Console.Write("|" + matrizInteiros[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //2) Crie uma matriz 2x4 de inteiros, peça ao usuário inserir valor em todos os espaços, em seguida, some todos os valores da matriz e mostre o resultado na tela
            //int[][] matriz2x4 = new int[2][];
            //int resultado = 0;

            //for (int i = 0; i < matriz2x4.Length; i++)
            //{
            //    matriz2x4[i] = new int[4];

            //    for (int j = 0; j < matriz2x4[i].Length; j++)
            //    {
            //        Console.Write("Número: ");
            //        matriz2x4[i][j] = Convert.ToInt32(Console.In.ReadLine());

            //        resultado += matriz2x4[i][j];

            //        Console.WriteLine("Soma: " + resultado);
            //    }
            //    Console.WriteLine();
            //}

            //3) Crie uma matriz 2x4 de inteiros com valores aleatórios entre 0 e 30, em seguida, crie uma matriz 4x2 para armazenar os valores dessa matriz (NxM se torna MxN)
            //int[][] matriz2x4MxN = new int[2][];
            //int[][] matriz4x2NxM = new int[4][];
            //Random ran = new Random();

            //for (int i = 0; i < matriz2x4MxN.Length; i++)
            //{
            //    matriz2x4MxN[i] = new int[4];

            //    for (int j = 0; j < matriz2x4MxN[i].Length; j++)
            //    {
            //        matriz2x4MxN[i][j] = ran.Next(0, 31);
            //        Console.Write("|" + matriz2x4MxN[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < matriz4x2NxM.Length; i++)
            //{
            //    matriz4x2NxM[i] = new int[2];

            //    for (int j = 0; j < matriz4x2NxM[i].Length; j++)
            //    {
            //        matriz4x2NxM[i][j] = matriz2x4MxN[j][i];

            //        Console.Write("|" + matriz4x2NxM[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //4) Crie uma matriz 3x6, e peça para o usuário preenche-la, após isso, mostre o maior valor de cada coluna
            //int[][] matriz3x6 = new int[3][];
            //int resultado = 0, maiorValor = 0;

            //for (int i = 0; i < matriz3x6.Length; i++)
            //{
            //    matriz3x6[i] = new int[6];

            //    for (int j = 0; j < matriz3x6[i].Length; j++)
            //    {
            //        Console.Write("Número: ");
            //        matriz3x6[i][j] = Convert.ToInt32(Console.In.ReadLine());
            //        resultado = j;

            //        if (matriz3x6[i][j] > maiorValor)
            //        {
            //            maiorValor = matriz3x6[i][j];
            //        }
            //        Console.WriteLine("L" + i + "| C" + j);
            //        Console.WriteLine("L" + matriz3x6[i][j] + "| C" + matriz3x6[i][j]);
            //        Console.WriteLine();
            //        Console.WriteLine("O maior valor de " + i + "." + j + " = " + maiorValor);
            //    }
            //    Console.WriteLine();
            //}


            //5) Crie uma matriz 5x5 para simular a compra de um assento para cinema, mostre toda a matriz para apresentar quais assentos estao vazios ou preenchidos, após isso, o usuario escolhe qual assento deseja (não importa o método para escolher) se o assento escolhido estiver vazio preencha o assento, se estiver preenchido ou nao fazer parte do cinema (ex: assento na linha 6 coluna 3) diga que o assento é inválido e peça para escolher outro assento
            int[][] matriz5x5 = new int[5][];
            string fmt = "00.##";
            int assento, intValue = 01, disponivel = matriz5x5.Length * 5;

            Console.WriteLine("Assentos disponíveis:");
            while (intValue <= disponivel)
            {
                Console.Write("|" + intValue);
                Console.Write("|");
                intValue++;

                if (intValue == 06 || intValue == 11 || intValue == 16 || intValue == 21)
                {
                    Console.WriteLine();
                }

                if (intValue <= 9)
                {
                    Console.Write(intValue.ToString(fmt));
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < matriz5x5.Length; i++)
            {
                matriz5x5[i] = new int[5];

                for (int j = 0; j < matriz5x5[i].Length; j++)
                {
                    Console.Write("Número de assento: ");
                    assento = Convert.ToInt32(Console.In.ReadLine());

                    if (matriz5x5[i][j] == 0)
                    {
                        matriz5x5[i][j] = assento;
                        if (matriz5x5[i][j] <= 25)
                        {
                            Console.WriteLine(matriz5x5[i][j]);
                        }
                        Console.WriteLine(matriz5x5[i][j]);
                    }
                    else
                    {
                        Console.WriteLine("Assento inválido, tente novamente!");

                        Console.Write("Escolha outro assento: ");
                        assento = Convert.ToInt32(Console.In.ReadLine());
                    }
                }
            }


            //6) A proway esta criando um sistema de login, para isso, crie uma matriz 5x2, uma linha para User e outra para Password, por padrão, tem a senha do administrador que é : user: Admin   password: @proway , caso um usuario faça login, avise que o login foi efetuado com sucesso e em seguida faça “logout” (volta pro inicio onde pede user e password) caso o login foi feito pelo administrador, apareça as seguintes opções:
            //1 - Criar User: para criar, mostre os users atuais, peça ao usuário qual user ele deseja armazenar um novo user e password, em seguida peça o user e password a ser armazenado.
            //2 - Deletar User: para deletar, mostre os users atuais, em seguida, peça qual user deseja - se deletar, após isso, delete o user
            //3 - LogOut : volte para o inicio onde pede user e password


            //7) Imagine que uma escola deseja cadastrar alunos para isso ,crie uma matriz 3x4, uma linha para os nomes,outra para cpf, e outra para idade, primeiro, mostre para o usuario em ordem, os alunos ja armazenados, entao, o usuario escolhe em qual lugar ele deseja armazenar um novo aluno (ex: usuario escolheu 2 , pede-se um nome,cpf e idade, entao, coloque tudo isso na 2° coluna da matriz) ao terminar de colocar aluno, pede - se ao usuario se deseja colocar um novo aluno ou sair.


            //DESAFIO: 8) Desenvolva o jogo da velha usando uma matriz 3x3(pvp)
            //int playerX = 1, playerY = 2, linha, coluna, getLine, getColumn;
            ////string x = "[x]", y = "[0]";

            //int[][] matriz3x3 = new int[3][];
            //string[] arrOption = { "X", "0", "sair" };
            //int[] num = { 0, 1 };

            //while (arrOption.Length != 2)
            //{
            //    for (int i = 0; i < matriz3x3.Length; i++)
            //    {
            //        matriz3x3[i] = new int[3];

            //        for (int j = 0; j < matriz3x3[i].Length; j++)
            //        {
            //            Console.Write("Digite o número da linha: ");
            //            getLine = Convert.ToInt32(Console.In.ReadLine());
            //            Console.Write("Digite o número da coluna: ");
            //            getColumn = Convert.ToInt32(Console.In.ReadLine());

            //            if (playerX == 1 && getColumn == matriz3x3[i][j] && getLine == matriz3x3[i][j])
            //            {
            //                matriz3x3[i][j] = matriz3x3[i][j];
            //                Console.WriteLine("[" + i + "]");
            //            }
            //            else if (playerX == 1 && getColumn == matriz3x3[i][j] && getLine == matriz3x3[i][j])
            //            {
            //                matriz3x3[i][j] = matriz3x3[i][j];
            //                Console.WriteLine("[" + i + "]");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Erro, tente novamente");
            //                break;
            //            }

            //            while (playerX == matriz3x3[i][j] || playerY == matriz3x3[i][j])
            //            {

            //            }
            //        }
            //    }
            //}

        }
    }
}

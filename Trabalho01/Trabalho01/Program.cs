using System;

namespace Trabalho01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalho 01");

            int[][] estoque; //a matriz que você irá criar
            GeraBD log = new GeraBD(); //uma instância do objeto que gerará a matriz inicial
            estoque = log.GeraMatriz(); //a matriz que você criou recebendo a matriz gerada

            int categoria;
            int menu = Convert.ToInt32(Console.In.ReadLine());
            while (menu != 4)
            {
                Console.WriteLine("Selecione uma opção do menu:");
                Console.WriteLine("1 - Adicionar um Produto");
                Console.WriteLine("2 - Retirar um Produto");
                Console.WriteLine("3 - Ver o estoque");
                Console.WriteLine("4 - Fechar Programa");
                Console.WriteLine();

                if (menu == 1)
                {
                    //1- Adicionar: Peça para o usuário qual a categoria do produto e em seguida coloque no estoque na primeira posição livre respeitando a organização, caso não tenha espaço livre, diga que não consegue armazenar 

                    Console.WriteLine("Selecione a categoria:");
                    Console.Write("Categoria: ");
                }
                else if (menu == 2)
                {
                    //2- Retirar: Mostre o estoque e peça qual o índice ele deseja retirar, peça a linha e coluna onde está o produto desejado

                    Console.WriteLine("Selecione a categoria:");
                    Console.Write("Categoria: ");
                    categoria = Convert.ToInt32(Console.In.ReadLine());
                }
                else if (menu == 3)
                {
                    //3- Ver o estoque: Mostre o estoque pro usuario
                    Console.WriteLine("Selecione a categoria:");
                    Console.Write("Categoria: ");
                    categoria = Convert.ToInt32(Console.In.ReadLine());
                }
                else if (menu == 4)
                {
                    //4 - Agradeça pelo uso e encerre o programa.
                    Console.WriteLine("Obrigado por usar o nosso programa!");
                    Console.WriteLine("Programa encerrado...");
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente!");
                    Console.WriteLine("Selecione uma opção do menu:");
                    Console.WriteLine("1 - Adicionar um Produto");
                    Console.WriteLine("2 - Retirar um Produto");
                    Console.WriteLine("3 - Ver o estoque");
                    Console.WriteLine("4 - Fechar Programa");
                    Console.WriteLine();

                    menu = Convert.ToInt32(Console.In.ReadLine());
                    categoria = Convert.ToInt32(Console.In.ReadLine());
                }
                menu = Convert.ToInt32(Console.In.ReadLine());
            }

            //switch (menu)
            //{
            //    case 1:  //1 - Adicionar um Produto
            //        break;
            //    case 2:  //2 - Retirar um Produto
            //        break;
            //    case 3:  //3 - Ver o estoque
            //        break;
            //    case 4:  // 4 - Fechar Programa
            //        break;
            //    default:
            //        Console.WriteLine("Opção inválida! Tente novamente!");
            //        break;
            //}

            //switch (categoria)
            //{
            //    case 0:  //0 - vazio
            //        break;
            //    case 1:  //1 - Alimento
            //        break;
            //    case 2:  //2 - Higiene Pessoal
            //        break;
            //    case 3:  //3 - Limpeza
            //        break;
            //    case 4:  // 4 - Utensílios
            //        break;
            //    default:
            //        Console.WriteLine("Opção inválida! Tente novamente!");
            //        break;
            //}

            //There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:
            //string[] _categoria = { "Volvo", "BMW", "Ford", "Mazda" };
            //Array.Sort(_categoria);
            //foreach (string i in _categoria)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] _nomeProduto = { 5, 1, 8, 9 };
            //Array.Sort(_nomeProduto);
            //foreach (int i in _nomeProduto)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(myNumbers.Max());  // returns the largest value
            //Console.WriteLine(myNumbers.Min());  // returns the smallest value
           // Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

        }
    }
}

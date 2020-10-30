using System;

namespace ExerciciosOOpt401Exerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de OOpt - 401");
            //7) Cria 4 subClasses chamado Cachorro com nome, dopamina, conforto e herda Comportamento. Após isso, crie esses cachorros e crie o seguinte menu:
            //1 – Comer
            //2 – Descansar
            //3 – Sair
            //1: Pergunte qual cachorro irá comer e quanto.
            //2: Pergunte qual cachorro irá dormir e quanto.
            //3: Encerre o programa.

            Cachorro[] dog = new Cachorro[2];
            //string opcao = Console.In.ReadLine();
            int menu, quanto = 0, cachorro;

            for (int i = 0; i < dog.Length; i++)
            {
                dog[i] = new Cachorro();

                Console.WriteLine("Insira os dados do cachorro: ");
                Console.Write("Nome: ");
                dog[i].Nome = Console.In.ReadLine();
                Console.Write("Dopamina: ");
                dog[i].Dopamina = int.Parse(Console.In.ReadLine());
                Console.Write("Conforto: ");
                dog[i].Conforto = int.Parse(Console.In.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < dog.Length; i++)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("\t1 - Comer");
                Console.WriteLine("\t2 - Descansar");
                Console.WriteLine("\t3 - Sair");

                Console.Write("Opção: ");
                menu = int.Parse(Console.In.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Qual cachorro irá comer?");
                        cachorro = int.Parse(Console.In.ReadLine());
                        Console.Write("Quanto? ");
                        quanto = int.Parse(Console.In.ReadLine());



                        //Console.WriteLine(dog[i].Comer(quanto));
                        break;
                    case 2:
                        Console.WriteLine("Qual cachorro irá dormir?");
                        cachorro = int.Parse(Console.In.ReadLine());
                        Console.Write("Quanto? ");
                        quanto = int.Parse(Console.In.ReadLine());



                        //Console.WriteLine(dog[i].Descansar(quanto));
                        break;
                    case 3:
                        Console.WriteLine("SAINDO...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                //if (menu == 1)
                //{
                //    Console.Write("Quanto o cachorro vai comer? ");
                //    quanto = int.Parse(Console.In.ReadLine());
                //}
                //else if (menu == 2)
                //{
                //    Console.Write("Quanto o cachorro irá dormir? ");
                //    quanto = int.Parse(Console.In.ReadLine());
                //}
                //else if (menu == 3)
                //{
                //    break;
                //}
                //else
                //{
                //    Console.WriteLine("Opção inválida! Tente novamente");

                //    Console.WriteLine("Escolha uma opção:");
                //    Console.WriteLine("\t1 - Comer");
                //    Console.WriteLine("\t2 - Descansar");
                //    Console.WriteLine("\t3 - Sair");

                //    Console.Write("Opção: ");
                //    menu = int.Parse(Console.In.ReadLine());
                //}
                //Console.WriteLine();

                //Console.WriteLine("Qual cachorro irá comer ou descansar?");
                //Console.Write("Chachorro: ");
                //cachorro = Convert.ToInt32(Console.In.ReadLine());

                //if (cachorro >= 0 && cachorro != 3)
                //{
                //    Console.WriteLine("Qual cachorro irá comer ou descansar?");
                //    Console.Write("Chachorro: ");
                //    cachorro = Convert.ToInt32(Console.In.ReadLine());
                //}
                //Console.WriteLine();
            }

            for (int i = 0; i < dog.Length; i++)
            {
                Console.WriteLine("Nome: {0} Dopamina: {1} \nConforto: {2} Comer: {3} Descansar: {4} ", dog[i].Nome, dog[i].Dopamina, dog[i].Conforto, dog[i].Comer(quanto), dog[i].Descansar(quanto));
                Console.WriteLine();
            }
        }
    }
}

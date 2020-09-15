using System;

namespace ExerciciosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");

            //1
            //Pessoa pessoa = new Pessoa();
            //pessoa.nome = Console.In.ReadLine();
            //pessoa.idade = Convert.ToInt32(Console.In.ReadLine());
            //pessoa.salario = Convert.ToDouble(Console.In.ReadLine());

            //Console.WriteLine("Nome: " + pessoa.nome + "\nIdade: " + pessoa.idade + "\nSalário: " + pessoa.salario);


            //2
            Dog[] dog = new Dog[3];

            for (int i = 0; i < dog.Length; i++)
            {
                Console.WriteLine("Insira o {0}° cão", (i+1));
                dog[i] = new Dog();

                Console.Write("Nome do cachorro: ");
                dog[i].nome = Console.In.ReadLine();
                Console.Write("Nome do dono: ");
                dog[i].nomeDono = Console.In.ReadLine();
                Console.Write("Idade do cachorro: ");
                dog[i].idade = Convert.ToInt32(Console.In.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < dog.Length; i++)
            {
                if (dog[i].EhSeis() == true)
                {
                    Console.WriteLine("{0} {1} {2}", dog[i].nome, dog[i].nomeDono, dog[i].idade);
                }
                else
                {
                    break;
                }
            }
        }
    }
}

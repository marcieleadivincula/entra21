using System;

namespace MyPets
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dog = new Dog[2];
            for (int i = 0; i < dog.Length; i++)
            {
                Console.Write("Digite o nome do cão: ");
                dog[i].nomeCachorro = Console.In.ReadLine();
                Console.Write("Digite o nome do dono: ");
                dog[i].nomeDono = Console.In.ReadLine();
                Console.Write("Digite a idade do cão: ");
                dog[i].idade = Convert.ToInt32(Console.In.ReadLine());
                Console.WriteLine();

                if (dog[i].idade >= 6)
                {
                    Console.WriteLine("Nome do cachorro: " + dog[i].nomeCachorro);
                    Console.WriteLine("Nome do dono: " + dog[i].nomeDono);
                    Console.WriteLine("Idade do cachorro: " + dog[i].idade);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public struct Dog
        {
            public string nomeCachorro;
            public string nomeDono;
            public int idade;
        }
    }
}

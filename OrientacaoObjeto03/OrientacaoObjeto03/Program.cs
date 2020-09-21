using System;

namespace OrientacaoObjeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - Lista 3");
            //1
            Dog[] dogs = new Dog[4];

            for (int i = 0; i < dogs.Length; i++)
            {
                Console.Write("Insira o nome do cão");
                string nome = Console.In.ReadLine();
                Console.Write("Insira a raca");
                string raca = Console.In.ReadLine();
                Console.Write("Insira a idade");
                int idade = Convert.ToInt32(Console.In.ReadLine());
                dogs[i] = new Dog(nome, raca, idade);
                //dogs[i].SetNome(nome);
                //dogs[i].SetRaca(raca);
                //dogs[i].SetIdade(idade);
            }

            for (int i = 0; i < dogs.Length; i++)
            {
                Console.WriteLine("Nome: {0}, Raça: {1}, Idade: {2}", dogs[i].GetNome(), dogs[i].GetRaca(), dogs[i].GetIdade());
            }

            Console.WriteLine("Execução finalizada! Tecle enter para sair...");
        }
    }
}

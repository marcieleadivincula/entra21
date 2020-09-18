using System;
using System.Globalization;
using System.Reflection;

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
            //Dog[] dog = new Dog[3];

            //string result = GetDogDetails("Lulu", "Maria", 5);
            //Console.WriteLine(result);

            //for (int i = 0; i < dog.Length; i++)
            //{
            //    Console.WriteLine("Insira o {0}° cão", (i+1));
            //    dog[i] = new Dog();

            //    Console.Write("Nome do cachorro: ");
            //    dog[i].nome = Console.In.ReadLine();
            //    Console.Write("Nome do dono: ");
            //    dog[i].nomeDono = Console.In.ReadLine();
            //    Console.Write("Idade do cachorro: ");
            //    dog[i].idade = Convert.ToInt32(Console.In.ReadLine());
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < dog.Length; i++)
            //{
            //    if (dog[i].idade > 6)
            //    {
            //        Console.WriteLine("{0} {1} {2}", dog[i].nome, dog[i].nomeDono, dog[i].idade);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //3
            //Person[] pessoa = new Person[5];
            //int homemVelho = 0, mulherVelha = 0;

            //for (int i = 0; i < pessoa.Length; i++)
            //{
            //    pessoa[i] = new Person();

            //    Console.Write("Insira o nome: ");
            //    pessoa[i].nome = Console.In.ReadLine();
            //    Console.Write("Insira a idade: ");
            //    pessoa[i].idade = Convert.ToInt32(Console.In.ReadLine());
            //    Console.Write("Insira o gênero: ");
            //    pessoa[i].genero = Convert.ToChar(Console.In.ReadLine());
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < pessoa.Length; i++)
            //{
            //    if (pessoa[i].idade > homemVelho && pessoa[i].SeuGenero() == false)
            //    {
            //        homemVelho++;
            //    }

            //    if (pessoa[i].idade > mulherVelha && pessoa[i].SeuGenero() == true)
            //    {
            //        mulherVelha++;
            //    }

            //    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].nome, pessoa[i].idade, pessoa[i].genero);
            //}

            //if (indiceMulher != -1)
            //{
            //    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].nome, pessoa[i].idade, pessoa[i].genero);
            //}

            //if (indiceHomem != -1)
            //{
            //    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].nome, pessoa[i].idade, pessoa[i].genero);
            //}

            //4
            //Animal[] animal = new Animal[3];

            //for (int i = 0; i < animal.Length; i++)
            //{
            //    animal[i] = new Animal();

            //    Console.Write("Insira o nome do animal: ");
            //    animal[i].nome = Console.In.ReadLine();
            //    Console.Write("Insira a espécie do animal: ");
            //    animal[i].especie = Console.In.ReadLine();
            //    Console.Write("Insira quanto tempo no zoo em dias: ");
            //    animal[i].tempoZoo = Convert.ToInt32(Console.In.ReadLine());
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < animal.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (animal[j - 1].tempoZoo > animal[j].tempoZoo) //ordem crescente
            //        {
            //            Animal temp = animal[j];
            //            animal[j] = animal[j - 1];
            //            animal[j - 1] = temp;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}

            //for (int i = 0; i < animal.Length; i++)
            //{
            //    Console.WriteLine("Nome: {0}, Espécie: {1}, Tempo no Zoo: {2}", animal[i].nome, animal[i].especie, animal[i].tempoZoo);
            //}

            //5
            //Produto[] prod = new Produto[5];

            //for (int i = 0; i < prod.Length; i++)
            //{
            //    prod[i] = new Produto();

            //    Console.Write("Insira o nome do produto: ");
            //    prod[i].nome = Console.In.ReadLine();
            //    Console.Write("Insira o preço do produto: ");
            //    prod[i].preco = Convert.ToDouble(Console.In.ReadLine());
            //    Console.Write("Insira a quantidade em estoque do produto: ");
            //    prod[i].quantidade = Convert.ToInt32(Console.In.ReadLine());
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < prod.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (prod[j-1].quantidade < prod[j].quantidade) //ordem crescente
            //        {
            //            Produto temp = prod[j-1];
            //            prod[j - 1] = prod[j];
            //            prod[j] = temp;
            //        }

            //        //if (prod[j - 1].quantidade > prod[j].quantidade) //ordem descrescente
            //        //{
            //        //    Produto temp = prod[j - 1];
            //        //    prod[j - 1] = prod[j];
            //        //    prod[j] = temp;
            //        //}
            //    }
            //}

            //for (int i = 0; i < prod.Length; i++)
            //{
            //    Console.WriteLine("Nome do produto: {0}, Preço do produto: {1}, Quantida em estoque: {2}", prod[i].nome, prod[i].preco, prod[i].quantidade);
            //}

            //6
            Empregado[] empreg = new Empregado[3];

            for (int i = 0; i < empreg.Length; i++)
            {
                empreg[i] = new Empregado();

                Console.Write("Insira o nome do empregado: ");
                empreg[i].nome = Console.In.ReadLine();
                Console.Write("Insira o salário do empregado: ");
                empreg[i].salario = Convert.ToDouble(Console.In.ReadLine());
                Console.Write("Insira o CPF do empregado: ");
                empreg[i].cpf = Console.In.ReadLine();
                Console.WriteLine();
            }

            for (int i = 0; i < empreg.Length; i++)
            {
                if (empreg[i].salario < 1500.0)
                {
                    empreg[i].salario += 1.20;
                }

                for (int j = i; j > 0; j--)
                {
                    if (empreg[j - 1].salario > empreg[j].salario)
                    {
                        Empregado temp = empreg[j - 1];
                        empreg[j - 1] = empreg[j];
                        empreg[j] = temp;
                    }
                }
            }

            for (int i = 0; i < empreg.Length; i++)
            {
                Console.WriteLine("Nome: {0}, Salário: {1}, CPF: {2}", empreg[i].nome, empreg[i].salario, empreg[i].cpf);
            }
        }

        //public static string GetDogDetails(string nome, string nomeDono, int idade)
        //{
        //    string info = string.Format("Nome do dog: {0}, Nome do dono: {1}, Idade: {2}", nome, nomeDono, idade);
        //    return info;
        //}
    }
}

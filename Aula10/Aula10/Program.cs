using System;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pes = new Pessoa();
            pes.nome = "Maria Alves";
            pes.idade = 65;
            pes.salario = 1578.65;

            Console.WriteLine("Nome: " + pes.nome + "\nIdade" + pes.nome + "\nSalário: " + pes.salario);

            //exerc 03 01
            int genero;
            int maisVelho = -1, indiceMulherVelha = -1, indiceHomiVelho = -1;
            Pessoa[] pessoa = new Pessoa[5];
            for (int i = 0; i < pessoa.Length; i++)
            {
                pessoa[i] = new Pessoa();
                Console.WriteLine("Diga o nome, idade e gênero da pessoa");
                pessoa[i].nome = Console.In.ReadLine();
                pessoa[i].idade = Convert.ToInt32(Console.In.ReadLine());
                genero = Convert.ToInt32(Console.In.ReadLine());

                if (genero == 0)
                {
                    pessoa[i].genero = false;
                }
                else
                {
                    pessoa[i].genero = true;
                }


            }

            for (int i = 0; i < pessoa.Length; i++)
            {
                if (pessoa[i].genero == false)
                {
                    if (maisVelho < pessoa[i].idade)
                    {
                        maisVelho = pessoa[i].idade;
                        indiceHomiVelho = i;
                    }
                }
            }

            maisVelho = -1;
            for (int i = 0; i < pessoa.Length; i++)
            {
                if (pessoa[i].genero == true)
                {
                    if (maisVelho < pessoa[i].idade)
                    {
                        maisVelho = pessoa[i].idade;
                        indiceMulherVelha = i;
                    }
                }
            }

            if (indiceHomiVelho != -1)
            {
                Console.WriteLine("Homem mais velho " + pessoa[indiceHomiVelho].nome + "\n" + pessoa[indiceHomiVelho].idade);
            }

            if (indiceMulherVelha != -1)
            {
                Console.WriteLine("Mulher mais velha " + pessoa[indiceMulherVelha].nome + "\n" + pessoa[indiceMulherVelha].idade);
            }

            //exerc 04 01
            Animal[] animal = new Animal[3];
            for (int i = 0; i < animal.Length; i++)
            {
                animal[i] = new Animal();
                Console.WriteLine("Insira o nome, espécie e tempo no zoo");
                animal[i].nome = Console.In.ReadLine();
                animal[i].especie = Console.In.ReadLine();
                animal[i].dias = Convert.ToInt32(Console.In.ReadLine());
            }

            for (int i = 0; i < animal.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (animal[j - 1].dias > animal[j].dias)
                    {
                        Animal temp = animal[j];
                        animal[j] = animal[j - 1];
                        animal[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine("Este é o animal " + (i + 1) + "°");
                Console.WriteLine("{0} {1} {2}", animal[i].nome, animal[i].especie, animal[i].dias);
            }
        }

        //public static Array Reorganiza(Array vet, object refe)
        //{
        //    for (int i = 0; i < vet.Length; i++)
        //    {
        //        for (int j = i; j > 0; j--)
        //        {
        //            if (vet[j - 1].dias > vet[j].dias)
        //            {
        //                Animal temp = animal[j];
        //                animal[j] = animal[j - 1];
        //                animal[j - 1] = temp;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //    }
        //}
    }
}
}

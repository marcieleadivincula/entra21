using Microsoft.VisualBasic.FileIO;
using System;
using System.Linq;
using System.Reflection.Metadata;

namespace ExerciciosOOpt101Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 1");
            //3) Crie 5 pessoas com nome,idade e genero. Peça para o usuario preencher as pessoas, em seguida, diga qual o homem mais velho e qual a mulher mais velha.

            //Instância da classe Pessoa com 5 posições 
            Person[] pessoa = new Person[5];
            int homemVelho = -1, mulherVelha = -1;

            //Percorre o vetor pessoa e preenche com os dados digitados pelo usuário
            for (int i = 0; i < pessoa.Length; i++)
            {
                Console.Write("Insira o nome: ");
                string nome = Console.In.ReadLine();
                Console.Write("Insira a idade: ");
                int idade = Convert.ToInt32(Console.In.ReadLine());
                Console.Write("Insira o gênero: ");
                char genero = Convert.ToChar(Console.In.ReadLine());

                pessoa[i] = new Person(nome, idade, genero);
            }

            Console.WriteLine();

            //Verifica qual pessoa é mais velha de cada gênero
            for (int i = 0; i < pessoa.Length; i++)
            {
                try
                {
                    if (pessoa[i].GetIdade() > homemVelho && pessoa[i].SeuGenero() == false)
                    {
                        homemVelho = pessoa[i].GetIdade();
                    }

                    if (pessoa[i].GetIdade() > mulherVelha && pessoa[i].SeuGenero() == true)
                    {
                        mulherVelha = pessoa[i].GetIdade();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error info:" + e.Message);
                    Console.WriteLine("Something went wrong.");
                }
                finally
                {
                    Console.WriteLine("The 'try catch' is finished.");
                }
            }

            //Percorre o vetor pessoa já preenchido com os dados digitados pelo usuário e apresenta na tela
            Console.WriteLine("Pessoas mais velhas: ");
            for (int i = 0; i < pessoa.Length; i++)
            {
                if (homemVelho != -1 && pessoa[i].SeuGenero() == false && pessoa[i].MaisVelho() == true)
                {
                    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].GetNome(), pessoa[i].GetIdade(), pessoa[i].GetGenero());
                }

                if (mulherVelha != -1 && pessoa[i].SeuGenero() == true && pessoa[i].MaisVelho() == true)
                {
                    Console.WriteLine("Nome: {0}, Idade: {1}, Gênero: {2}", pessoa[i].GetNome(), pessoa[i].GetIdade(), pessoa[i].GetGenero());
                }
            }

            for (int i = 0; i < pessoa.Length; i++)
            {
                if (homemVelho != -1)
                {

                }

                if (mulherVelha != -1)
                {

                }

                if (i >= 0 && i < pessoa.Length)
                {

                }
            }

            for (int i = 0; i < pessoa.Length; i++)
            {
                ///TESTES
                ///string[] itemInfo = itemsList[currentRecord].Split(',');

                //string[] itemInfo = null;
                //if (currentRecord - 1 <= itemsList.Length) //or Count if using List
                //    itemInfo = itemsList[currentRecord].Split(',');
                //else
                //    //message: "Index was outside the bounds of the array."



                //    string[] itemInfo = null;
                //if (currentRecord - 1 <= itemsList.Length) //or Count if using List
                //    itemInfo = itemsList[currentRecord].Split(',');
                //else
                ////message: "Index was outside the bounds of the array."

                    //==========================================================
                    //int[] arr = { 1, 5, 78, 3, 59, 13}; 

                    //for (int j = 0; j < arr.Length; j++)
                    //{
                    //    try
                    //    {
                    //        Console.WriteLine(arr[i]);
                    //    }
                    //    catch (IndexOutOfRangeException e)
                    //    {

                    //        Console.WriteLine(e.Message);
                    //        // Set IndexOutOfRangeException to the new exception's InnerException.
                    //        throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
                    //    }
                    //}


                    //==========================================================
                    //var exists = pessoa.ElementAtOrDefault(i) != null;

                    //==========================================================
                    //string[] teste = { "Leite", "Arroz", "Feijão" };

                    //for (int k = 0; k < teste.Length; k++)
                    //{
                    //    if (teste.Contains("Leite"))
                    //    {
                    //        Console.WriteLine("It contains" + teste[k]);
                    //    }

                    //    Console.WriteLine("One or more begin with 'L': {0}", Array.Exists(teste, el => el.StartsWith("L")));
                    //    Console.WriteLine("One or more begin with 'A': {0}", Array.Exists(teste, el => el.StartsWith("A")));
                    //    Console.WriteLine("One or more begin with 'F': {0}", Array.Exists(teste, el => el.StartsWith("F")));
                    //    Console.WriteLine("Is Leite one of the teste? {0}", Array.Exists(teste, el => el == "Leite"));
                    //}


                    //==========================================================
                    //            string[] dinosaurs = { "Tyrannosaurus",
                    //"Amargasaurus",
                    //"Mamenchisaurus",
                    //"Brachiosaurus",
                    //"Deinonychus",
                    //"Tyrannosaurus",
                    //"Compsognathus" };

                    //            Console.WriteLine();
                    //            foreach (string dinosaur in dinosaurs)
                    //            {
                    //                Console.WriteLine(dinosaur);
                    //            }

                    //            Console.WriteLine(
                    //                "\nArray.IndexOf(dinosaurs, \"Tyrannosaurus\"): {0}",
                    //                Array.IndexOf(dinosaurs, "Tyrannosaurus"));

                    //            Console.WriteLine(
                    //                "\nArray.IndexOf(dinosaurs, \"Tyrannosaurus\", 3): {0}",
                    //                Array.IndexOf(dinosaurs, "Tyrannosaurus", 3));

                    //            Console.WriteLine(
                    //                "\nArray.IndexOf(dinosaurs, \"Tyrannosaurus\", 2, 2): {0}",
                    //                Array.IndexOf(dinosaurs, "Tyrannosaurus", 2, 2));


                    //==========================================================
                    //// Create a string array with 3 elements having the same value.
                    //String[] strings = { "the", "quick", "brown", "fox", "jumps",
                    //     "over", "the", "lazy", "dog", "in", "the",
                    //     "barn" };

                    //// Display the elements of the array.
                    //Console.WriteLine("The array contains the following values:");
                    //for (int i = strings.GetLowerBound(0); i <= strings.GetUpperBound(0); i++)
                    //    Console.WriteLine("   [{0,2}]: {1}", i, strings[i]);

                    //// Search for the first occurrence of the duplicated value.
                    //String searchString = "the";
                    //int index = Array.IndexOf(strings, searchString);
                    //Console.WriteLine("The first occurrence of \"{0}\" is at index {1}.",
                    //                  searchString, index);

                    //// Search for the first occurrence of the duplicated value in the last section of the array.
                    //index = Array.IndexOf(strings, searchString, 4);
                    //Console.WriteLine("The first occurrence of \"{0}\" between index 4 and the end is at index {1}.",
                    //                  searchString, index);

                    //// Search for the first occurrence of the duplicated value in a section of the array.
                    //int position = index + 1;
                    //index = Array.IndexOf(strings, searchString, position, strings.GetUpperBound(0) - position + 1);
                    //Console.WriteLine("The first occurrence of \"{0}\" between index {1} and index {2} is at index {3}.",
                    //                  searchString, position, strings.GetUpperBound(0), index);

                    //==========================================================

            }
        }
    }
}

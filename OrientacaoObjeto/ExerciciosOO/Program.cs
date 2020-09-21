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

            //1 Crie uma pessoa que possui nome,idade,cpf e endereço. Peça apara o usuario preencher os dados e após, mostrar na tela
            //Console.Write("Nome: ");
            //string nome = Console.In.ReadLine();
            //Console.Write("Idade: ");
            //int idade = Convert.ToInt32(Console.In.ReadLine());
            //Console.Write("Salário: ");
            //double salario = Convert.ToDouble(Console.In.ReadLine());

            //Console.Write("Logradouro: ");
            //string logradouro = Console.In.ReadLine();
            //Console.Write("Número: ");
            //string numero = Console.In.ReadLine();
            //Console.Write("Bairro: ");
            //string bairro = Console.In.ReadLine();
            //Console.Write("CEP: ");
            //string cep = Console.In.ReadLine();
            //Console.Write("Cidade: ");
            //string cidade = Console.In.ReadLine();
            //Console.Write("Estado: ");
            //string estado = Console.In.ReadLine();
            //Endereco endereco = new Endereco(logradouro, numero, bairro, cep, cidade, estado);

            //Pessoa pessoa = new Pessoa(nome, idade, salario, endereco);

            //Console.WriteLine("Nome: " + pessoa.GetNome() + "\nIdade: " + pessoa.GetIdade() + "\nSalário: " + pessoa.GetSalario() + "\nEndereço: " + pessoa.GetEndereco());


            //2 Crie 3 cachorros que possuem nome, nome do dono e idade. Peça para o usuario preencher os dados e após, mostre na tela apenas os cachorros com mais de 6 anos.
            //Dog[] dogs = new Dog[3];

            //for (int i = 0; i < dogs.Length; i++)
            //{
            //    Console.WriteLine("Insira o {0}° cão", (i + 1));

            //    Console.Write("Nome do cachorro: ");
            //    string nome = Console.In.ReadLine();
            //    Console.Write("Nome do dono: ");
            //    string nomeDono = Console.In.ReadLine();
            //    Console.Write("Idade do cachorro: ");
            //    int idade = Convert.ToInt32(Console.In.ReadLine());

            //    dogs[i] = new Dog(nome, nomeDono, idade);
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < dogs.Length; i++)
            //{
            //    if (dogs[i].GetIdade() > 6)
            //    {
            //        Console.WriteLine("{0} {1} {2}", dogs[i].GetNome(), dogs[i].GetNomeDono(), dogs[i].GetIdade());
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //3 Crie 5 pessoas com nome,idade e genero. Peça para o usuario preencher as pessoas, em seguida, diga qual o homem mais velho e qual a mulher mais velha.
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

            //4 Crie 3 animais de um zoológico com nome, espécie e tempo no zoo. Peça para o usuario inseir todos os animais, em seguida, mostre todos os animas do mais novo para o mais velho no zoo
            //Animal[] animals = new Animal[3];

            //for (int i = 0; i < animals.Length; i++)
            //{
            //    Console.Write("Insira o nome do animal: ");
            //    string nome = Console.In.ReadLine();
            //    Console.Write("Insira a espécie do animal: ");
            //    string especie = Console.In.ReadLine();
            //    Console.Write("Insira quanto tempo no zoo em dias: ");
            //    int tempoZoo = Convert.ToInt32(Console.In.ReadLine());

            //    animals[i] = new Animal(nome, especie, tempoZoo);
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < animals.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (animals[j - 1].GetTempoZoo() > animals[j].GetTempoZoo()) //ordem crescente
            //        {
            //            Animal temp = animals[j];
            //            animals[j] = animals[j - 1];
            //            animals[j - 1] = temp;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}

            //for (int i = 0; i < animals.Length; i++)
            //{
            //    Console.WriteLine("Nome: {0}, Espécie: {1}, Tempo no Zoo: {2}", animals[i].GetNome(), animals[i].GetEspecie(), animals[i].GetTempoZoo());
            //}

            //5 Crie 5 produtos com nome,preço e quantidade no estoque. Peça para o usuario preencher todos os produtos, em seguida, mostre na tela os produtos começando pelos que tem maior quantidade no estoque
            //Produto[] prod = new Produto[5];

            //for (int i = 0; i < prod.Length; i++)
            //{
            //    Console.Write("Insira o nome do produto: ");
            //    string nome = Console.In.ReadLine();
            //    Console.Write("Insira o preço do produto: ");
            //    double preco = Convert.ToDouble(Console.In.ReadLine());
            //    Console.Write("Insira a quantidade em estoque do produto: ");
            //    int quantidade = Convert.ToInt32(Console.In.ReadLine());

            //    prod[i] = new Produto(nome, preco, quantidade);
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < prod.Length; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (prod[j - 1].GetQuantidade() < prod[j].GetQuantidade()) //ordem crescente
            //        {
            //            Produto temp = prod[j - 1];
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
            //    Console.WriteLine("Nome do produto: {0}, Preço do produto: {1}, Quantida em estoque: {2}", prod[i].GetNome(), prod[i].GetPreco(), prod[i].GetQuantidade());
            //}

            //6 Crie 3 empregados com nome, salário e cpf. Peça para o usuario preencher todos os funcionários,se o salário do funcionário for menor que 1500 de um aumento de 20%, após tudo isso, mostre na tela os funcionarios na ordem de menor salário para maior.
            Empregado[] empreg = new Empregado[3];

            for (int i = 0; i < empreg.Length; i++)
            {
                Console.Write("Insira o nome do empregado: ");
                string nome = Console.In.ReadLine();
                Console.Write("Insira o salário do empregado: ");
                double salario = Convert.ToDouble(Console.In.ReadLine());
                Console.Write("Insira o CPF do empregado: ");
                string cpf = Console.In.ReadLine();

                empreg[i] = new Empregado(nome, salario, cpf);
                Console.WriteLine();
            }

            for (int i = 0; i < empreg.Length; i++)
            {
                if (empreg[i].getSalario() < 1500.0)
                {
                    empreg[i].Aumento();
                }

                for (int j = i; j > 0; j--)
                {
                    if (empreg[j - 1].getSalario() > empreg[j].getSalario())
                    {
                        Empregado temp = empreg[j - 1];
                        empreg[j - 1] = empreg[j];
                        empreg[j] = temp;
                    }
                }
            }

            for (int i = 0; i < empreg.Length; i++)
            {
                Console.WriteLine("Nome: {0}, Salário: {1}, CPF: {2}", empreg[i].getNome(), empreg[i].getSalario(), empreg[i].getCpf());
            }

            //7 Crie 3 alunos que possuem nome, nota1,nota2,nota3 e uma função que retorna a média. Peça para o usuario preencher o nome, nota1,nota2 e nota3 deste aluno, em seguida, diga a média do aluno e se passou (para passar basta ter uma média > 7)
        }

        //public static string GetDogDetails(string nome, string nomeDono, int idade)
        //{
        //    string info = string.Format("Nome do dog: {0}, Nome do dono: {1}, Idade: {2}", nome, nomeDono, idade);
        //    return info;
        //}
    }
}

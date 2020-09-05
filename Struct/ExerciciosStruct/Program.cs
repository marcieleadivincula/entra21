using System;

namespace ExerciciosStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercícios de Struct - 1");
            //1) Crie uma pessoa que possui nome,idade,cpf e endereço. Peça apara o usuario preencher os dados e após, mostrar na tela.
            Pessoa pessoa = new Pessoa();

            Console.Write("Digite seu nome: ");
            pessoa.nome = Console.In.ReadLine();
            Console.Write("Digite sua idade: ");
            pessoa.idade = Convert.ToInt32(Console.In.ReadLine());
            Console.Write("Digite seu CPF:");
            pessoa.cpf = Console.In.ReadLine();
            pessoa.endereco = new Endereco();
            //Endereco endereco = new Endereco();

            Console.Write("Digite seu logradouro: ");
            //endereco.logradouro = Console.In.ReadLine();
            pessoa.endereco.logradouro = Console.In.ReadLine();
            Console.Write("Digite seu CEP: ");
            //endereco.cep = Console.In.ReadLine();
            pessoa.endereco.cep = Console.In.ReadLine();
            Console.Write("Digite seu numero: ");
            //endereco.numero = Console.In.ReadLine();
            pessoa.endereco.numero = Console.In.ReadLine();
            Console.Write("Digite seu bairro: ");
            //endereco.bairro = Console.In.ReadLine();
            pessoa.endereco.bairro = Console.In.ReadLine();
            Console.Write("Digite seu cidade: ");
            //endereco.cidade = Console.In.ReadLine();
            pessoa.endereco.cidade = Console.In.ReadLine();
            Console.Write("Digite seu estado: ");
            //endereco.estado = Console.In.ReadLine();
            pessoa.endereco.estado = Console.In.ReadLine();
            Console.Write("Digite seu pais: ");
            //endereco.pais = Console.In.ReadLine();
            pessoa.endereco.pais = Console.In.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Nome: " + pessoa.nome);
            Console.WriteLine("Idade: " + pessoa.idade);
            Console.WriteLine("CPF: " + pessoa.cpf);
            Console.WriteLine("Logradouro: " + pessoa.endereco.logradouro + "\nCEP: " + pessoa.endereco.cep + "\nNúmero: " + pessoa.endereco.numero + "\nBairro: " + pessoa.endereco.bairro + "\nCidade: " + pessoa.endereco.cidade + "\nEstado: " + pessoa.endereco.estado + "\nPaís: " + pessoa.endereco.pais);

            //2) Crie 2 cachorros que possuem nome, nome do dono e idade. Peça para o usuario preencher os dados e após, mostre na tela apenas os cachorros com mais de 6 anos.
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
            //3) Crie 1 aluno que possui nome, nota1,nota2,nota3 e média. Peça para o usuario preencher o nome, nota1,nota2 e nota3 deste aluno, em seguida, diga a média do aluno e se passou (para passar basta ter uma média > 7)
            Aluno aluno = new Aluno();
            aluno.notas = new Notas();

            Console.Write("Nome do aluno: ");
            aluno.nome = Console.In.ReadLine();

            Console.Write("Nota1 do aluno: ");
            aluno.notas.nota1 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Nota2 do aluno: ");
            aluno.notas.nota2 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Nota3 do aluno: ");
            aluno.notas.nota3 = Convert.ToDouble(Console.In.ReadLine());
            Console.Write("Nota4 do aluno: ");
            aluno.notas.nota4 = Convert.ToDouble(Console.In.ReadLine());

            //Console.Write("Media do aluno: ");
            aluno.media = (aluno.notas.nota1 + aluno.notas.nota2 + aluno.notas.nota3 + aluno.notas.nota4) / 4;
            if (aluno.media > 7)
            {
                Console.WriteLine();
                Console.WriteLine("Nome: " + aluno.nome);
                Console.WriteLine("Nota1:" + aluno.notas.nota1 + "\nNota2:" + aluno.notas.nota2 + "\nNota3:" + aluno.notas.nota3 + "\nNota4:" + aluno.notas.nota4);
                Console.WriteLine("Media: " + aluno.media);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sua média é menor que 7, então está reprovado!");
                Console.WriteLine("Media: " + aluno.media);
            }

            //4) Crie 5 pessoas com nome e idade. Peça para o usuario preencher as pessoas, em seguida, diga qual a pessoa mais velha, se houver 2 ou mais pessoas mais velhas avisa-se que nao encontou a pessoa mais velha.
            Pessoa[] pessoa = new Pessoa[5];
            int maiorIdade = 0;

            for (int i = 0; i < pessoa.Length; i++)
            {
                Console.Write("Digite o nome: ");
                pessoa[i].nome = Console.In.ReadLine();
                Console.Write("Digite a idade: ");
                pessoa[i].idade = Convert.ToInt32(Console.In.ReadLine());
                Console.WriteLine();

                if (pessoa[i].idade > maiorIdade && maiorIdade >= 2)
                {
                    Console.WriteLine();
                    maiorIdade = pessoa[i].idade;
                    Console.WriteLine("Maior idade: " + maiorIdade);
                    maiorIdade++;
                }
            }

            Console.WriteLine("Nome: " + pessoa[0].nome);
            Console.WriteLine("Nome: " + pessoa[1].nome);
            Console.WriteLine("Nome: " + pessoa[2].nome);
            Console.WriteLine("Nome: " + pessoa[3].nome);
            Console.WriteLine("Nome: " + pessoa[4].nome);
            Console.WriteLine();
            Console.WriteLine("Não encontramos a pessoa mais velha! " + maiorIdade);

            //5) Crie 3 animais de um zoológico com nome, raça e tempo no zoo. Peça para o usuario inseir todos os animais, em seguida, mostre todos os animas, se houver um leão

            //6) Crie 4 produtos com nome,preço e quantidade no estoque. Peça para o usuario preencher todos os produtos, em seguida, mostre na tela os produtos começando pelos que tem maior quantidade no estoque

            //7) Crie 3 empregados com nome, salário e cpf. Peça para o usuario preencher todos os funcionários,se o salário do funcionário for menor que 1500 de um aumento de 15%, após tudo isso, mostre na tela os funcionarios na ordem de maior salário pro menor.

        }

        //1
        public struct Pessoa
        {
            public string nome;
            public int idade;
            public string cpf;
            public Endereco endereco;
        }

        public struct Endereco
        {
            public string logradouro;
            public string cep;
            public string numero;
            public string bairro;
            public string cidade;
            public string estado;
            public string pais;
        }

        //2
         public struct Dog
        {
            public string nomeCachorro;
            public string nomeDono;
            public int idade;
        }

        //3
        public struct Aluno
        {
            public string nome;
            public Notas notas;
            public double media;
        }

        public struct Notas
        {
            public double nota1;
            public double nota2;
            public double nota3;
            public double nota4;
        }

        //4
        public struct Pessoa
        {
            public string nome;
            public int idade;
        }

        //5

    }
}

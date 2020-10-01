using System;

namespace ExerciciosArrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando lista 1 de exercícios de Array");
            Console.WriteLine();
            //1) Crie um vetor que armazena 2 valores vindo do usuario, depois, diga pro usuario qual o maior
            //int[] maiorNumero = new int[2];
            //int maior = 0;

            //for (int i = 0; i < maiorNumero.Length; i++)
            //{
            //    Console.Write("Digite um número qualquer: ");
            //    maiorNumero[i] = Convert.ToInt32(Console.In.ReadLine());

            //    if (maiorNumero[i] > maior)
            //    {
            //        maior = maiorNumero[i];
            //        Console.WriteLine("Maior número = " + maior);
            //    }
            //}

            //2) Crie um vetor que armarmazene 3 notas vindo do usuario, depois, de a média das três notas
            //double[] notas = new double[3];
            //double media, soma = 0;

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.Write("Digite a " + i + "º nota: ");
            //    notas[i] = Convert.ToDouble(Console.In.ReadLine());

            //    soma += notas[i];
            //}

            //media = soma / 3;
            //Console.WriteLine();
            //Console.WriteLine("Média = " + media);

            //3) Crie um vetor que armazena 3 valores vindo do usuario, depois, mostre apenas o maior dentre eles , se todos forem iguais, exiba uma mensagem dizendo “sao todos iguais”
            int[] valores = new int[3];
            int maior = 0, menor = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite uma valor qualquer: ");
                valores[i] = Convert.ToInt32(Console.In.ReadLine());

                if (valores[i] > maior)
                {
                    maior = valores[i];
                }
                
                if (valores[i] < menor)
                {
                    menor = valores[i];
                }
                else
                {
                    Console.WriteLine("São todos iguais!");
                }

                Console.WriteLine(i + "º = " + valores[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);

            //4) Crie um vetor que armazena 3 nomes vindo do usuario, o usuario pode, a qualquer momento, solicitar quais nomes estao armazenados.
            //string[] nomes = new string[3];
            //string nome = "";

            //for (int i = 0; i < nomes.Length; i++)
            //{
            //    Console.Write("Digite um nome: ");
            //    nomes[i] = Console.In.ReadLine();

            //    nome = nomes[i];
            //}

            //Console.WriteLine();
            //Console.WriteLine("Nome: " + nome);

            //5) Crie um vetor que armazena 5 valor INTEIROS, peça ao usuario para ele colocar valores nessas 5 posições, depois, some todos os valor e mostre pro usuario.


            //6) Imagine que uma escola deseja cadastrar alunos para isso ,Crie 3 vetores de 4 posições/tamanho 4, um para os nome,outro para cpf, e outro para idade, primeiro, mostre para o usuario em ordem, os alunos ja armazenados, entao, o usuario escolhe em qual lugar ele deseja armazenar um novo aluno (ex: usuario escolheu 2 , pede-se um nome,cpf e idade, entao, coloque tudo isso na 2° posição dos tres vetores) ao terminar de colocar aluno, pede - se ao usuario se deseja colocar um novo aluno ou sair.


            //7) Vamos criar um sistema simplificado de um estacionamento, para isso, Crie 2 vetores de 10 posições(estes vetores representam o numero de vagar, 10 vagas), um para a placa (possui letras e numeros) e outro para a hr de entrada, ao iniciar, solicite ao usuario se o cliente esta entrando ou sainda para isso:
            // - Entrando: Primeiro confere se tem vagas disponíveis, se nao, apenas avise que nao tem vagas e volte ao inicio, caso tenha, peça a placa e a hora de entrada, então, armazene na primeira vaga livre
            // - Saindo: Peça a placa do carro, se a placa nao for encontrada peça novamente, caso encontrou a placa, calcule o valor a ser pago(custa R$ 3, 50 a hora), após isso, zere a vaga que o cliente estava ocupando.

        }
    }
}

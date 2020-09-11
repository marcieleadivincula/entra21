using System;

namespace ExerciciosFunction02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios da lista 2 - Function");

            //1) Escreva uma função que receba 2 valores e retorna o maior entre eles. O usuario vai colocar 4 números, diga para ele qual o maior.
            Program pro = new Program();

            pro.GetInput();
            //pro.GetValue(7, 10);

            Console.WriteLine($"Maior número: {pro.GetInput()}");

            //2) Escreva uma função que recebe um vetor de inteiros e um número inteiro N e retorna o valor de vetor[N]. O vetor terá tamanho 10 e será gerado com numeros entre 0 e 9. O usuario vai colocar o N.


            //3) Escreva uma função que recebe 10 valores inteiros e retorna um vetor organizado do Maior pro Menor. O usuario vai inserir se deseja colocar os valores ou gerar aleatório entre 0 e 9, em seguida, mostre o vetor organizado pro usuario.

            //4) Escreva uma função que recebe 2 numeros(x,y) inteiros e um caracter e retorna x + y se caracter for ‘+’ , x-y se caracter for ‘-’ e se nao for nenhum desses, diga que nao conseguiu efetuar a conta. O usuario irá inserir os números e o operador, e depois, mostre pro usuario o resultado.

            //5) Crie uma função que recebe um vetor de logins e outro de senhas, login vindo do usuario e senha vindo do usuario a função retorna verdadeiro se o login e senha inserido pelo usuário estão nos vetores (de forma sincronizada). O usuário irá inserir o login e senha, se o conjunto for encontrado avisa, login correto caso contrário, avise que foi inválido.
        }

        //1
        public int GetValue(int a, int b)
        {
            int maior = 0;
            if (a > b)
            {
                maior = a;
            }
            else if (b > a)
            {
                maior = b;
            }
            else
            {
                Console.WriteLine("Valor inválido, tente novamente!");
            }

            return maior;
        }

        public int GetInput()
        {
            int valor = 0;
            int[] valores = new int[4];

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite um número qualquer: ");
                valores[i] = Convert.ToInt32(Console.In.ReadLine());

                if (valores[i] > valor)
                {
                    valor = valores[i];
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente!");
                }
            }

            return valor;
        }

        //2


        //3


        //4


        //5
    }
}

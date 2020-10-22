using System;

namespace OOpt03List02Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 302");
            //3) Uma empresa de telefonia adotou um novo sistema de tarifa cujo o valor do minuto de uma ligação varia de acordo com o horario.

            //Das 0h até as 9h – 50 % de desconto
            //Das 9h01 até 18h – 0 % de desconto
            //Das 18h01 até 21h – 30 % de desconto o valor do minuto padrão é R$ 0,28

            //Para isso, crie 4 Pessoas com nome e saldo, quando começar uma ligação diga qual pessoa vai ligar e peça o horário de início(dado em hora e depois o minuto) e término da ligação(dado em hora e depois minuto), repita esse processo enquanto o usuario desejar, quando o usuário terminar mostre todas as pessoas do Menor saldo pro Maior.

            //Obs: se a ligação começou em uma faixa de desconto e terminou em outra, você deverá cobrar o desconto de acordo com o preíodo de duração de uma ligaçãoem cada faixa de preço.Por exemplo, se uma ligação começou às 8h30 e terminou às 20h, você deverá conceder 50 % de desconto no período entre as 8h30 até as 9h, 0 % desconto para o período de 9h01 até às 18h e 30 % desconto para o período de 18h01 até as 20h.Além disso, caso o usuario informe que a ligação iniciou às 8h e terminou às 7h, significa que a ligação durou 23h.

            //Desafio: Caso queira se desafiar, faça com que todas as operações de descontos estejam em uma classe chamada provedor.

        }
    }
}

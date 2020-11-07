using System;

namespace ExercicioAvancado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício avançado
            //1) Temos um herói chamado Joeslei, Joeslei ataca com uma espada que varia seu dano de 3 a 10, claro que Joeslei tem 20 pontos de vida, vamo a alguns problemas que Joeslei vai encontrar

            //a) Sabemos que o ataque de Joeslei sempre oscila entre 3 e 10, Joeslei encontrou em seu caminho um Goblin que tem uma faca enferrujada que varia seu dano de 1 a 4 e 5 pontos de vida, Joeslei começou a lutar com esse Goblin, Joeslei ataca primeiro.Nesse contexto, simule um combate contra o goblin e coloque na tela se o Joeslei matou um nao o Goblin, além disso, mostre na tela o dano causado e a vida restante de ambos.

            //b) Agora que sabemos o que acontece se um Goblin lutar contra o Joeslei, simule tambem um Orc e um Troll, o Orc tem um machado seu dano varia de 4 a 8 e tem 9 pontos de vida, o Troll tem um porrete seu dano varia de 9 a 15 e tem 20 pontos de vida.

            //Joeslei = 20 pontos de vida, ataque entre 3 a 10;
            //Goblin = 5 pontos de vida, ataque entre 1 a 4;
            //Orc = 9 pontos de vida, ataque entre 4 a 8;
            //Troll = 20 pontos de vida, ataque entre 9 a 15;
            //ran.Next(valor é incluído, valor é excluído);

            Random ran = new Random();
            int ataqueMinimo = 0, ataqueMaximo = 15;
            int j = ran.Next(ataqueMinimo, ataqueMaximo);
            int g = ran.Next(ataqueMinimo, ataqueMaximo);
            int o = ran.Next(ataqueMinimo, ataqueMaximo);
            int t = ran.Next(ataqueMinimo, ataqueMaximo);

            Console.WriteLine("Joeslei = " + j);
            Console.WriteLine("Goblin = " + g);
            Console.WriteLine("Orc = " + o);
            Console.WriteLine("Troll = " + t);

            if (ataqueMinimo >= 3 && ataqueMaximo <= 10)
            {

            }
            else if (ataqueMinimo >= 1 && ataqueMaximo <= 4)
            {

            }
            else if (ataqueMinimo >= 4 && ataqueMaximo <= 8)
            {

            }
            else if (ataqueMinimo >= 9 && ataqueMaximo <= 15)
            {

            }
        }
    }
}

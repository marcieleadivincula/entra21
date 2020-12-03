using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho03
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public Jogador(int id, string name, int score)
        {
            Id = id;
            Name = name;
            Score = score;
        }
    }
}

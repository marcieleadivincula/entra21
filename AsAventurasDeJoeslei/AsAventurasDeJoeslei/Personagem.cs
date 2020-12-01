using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsAventurasDeJoeslei
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Raca { get; set; }
        public int Vida { get; set; }
        public int DanoMinimo { get; set; }
        public int DanoMaximo{ get; set; }
        public int Recompensa{ get; set; }

        public Personagem(int id, string raca, int vida, int danoMinimo, int danoMaximo, int recompensa)
        {
            Id = id;
            Raca = raca;
            Vida = vida;
            DanoMinimo = danoMinimo;
            DanoMaximo = danoMaximo;
            Recompensa = recompensa;
        }

        public Personagem()
        {

        }
    }
}

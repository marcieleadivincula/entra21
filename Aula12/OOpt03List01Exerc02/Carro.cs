using System;
using System.Collections.Generic;
using System.Text;

namespace OOpt03List01Exerc02
{
    class Carro
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int AnoDeFabricacao { get; set; }
        public string Placa { get; set; }

        public Carro(string nome, string marca, int anoDeFabricacao, string placa)
        {
            Nome = nome;
            Marca = marca;
            AnoDeFabricacao = anoDeFabricacao;
            Placa = placa;
        }
    }
}

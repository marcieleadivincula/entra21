using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt101Exerc05
{
    class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public double GetPreco()
        {
            return this.preco;
        }

        public double GetQuantidade()
        {
            return this.quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt103Exerc02
{
    class Produto
    {
        private string _nomeProduto;
        private int _idProduto;
        private double _precoProduto;
        ArrayList carrinho = new ArrayList();

        public Produto(string nomeProduto, int idProduto, double precoProduto)
        {
            _nomeProduto = nomeProduto;
            _idProduto = idProduto;
            _precoProduto = precoProduto;
        }

        public double GetValorTotal()
        {
            return this._precoProduto += _precoProduto;
        }

        public void SetListaProdutos(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void SetNomeProduto(string nomeProduto)
        {
            this._nomeProduto = nomeProduto;
        }

        public string GetNomeProduto()
        {
            return this._nomeProduto;
        }

        public void SetIdProduto(int idProduto)
        {
            this._idProduto = idProduto;
        }

        public int GetIdProduto()
        {
            return this._idProduto;
        }

        public void SetPrecoProduto(double precoProduto)
        {
            this._precoProduto = precoProduto;
        }

        public double GetPrecoProduto()
        {
            return this._precoProduto;
        }
    }
}

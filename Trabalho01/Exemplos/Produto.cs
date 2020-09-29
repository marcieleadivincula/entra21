using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos
{
    class Produto
    {
        private int[] _categoria = { 0, 1, 2, 3, 4 };
        private string[] _nomeProduto = { "", "alimento", "higiene pessoal", "limpeza", "utensílios" };

        //private int _categoria;
        //private string _nomeProduto;

        public void SetCategoria(int[] categoria)
        {
            this._categoria = categoria;
        }

        public int[] GetCategoria()
        {
            return this._categoria;
        }

        public void SetNomeCategoria(string[] nomeProduto)
        {
            this._nomeProduto = nomeProduto;
        }

        public string[] GetNomeProduto()
        {
            return this._nomeProduto;
        }

        public void AddProduct(int categoria, string nomeProduto)
        {
            int produto;
            if (categoria == 1 && nomeProduto == "alimento")
            {
                produto = categoria;
            }
            else if (categoria == 2 && nomeProduto == "higiene pessoal")
            {
                produto = categoria;
            }
            else if (categoria == 3 && nomeProduto == "limpeza")
            {
                produto = categoria;
            }
            else if (categoria == 4 && nomeProduto == "utensílios")
            {
                produto = categoria;
            }
            else
            {
                categoria = 0;
                nomeProduto = "";
            }
        }

        //public RemoveProduct()
        //{

        //}
        //public GetProduct()
        //{

        //}
        //public ToClose()
        //{

        //}
    }
}

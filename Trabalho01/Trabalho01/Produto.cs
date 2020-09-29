using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho01
{
    class Produto
    {
        private int _categoria;

        public void SetCategoria(int categoria)
        {
            this._categoria = categoria;
        }

        public int GetCategoria()
        {
            return this._categoria;
        }

        public void AddProduct(int categoria)
        {
            int produto;
            if (categoria == 1)
            {
                produto = categoria;
            }
            else if (categoria == 2)
            {
                produto = categoria;
            }
            else if (categoria == 3)
            {
                produto = categoria;
            }
            else if (categoria == 4)
            {
                produto = categoria;
            }
            else
            {
                categoria = 0;
            }
        }

        public bool RemoveProduct(int categoria)
        {
            if (categoria == this._categoria)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Categoria inválida! Tente novamente!");
                return true;
            }
        }

        public int[][] GetProducts(int[][] produtos)
        {
            return produtos;
        }

        //public ToClose()
        //{

        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public int TipoDeProduto { get; set; }
        public int QuantidadeFornecidaAoMes { get; set; }

        public Fornecedor(int id, string nome, string cnpj, int tipoDeProduto, int qtdFornecidaAoMes)
        {
            Id = id;
            Nome = nome;
            CNPJ = cnpj;
            TipoDeProduto = tipoDeProduto;
            QuantidadeFornecidaAoMes = qtdFornecidaAoMes;
        }

        public Fornecedor()
        {
        }

        public string GetDados()
        {
            return $"Id: {Id} Nome: {Nome} CNPJ: {CNPJ} Tipo de Produto: {TipoDeProduto} Quantidade Fornecida ao Mês: {QuantidadeFornecidaAoMes}";
        }

        public string GetQuantidadeFornecida()
        {
            return $"Quantidade Fornecida ao Mês: {QuantidadeFornecidaAoMes}";
        }

        public void SetQuantidadeFornecida(int quantidade)
        {
            QuantidadeFornecidaAoMes = quantidade;
        }
    }
}

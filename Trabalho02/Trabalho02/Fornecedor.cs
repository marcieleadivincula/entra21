namespace Trabalho02
{
    class Fornecedor
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public int TipoDeProduto { get; set; }
        public int QuantidadeFornecidaAoMes { get; set; }

        public Fornecedor(string nome, string cnpj, int tipoDeProduto, int qtdFornecidaAoMes)
        {
            Nome = nome;
            CNPJ = cnpj;
            TipoDeProduto = tipoDeProduto;
            QuantidadeFornecidaAoMes = qtdFornecidaAoMes;
        }

        public string GetDados()
        {
            return $"Nome: {Nome} CNPJ: {CNPJ} Tipo de Produto: {TipoDeProduto} Quantidade Fornecida ao Mês: {QuantidadeFornecidaAoMes}";
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

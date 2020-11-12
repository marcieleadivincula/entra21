namespace Trabalho02
{
    class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public double Saldo { get; set; }

        public Cliente(string nome, string cpf, int idade, double saldo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Saldo = saldo;
        }

        public string GetDados()
        {
            return $"Nome: {Nome} CPF: {CPF} Idade: {Idade} Saldo: {Saldo}";
        }

        public void SetDados(string nome, string cpf, int idade, double saldo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Saldo = saldo;
        }
    }
}

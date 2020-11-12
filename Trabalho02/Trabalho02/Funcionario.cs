namespace Trabalho02
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public double SalarioPorHora { get; set; }
        public string Cargo { get; set; }
        public double Saldo { get; set; }

        public Funcionario(string nome, string cpf, int idade, double salarioPorHora, string cargo, double saldo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            SalarioPorHora = salarioPorHora;
            Cargo = cargo;
            Saldo = saldo;
        }

        public string GetDados()
        {
            return $"Nome: {Nome} CPF: {CPF} Idade: {Idade} Salário por Hora: {SalarioPorHora} Cargo: {Cargo} Saldo: {Saldo}";
        }

        public void SetDados(string nome, string cpf, int idade, double salarioPorHora, string cargo, double saldo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            SalarioPorHora = salarioPorHora;
            Cargo = cargo;
            Saldo = saldo;
        }

        public string GetCargoSalario()
        {
            return $"Cargo: {Cargo} Salário por Hora: {SalarioPorHora}";
        }

        public void SetCargoSalario(string cargo, double salario)
        {
            Cargo = cargo;
            SalarioPorHora = salario;
        }

        public BatePonto(string hrEntrada, string hrSaida)
        {
            //Calcula o ganho do funcionário naquele dia de trabalho e adiciona no Saldo dele

        }
    }
}

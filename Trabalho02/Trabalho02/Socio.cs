namespace Trabalho02
{
    class Socio : Cliente
    {
        public double QtdAcoes { get; set; }

        public Socio()
        {

        }

        public Socio(double qtdAcoes, string nome, string cpf, int idade, double saldo) : base(nome, cpf, idade, saldo)
        {
            QtdAcoes = qtdAcoes;
        }
        public double GetAcoes()
        {
            return QtdAcoes;
        }

        public void SetAcoes(double qtdAcoes)
        {
            QtdAcoes = qtdAcoes;
        }
    }
}

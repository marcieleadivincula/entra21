namespace ExerciciosOOpt103Exerc01
{
    class VagaEmprego
    {
        private string _nomeVaga;
        private string _funcao;
        private double _salario;

        public VagaEmprego(string nomeVaga, string funcao, double salario)
        {
            this._nomeVaga = nomeVaga;
            this._funcao = funcao;
            this._salario = salario;
        }

        public void SetNomeVaga(string nomeVaga)
        {
            this._nomeVaga = nomeVaga;
        }

        public string GetNomeVaga()
        {
            return this._nomeVaga;
        }

        public void SetFuncao(string funcao)
        {
            this._funcao = funcao;
        }

        public string GetFuncao()
        {
            return this._funcao;
        }


        public void SetSalario(double salario)
        {
            this._salario = salario;
        }

        public double GetSalario()
        {
            return this._salario;
        }
    }
}

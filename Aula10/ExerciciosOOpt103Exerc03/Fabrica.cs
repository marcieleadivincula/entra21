using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt103Exerc03
{
    class Fabrica
    {
        private double _taxaProducao;
        private int _qtdFuncionarios;

        public Fabrica(double taxaProducao, int qtdFuncionarios)
        {
            this._taxaProducao = taxaProducao;
            this._qtdFuncionarios = qtdFuncionarios;
        }

        public void SetTaxaProducao(double taxaProducao)
        {
            this._taxaProducao = taxaProducao;
        }

        public double GetTaxaProducao()
        {
            return this._taxaProducao;
        }

        public void SetQtdFuncionarios(int qtdFuncionarios)
        {
            this._qtdFuncionarios = qtdFuncionarios;
        }

        public int GetQtdFuncionarios()
        {
            return this._qtdFuncionarios;
        }

        public double GetGanhoEmpresa()
        {
            double ganho = GetTaxaProducao() * 121.3;
            return ganho;
        }

        public double CustoFuncionariosMensal()
        {
            double custo = GetQtdFuncionarios() * 1.100;
            return custo;
        }

        public double LucroEmpresa()
        {
            double lucro = GetGanhoEmpresa() - CustoFuncionariosMensal();
            return lucro;
        }

        public double EmpresaMaiorLucro()
        {
            double maior = 0;
            if (LucroEmpresa() > maior)
            {
                maior = LucroEmpresa();
                return maior;
            }
            else
            {
                return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt101Exerc06
{
    class Empregado
    {
        private string nome;
        private double salario;
        private string cpf;

        //Construtor com parâmetros
        public Empregado(string nome, double salario, string cpf)
        {
            this.nome = nome;
            this.salario = salario;
            this.cpf = cpf;
        }

        //Getters and Setters
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public double Aumento()
        {
            double result;

            if (getSalario() > 1500)
            {
                result = getSalario() * 1.20;
                return result;
            }
            else
            {
                result = getSalario();
                return result;
            }
        }
    }
}

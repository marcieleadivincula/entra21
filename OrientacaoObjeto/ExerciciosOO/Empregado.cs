using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOO
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
            return getSalario() * 1.20;
        }
    }
}

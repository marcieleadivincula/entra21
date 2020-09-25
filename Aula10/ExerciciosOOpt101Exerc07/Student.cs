using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt101Exerc07
{
    class Student
    {
        private string _nome;
        private double _nota1, _nota2, _nota3;

        public Student(string nome, double nota1, double nota2, double nota3)
        {
            this._nome = nome;
            this._nota1 = nota1;
            this._nota2 = nota2;
            this._nota3 = nota3;
        }

        public void SetNome(string nome)
        {
            this._nome = nome;
        }

        public string GetNome()
        {
            return this._nome;
        }

        public void SetNota1(double nota1)
        {
            this._nota1 = nota1;
        }

        public double GetNota1()
        {
            return this._nota1;
        }

        public void SetNota2(double nota2)
        {
            this._nota2 = nota2;
        }

        public double GetNota2()
        {
            return this._nota2;
        }

        public void SetNota3(double nota3)
        {
            this._nota3 = nota3;
        }

        public double GetNota3()
        {
            return this._nota3;
        }

        public double MediaNotas()
        {
            double result = (GetNota1() + GetNota2() + GetNota3()) / 3;
            return result;
        }

        public string ValidaMedia()
        {
            if (MediaNotas() >= 7)
            {
                return "Aprovado!";
            }
            else
            {
                return "Reprovado!";
            }
        }
    }
}

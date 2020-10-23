using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeVAOpt101Exerc04
{
    class Conta
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public Conta(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
    }
}

using System;

namespace ExerciciosDeOOpt0601Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExerciciosDeOOpt0601Exerc01");
            //2) Implemente a classe Funcionario e a classe Gerente, ambos possuem, nome, salario e ExibeDados().

            //a) crie a classe Assistente, que também é um funcionário, e que possui um número de matrícula. Sobrescreva o método ExibeDados().

            //b) sabendo que os Assistentes Técnicos possuem um bônus salarial e que os Assistentes Administrativos possuem um turno(dia ou noite) e um adicional noturno, crie as classes Tecnico e Administrativo

            //c) agora que temos todos os possiveis cargos criados, crie um objeto de cada, preencha todos e então, o Gerente irá usar o sistema com o seguinte menu:
            //1 - Alterar : Mostre todos os funcionários, peça para o gerente quem deseja alterar e então as informações novas
            //2 - Excluir : Simplismente mostre todos na tela, então delete o escolhido
            //3 - Sair : Feche o programa

            Funcionario func = new Funcionario("Marcus", 4880.55);
            Gerente ger = new Gerente();
            Assistente assist = new Assistente(3654);
            Tecnico tecn = new Tecnico(255.88, 7894);
            Administrativo adm = new Administrativo("noturno", 150.50, 1589);

            Console.WriteLine(func.Salario);

            Console.WriteLine(ger);

            Console.WriteLine(assist.NumeroMatricula);

            Console.WriteLine(tecn.Salario);
            Console.WriteLine(tecn.NumeroMatricula);

            Console.WriteLine(adm.Turno);

        }
    }
}

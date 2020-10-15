using System;

namespace ExerciciosDeOOpt0503Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExercíciosDeOOpt0503");
            //1) Crie uma ClassePai Pessoa, contendo o construtor padrão e pelo menos mais duas opções de constru-tores conforme sua percepção e os seguintes atributos: String nome; String endereço; String telefone;

            //a) Considere, como subclasse da classe Pessoa a classe Fornecedor. Considere que cada instância da classe Fornecedor tem, para além dos atributos que caracterizam a classe Pessoa, os atributos valorCre-dito(correspondente ao crédito máximo atribuído ao fornecedor) e valorDivida(montante da dívida para com o fornecedor). Implemente tambem um método obterSaldo() que devolve a diferença entre os valores dos atributos valorCredito e valorDivida. Depois de implementada a classe Fornecedor, crie um programa de teste adequado que lhe permita verificar o funcionamento dos métodos implementados na classe Fornecedor e os herdados da classe Pessoa.

            //b) Considere, como subclasse da classe Pessoa, a classe Empregado.Considere que cada instância da classe Empregado tem, para além dos atributos que caracterizam a classe Pessoa, os atributos codigoSe-tor(inteiro), salarioBase(vencimento base) e imposto(porcentagem retida dos impostos). Implemente a classe Empregado com um método calcularSalario. Escreva um programa de teste adequado para a clas - se Empregado.

            //c) Implemente a classe Administrador como subclasse da classe Empregado.Um determinado adminis - trador tem como atributos, para além dos atributos da classe Pessoa e da classe Empregado, a proprie-dade ajudaDeCusto(ajudas referentes a viagens, estadias, ...).Note que deverá criar o calcularSalario - Adm(o salário de um administrador é equivalente ao salário de um empregado usual acrescido da ajuda de custo).Escreva um programa que tem o seguinte menu:
            //1 – Salario do Administrador: isso determina quanto é o salário do Administrador
            //2 – Ajuda de Custo: isso determina quanto é a ajuda de custo do Administrador
            //3 - Mostra salário: mostre na tela o salário atual do Administrador calculado pelo  calcularSalario - Adm().
            //4 – Sair.

            //d) Implemente a classe Operario como subclasse da classe Empregado.Um determinado operário tem como atributos, para além dos atributos da classe Pessoa e da classe Empregado, o atributo valorProdu-cao(que corresponde ao valor monetário dos artigos efetivamente produzidos pelo operário) e comissao(que corresponde à porcentagem do valorProducao que será adicionado ao vencimento base do operá - rio). Note que deverá criar o calcularSalarioOp(o salário de um operário é equivalente ao salário de um empregado usual acrescido da referida comissão). Escreva um programa que tem o seguinte menu :
            //1 – Salario do Operario: isso determina quanto é o salário do Operario
            //2 – Valor de Produção: isso determina quanto é o Valor de Produção
            //3 – Comissão: isso determina quantos % é a comissao
            //4 – Calcular Salário:  mostre na tela o salário atual do Operario calculado pelo calcularSalarioOp
            //5 – Sair.

        }
    }
}

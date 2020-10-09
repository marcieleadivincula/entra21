using System;

namespace ExerciciosOOpt103Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 3");
            //3) Crie 3 fábricas com taxa de produção e número de funcionários. Peça para o usuário preencher todas as fábricas , em seguida, cada funcionário custa 1.100 por mês e o ganho da empresa é dado por ((taxa de produção * 121,3)), calcule o lucro de todas as empresas e em seguida, mostre a empresa com o maior lucro
            Fabrica[] fab = new Fabrica[3];

            for (int i = 0; i < fab.Length; i++)
            {
                Console.Write("Taxa de produção: ");
                double taxa = double.Parse(Console.In.ReadLine());
                Console.Write("Número de funcionários: ");
                int numero = int.Parse(Console.In.ReadLine());

                fab[i] = new Fabrica(taxa, numero);
                Console.WriteLine();
            }
            Console.WriteLine("=====================================================");

            for (int i = 0; i < fab.Length; i++)
            {
                Console.WriteLine("Taxa de produção: {0} \nNúmero de funcionários: {1} \nGanho: {2} \nCusto mensal: {3} \nMaior lucro: {4}", fab[i].GetTaxaProducao(), fab[i].GetQtdFuncionarios(), fab[i].GetGanhoEmpresa(), fab[i].CustoFuncionariosMensal(), fab[i].EmpresaMaiorLucro());
                Console.WriteLine();
            }
        }
    }
}

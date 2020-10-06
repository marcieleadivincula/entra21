using System;

namespace ExerciciosOOpt103Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Orientação à Objeto - 3");

            //1) Crie 10 vagas de emprego com nome da vaga,função e salário. Peça para o usuario preencher todas as vagas, sem seguida, mostre as vagas de forma organizada
            VagaEmprego[] vagaEmpregos = new VagaEmprego[10];

            for (int i = 0; i < vagaEmpregos.Length; i++)
            {
                Console.Write("Nome da vaga: ");
                vagaEmpregos[i].SetNomeVaga(Console.In.ReadLine());
                Console.Write("Função: ");
                vagaEmpregos[i].SetFuncao(Console.In.ReadLine());
                Console.Write("Salário: ");
                vagaEmpregos[i].SetSalario(int.Parse(Console.In.ReadLine()));

                vagaEmpregos[i] = new VagaEmprego(vagaEmpregos[i].GetNomeVaga(), vagaEmpregos[i].GetFuncao(), vagaEmpregos[i].GetSalario());
                Console.WriteLine();
            }

            for (int i = 0; i < vagaEmpregos.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (vagaEmpregos[j - 1].GetSalario() > vagaEmpregos[j].GetSalario())
                    {
                        VagaEmprego temp = vagaEmpregos[j];
                        vagaEmpregos[j] = vagaEmpregos[j - 1];
                        vagaEmpregos[j - 1] = temp;
                    }
                }
            }

            for (int i = 0; i < vagaEmpregos.Length; i++)
            {
                Console.WriteLine("Nome da vaga: {0} Função: {1} Salário: {2:c}", vagaEmpregos[i].GetNomeVaga(), vagaEmpregos[i].GetFuncao(), vagaEmpregos[i].GetSalario());
            }
        }
    }
}

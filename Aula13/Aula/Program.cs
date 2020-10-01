using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula de Herança - 01/10/2020");

            Pessoa pes = new Pessoa();
            pes.rua = "XV";
            Console.WriteLine("{0} \n{1} \n{2}", pes.rua, pes.numero, pes.bairro);


        }
    }
}

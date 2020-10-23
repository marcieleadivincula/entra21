using System;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExercíciosDeOOpt0501");

            C obj = new C();
            obj.Exibir();
            obj.Mostrar();
            obj.Apresentar();
            //Console.ReadKey();

            //Segundo exemplo
            Quadrado qd = new Quadrado();
            int area;
            qd.setLado(5);
            area = qd.getArea();
            // Imprime a área e custo 
            Console.WriteLine("A area é: {0}", qd.getArea());
            Console.WriteLine("O custo é: {0}", qd.getCusto(area));
            //Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula14
{
    class Quadrado : Forma, ICusto
    {
        //A linguagem C# não suporta herança múltipla de classes.

        //Para superar esse problema, podemos usar interfaces onde uma classe pode implementar mais de uma interface ou de uma classe e de uma ou mais de uma interface.
        public int getArea()
        {
            return (lado * lado);
        }
        public int getCusto(int area)
        {
            return area * 10;
        }
    }
}

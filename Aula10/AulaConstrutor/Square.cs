using System;
using System.Collections.Generic;
using System.Text;

namespace AulaConstrutor
{
    class Square : Shape
    {
        public double side;

        //constructor
        public Square(double s) => side = s;

        public override double Area
        {
            get => side * side;
            set => side = System.Math.Sqrt(value);
        }
    }
}

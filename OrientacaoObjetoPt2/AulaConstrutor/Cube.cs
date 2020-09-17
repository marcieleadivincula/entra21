using System;
using System.Collections.Generic;
using System.Text;

namespace AulaConstrutor
{
    class Cube : Shape
    {
        public double side;

        //constructor
        public Cube(double s) => side = s;

        public override double Area
        {
            get => 6 * side * side;
            set => side = System.Math.Sqrt(value / 6);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AulaConstrutor
{
    public class Manager : Employee
    {
        private string _name;

        // Notice the use of the new modifier:
        public new string Name
        {
            get => _name;
            set => _name = value + ", Manager";
        }
    }
}

using System;

namespace AulaConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa myObj = new Pessoa();

            myObj.Nome = "Liam";
            Console.WriteLine(myObj.Nome);

            //Classe funcionário
            Employee.NumberOfEmployees = 107;
            Employee e1 = new Employee();
            e1.Name = "Claude Vige";

            System.Console.WriteLine("Employee number: {0}", Employee.Counter);
            System.Console.WriteLine("Employee name: {0}", e1.Name);

            //Classe Gerente
            Manager m1 = new Manager();

            // Derived class property.
            m1.Name = "John";

            // Base class property.
            ((Employee)m1).Name = "Mary";

            System.Console.WriteLine("Name in the derived class is: {0}", m1.Name);
            System.Console.WriteLine("Name in the base class is: {0}", ((Employee)m1).Name);

            //CLASSES : shape, square and cube
            // Input the side:
            System.Console.Write("Enter the side: ");
            double side = double.Parse(System.Console.ReadLine());

            // Compute the areas:
            Square s = new Square(side);
            Cube c = new Cube(side);

            // Display the results:
            System.Console.WriteLine("Area of the square = {0:F2}", s.Area);
            System.Console.WriteLine("Area of the cube = {0:F2}", c.Area);
            System.Console.WriteLine();

            // Input the area:
            System.Console.Write("Enter the area: ");
            double area = double.Parse(System.Console.ReadLine());

            // Compute the sides:
            s.Area = area;
            c.Area = area;

            // Display the results:
            System.Console.WriteLine("Side of the square = {0:F2}", s.side);
            System.Console.WriteLine("Side of the cube = {0:F2}", c.side);
        }
    }
}

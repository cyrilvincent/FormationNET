using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationOO
{
    public class Point
    {
        public double x; // Attribute
        public double y; // Field
        public double z; // Members = Attributes + Methods

        public void Display() // UML : Operation
        {
            Console.WriteLine($"({x},{y},{z})");
        }

        public void Move(double x, double y, double z) // Code : Method
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
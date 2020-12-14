using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationOO
{
    public class Point
    {
        private double x; // Attribute
        public double Y { get; set; }
        public double Z { get; set; }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public void Display() // UML : Operation
        {
            Console.WriteLine($"({X},{Y},{Z})");
        }

        public void Move(double x, double y, double z) // Code : Method
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
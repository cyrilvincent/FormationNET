using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationOO
{
    public class Point
    {
        private double x; // Attribute
        private double y; // Field
        private double Z { get; set; }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public void Display() // UML : Operation
        {
            Console.WriteLine($"({x},{y},{Z})");
        }

        public void Move(double x, double y, double z) // Code : Method
        {
            this.x = x;
            this.y = y;
            this.Z = z;
        }
    }
}
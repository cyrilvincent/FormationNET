using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class Rectangle
    {
        public double Length { get; set; } // auto-implemented
        public double Width { get; set; }

        public Point Origin { get; set; }

        public double Area
        {
            get { return Length * Area; }
        }

        public Rectangle(double length, double width, Point origin)
        {
            Length = length;
            Width = width;
            Origin = origin;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class Rectangle : Quadrilatere
    {
        public double Length { get; set; } // auto-implemented
        public double Width { get; set; }

        public virtual double Area
        {
            get { return Length * Area; }
        }

        public Rectangle(double length, double width, Point origin) : base(origin)
        {
            Length = length;
            Width = width;
        }


    }
}

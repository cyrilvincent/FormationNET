using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Point Origin { get; set; }

        public Rectangle(double width, double height, Point origin)
        {
            Width = width;
            Height = height;
            Origin = origin;
        }

        public double Surface()
        {
            return Width * Height;
        }
    }
}

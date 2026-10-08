using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    public class TriangleRectangle : Rectangle
    {
        public TriangleRectangle(double width, double height, Point origin) : base(width, height, origin) { }

        public double Hypothenuse()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height,  2));
        }

        public override double Perimetre()
        {
            return Width + Height + Hypothenuse();
        }

        public override double Surface()
        {
            return base.Surface() / 2;
        }
    }
}

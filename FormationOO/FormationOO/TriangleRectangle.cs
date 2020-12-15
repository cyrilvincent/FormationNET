using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class TriangleRectangle : Rectangle
    {
        public TriangleRectangle(double length, double width, Point origin) : base(length, width, origin) { }

        public override double Area
        {
            get { return base.Area / 2; }
        }
    }
}

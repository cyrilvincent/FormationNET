using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    public class Square : Rectangle
    {
        public Square(double side, Point origin) : base(side, side, origin) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class Quadrilatere
    {
        public Point Origin { get; set; }

        public Quadrilatere(Point origin)
        {
            Origin = origin;
        }
        public void Move(Point destination)
        {
            Origin = destination;
        }
    }
}

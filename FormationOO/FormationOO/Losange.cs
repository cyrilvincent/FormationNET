using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class Losange : Quadrilatere
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        public Losange(double diag1=0, double diag2=0, Point origin=null) : base(origin)
        {
            Diagonal1 = diag1;
            Diagonal2 = diag2;
        }
    }
}

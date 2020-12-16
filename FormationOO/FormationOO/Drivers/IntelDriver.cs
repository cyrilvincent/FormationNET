using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO.Drivers
{
    public class IntelDriver : IDriver
    {
        public void Display(IPoint point)
        {
            Console.WriteLine($"Intel({point.X}-{point.Y}-{point.Z})");
        }

        public IPoint PointFactory(double x, double y, double z)
        {
            return new IntelPoint { X = x, Y = y, Z = z };
        }
    }

    public class IntelPoint : IPoint
    {
        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
    }
}

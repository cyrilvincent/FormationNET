using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO.Drivers
{
    public class NVidiaDriver : IDriver
    {
        public void Display(IPoint point)
        {
            Console.WriteLine($"NVidia({point.X},{point.Y},{point.Z})");
        }

        public IPoint PointFactory(double x, double y, double z)
        {
            return new NVidiaPoint { X = x, Y = y, Z = z };
        }
    }

    public class NVidiaPoint : IPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}

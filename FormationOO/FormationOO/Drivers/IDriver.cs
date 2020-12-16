using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO.Drivers
{
    public interface IDriver
    {
        void Display(IPoint point);
        IPoint PointFactory(double x, double y, double z);
    }

    public interface IPoint
    {
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }
    }
}

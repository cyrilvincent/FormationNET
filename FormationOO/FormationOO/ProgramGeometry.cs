using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    class ProgramGeometry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometry");
            Point p1 = new Point();
            p1.x = 3;
            p1.y = 4;
            p1.z = -2;
            p1.Display();
            p1.Move(1, 1, 1);
            p1.Display();

            Console.ReadKey();
        }
    }
}

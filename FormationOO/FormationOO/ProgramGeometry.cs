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
            Point p1 = new Point(3,4,-2);
            p1.Display();
            p1.Move(1, 1, 1);
            p1.Display();
            Rectangle r = new Rectangle(3,2,p1);
            Point p2 = new Point(2, 2,2);
            r.Move(p2);
            Console.WriteLine(r.Origin.X);
            Console.ReadKey();


            /*
             * Rectangle ---HAS--- Point
             *    |
             *    IS
             *    |
             * Square
             * */
        }
    }
}

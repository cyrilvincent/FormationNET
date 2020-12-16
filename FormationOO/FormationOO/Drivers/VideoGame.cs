using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO.Drivers
{
    public class VideoGame
    {
        public IDriver Driver { get; set; }

        public VideoGame(IDriver driver)
        {
            Driver = driver;
        }

        public void Play()
        {
            IPoint p = Driver.PointFactory(1, 2, 3);
            Driver.Display(p);
            p.Z = 4;
            Driver.Display(p);
        }
        
    }

    /* VideoGame -> Spécifications de drivers OpenGL DirectX = 3D
     *              Point(x,y,z,color) display
     *              Line(p1, p2, color) display
     *              ^                       ^
     *              |                       |
     *              NVidia              Intel
     *              Driver              Driver
     * 
     * Loosely Coupled Object : Interdiction VideoGame - NVidia ou Intel
     */ 
}

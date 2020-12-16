using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO.Drivers
{
    class ProgramVideoGame
    {
        public IDriver Driver { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("VideoGame");
            IntelDriver driver = new IntelDriver();
            VideoGame game = new VideoGame(driver);
            game.Play();

            NVidiaDriver driver2 = new NVidiaDriver();
            game = new VideoGame(driver2);
            game.Play();


            Console.ReadKey();

            
        }
    }
}

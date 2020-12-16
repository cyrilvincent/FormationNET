using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class Singleton
    {
        private static Singleton instance = null;
        public static Singleton CreateInstance()
        {
            if(instance == null)
            {
                 instance = new Singleton();
            }
            return instance;
        }

        private Singleton()
        {
            // Cost++
        }
    }

    /**
     * Singleton s1 = Singleton.createInstance();
     * Singleton s2 = Singleton.createInstance();
     * s1 et s2 sont la même instance
     * */
}

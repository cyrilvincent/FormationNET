using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class Counter
    {
        public static int Count { get; private set; } = 0;

        public static void Increment()
        {
            Count++;
        }

    }

    /**
     * Counter c1 = new Counter();
     * Counter c2 = new Counter();
     * c1.Increment()
     * c1.Increment()
     * c1.Count => 2
     * c2.Increment()
     * c2.Count => 1 sans static
     * c2.Count => 3 avec static
     * Counter.Increment() avec static
     * Counter.Count avec static
     * Tools
     * */
}

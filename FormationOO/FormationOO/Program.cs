using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Saisir un entier: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            int nb = int.Parse(s);
            if(nb % 2 == 0)
            {
                Console.WriteLine("Pair");
            }
            else
            {
                Console.WriteLine("Impair");
            }
            int[] tab = { 1, 2, 3, 4 };
            foreach(int i in tab)
            {
                Console.WriteLine(i);
            }
            int res = Add(3, 2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

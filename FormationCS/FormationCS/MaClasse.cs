using System;
using System;

namespace FormationCS
{
    internal class MaClasse
    {
        public static void MaFonction()
        {
            Console.WriteLine("Hello depuis FormationCS.MaClasse.MaFonction");
            double result = add(2, 3);
            int i = 0;
            i = i + 1;
            i += 1;
            i++;
            var s = "toto";
            double f = 1.999999999;
            Console.WriteLine($"Mon résultat est: {f:N2}");
            //var input = Console.ReadLine();

            i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            for(int j=10; j>=0; j--)
            {
                Console.WriteLine(j);
            }
            


        }



        public static double add(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// ma fonction à moi
        /// </summary>
        /// <param name="x">blah blah</param>
        /// <returns>un truc</returns>
        public static string is_even(int x)
        {
            if (x % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}

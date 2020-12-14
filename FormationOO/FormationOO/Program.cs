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
            if(isEven(nb))
            {
                Console.WriteLine("Pair");
            }
            else
            {
                Console.WriteLine("Impair");
            }
            Console.WriteLine("Est premier " + IsPrime(nb));
            /*int[] tab = { 1, 99, 3, 4 };
            foreach(int i in tab)
            {
                Console.WriteLine(i);
            }
            DisplayFor(10);
            int res = Add(3, 2);
            Console.WriteLine(res);*/
            Console.ReadKey();
        }

        static bool isEven(int x)
        {
            return x % 2 == 0;
        }

        static void DisplayFor(int nb)
        {
            for(int i = 0; i < nb; i++)
            {
                Console.WriteLine(i);
            }
        }

        static bool IsPrime(int nb)
        {
            if(nb < 2)
            {
                return false;
            }
            else
            {
                for(int div = 2; div < nb; div++)
                {
                    if(nb % div == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /*TP1
         *Faire la fonction IsEven(int x) qui retourne true si x est pair false sinon
         *Saisir un chiffre et vérifier s'il est pair ou non
         *Faire une fonction DisplayFor(int nb) qui affiche une boucle de 0 à <nb
         *Faire la fonction IsPrime(int nb) qui retourne true si nombre premier
         *  Tout nombre >= 2 est premier sauf s'il possède un diviseur compris entre 2 et n-1
         */

        /*
         * TP2
         * Class Book : Amazon (6-8 attributs + 0 méthodes)
         * Point 3d : Catia
         * BankAccount : Banquier
         * 14h10*/
    }
}

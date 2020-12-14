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
            int[] tab = { 1, 99, 3, 4 };
            foreach(int i in tab)
            {
                Console.WriteLine(i);
            }
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }
            int res = Add(3, 2);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        /*TP1
         *Faire la fonction IsEven(int x) qui retourne true si x est pair false sinon
         *Saisir un chiffre et vérifier s'il est pair ou non
         *Faire une fonction DisplayFor(int nb) qui affiche une boucle de 0 à <nb
         *Faire la fonction IsPrime(int nb) qui retourne true si nombre premier
         *  Tout nombre >= 2 est premier sauf s'il possède un diviseur compris entre 2 et n-1
         */
    }
}

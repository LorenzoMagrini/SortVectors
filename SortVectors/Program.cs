using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vett = new int [10] {0,1,2,3,4,5,6,7,9,8};

            Ordina(vett);            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vett[i]);
            }

            int minimo = Minimo(vett);
            Console.WriteLine("Il valore minimo è: " + minimo);
            Console.ReadKey();

        }

        static void Ordina(int [] vett)
        {
            Array.Sort(vett);
        }

        static int Minimo(int[] vett)
        {
            return vett[0];
        }

    }
}

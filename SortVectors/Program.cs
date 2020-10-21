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

            int max = Massimo(vett);

            Console.WriteLine("Il massimo è: " + max);

            Console.ReadKey();

        }

        static void Ordina(int [] vett)
        {
            Array.Sort(vett);
        }

        static int Massimo(int[] v)
        {

            int max = v[0];

            for(int i = 0; i < v.Length; i++)
            {

                if (max < v[i])
                    max = v[i];

                


            }

            return max;

        }
    }
}

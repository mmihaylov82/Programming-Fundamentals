using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int counter = 0;
            double halfOfN = n / 2.0;

            while (true)
            {
                if (n < m)
                {
                    break;
                }

                n -= m;
                counter++;

                if ((double)(n) == halfOfN && y != 0)
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}

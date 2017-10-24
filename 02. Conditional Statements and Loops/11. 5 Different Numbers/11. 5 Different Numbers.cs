using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = a; k <= b; k++)
                    {
                        for (int m = a; m <= b; m++)
                        {
                            for (int n = a; n <= b; n++)
                            {
                                if (a <= i && i < j && j < k && k < m && m < n && n <= b)
                                {
                                    Console.WriteLine($"{i} {j} {k} {m} {n}");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
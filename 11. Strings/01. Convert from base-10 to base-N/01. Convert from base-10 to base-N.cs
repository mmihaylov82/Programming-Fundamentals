using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split().ToArray();

            int n = int.Parse(inputNumbers[0]);
            BigInteger base10Number = BigInteger.Parse(inputNumbers[1]);

            BigInteger rem = base10Number % n;
            StringBuilder str = new StringBuilder();

            while (true)
            {
                if (base10Number == 0)
                {
                    break;
                }
                str.Append(rem);
                base10Number = base10Number / n;
                rem = base10Number % n;
            }

            Console.WriteLine(ReversedStr(str));
        }

        static string ReversedStr(StringBuilder str)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            return reversed.ToString();
        }
    }
}

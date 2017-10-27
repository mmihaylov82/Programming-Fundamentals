using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Trim().Split().ToArray();

            int n = int.Parse(inputNumbers[0]);
            string baseNstring = inputNumbers[1];
            BigInteger baseNNumber = BigInteger.Parse(baseNstring);
            int currentPower = baseNstring.Length - 1;
            BigInteger base10Number = 0;

            for (int i = 0; i < baseNstring.Length; i++)
            {
                base10Number += BigInteger.Parse(baseNstring[i].ToString()) * (BigInteger.Pow(n, currentPower)); 
                currentPower--;
            }

            Console.WriteLine(base10Number);
        }
    }
}

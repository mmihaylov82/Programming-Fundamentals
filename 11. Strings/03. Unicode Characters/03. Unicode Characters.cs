using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            StringBuilder outputStr = new StringBuilder();

            foreach (char c in input)
            {
                outputStr.Append("\\u" + ((int)c).ToString("X4").ToLower());
            }
            Console.WriteLine(outputStr);
        }
    }
}

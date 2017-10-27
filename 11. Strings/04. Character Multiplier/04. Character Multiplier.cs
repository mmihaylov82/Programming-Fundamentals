using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string str1 = input[0];
            string str2 = input[1];
            string longerString = str1;
            long sum = 0;
            int indexCounter = 0;
                        
            while (indexCounter < str2.Length) 
            {
                if (indexCounter == str1.Length)
                {
                    longerString = str2;
                    break;
                }
                sum += str1[indexCounter] * str2[indexCounter];
                indexCounter++;
            }

            longerString = longerString.Remove(0, indexCounter);

            foreach (var c in longerString)
            {
                sum += c;
            }
            Console.WriteLine(sum);
        }
    }
}

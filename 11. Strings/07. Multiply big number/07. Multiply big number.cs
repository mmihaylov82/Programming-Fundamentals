using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = input;

            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    result = SumBigNumberWithItself(result, input);
                }

                Console.WriteLine(result);
            }
        }

        static string SumBigNumberWithItself(string first, string second)
        {
            if (first.Length > second.Length)
            {
                second = second.PadLeft(first.Length, '0');
            }
            else
            {
                first = first.PadLeft(second.Length, '0');
            }

            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var number = 0;
            var reminder = 0;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = first[i] - 48 + second[i] - 48 + reminder;
                number = sum % 10;
                sb.Append(number);
                reminder = sum / 10;
                if (i == 0 && reminder > 0)
                {
                    sb.Append(reminder);
                }
            }
            string result = new string(
                sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
            return result;
        }
    }
}

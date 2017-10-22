using System;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReverseDigits(number));
        }
        static string ReverseDigits(string a)
        {
            string reversed = "";
            for (int i = a.Length-1; i >= 0; i--)
            {
                reversed += a[i].ToString();
            }
            return reversed;
        }
    }
}
using System;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkIfTrue = Convert.ToBoolean(Console.ReadLine());

            if (checkIfTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
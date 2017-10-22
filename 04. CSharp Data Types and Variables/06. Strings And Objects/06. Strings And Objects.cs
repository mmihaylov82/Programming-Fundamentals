using System;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "World";
            object s3 = s1 + " " + s2;
            
            Console.WriteLine((string)s3);
        }
    }
}

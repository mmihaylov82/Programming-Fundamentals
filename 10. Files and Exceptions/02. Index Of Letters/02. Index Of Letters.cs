namespace _02.Index_Of_Letters
{
    using System.IO;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string inputString = File.ReadAllText("input.txt");
            File.Delete("output.txt");

            foreach (char letter in inputString)
            {
                File.AppendAllText("output.txt", 
                    string.Join(" -> ", letter, letter - 'a' + Environment.NewLine));
            }  
        }
    }
}

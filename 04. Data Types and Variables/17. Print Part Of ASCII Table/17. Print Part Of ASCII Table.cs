﻿using System;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());

            for (int i = firstChar; i <= lastChar ; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
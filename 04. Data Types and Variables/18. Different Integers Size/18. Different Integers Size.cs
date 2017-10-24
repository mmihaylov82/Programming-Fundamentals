using System;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            sbyte sbyteResult;
            byte byteResult;
            short shortResult;
            ushort ushortResult;
            int intResult;
            uint uintResult;
            long longResult;

            bool fitInAnyType = false;
            string outputMessage = "";

            if (sbyte.TryParse(n, out sbyteResult))
            {
                fitInAnyType = true;
                outputMessage += "* sbyte\r\n";

            }
            if (byte.TryParse(n, out byteResult))
            {
                fitInAnyType = true;
                outputMessage += "* byte\r\n";
            }
            if (short.TryParse(n, out shortResult))
            {
                fitInAnyType = true;
                outputMessage += "* short\r\n";
            }
            if (ushort.TryParse(n, out ushortResult))
            {
                fitInAnyType = true;
                outputMessage += "* ushort\r\n";
            }
            if (int.TryParse(n, out intResult))
            {
                fitInAnyType = true;
                outputMessage += "* int\r\n";
            }
            if (uint.TryParse(n, out uintResult))
            {
                fitInAnyType = true;
                outputMessage += "* uint\r\n";
            }
            if (long.TryParse(n, out longResult))
            {
                fitInAnyType = true;
                outputMessage += "* long\r\n";
            }
            if (fitInAnyType)
            {
                Console.WriteLine($"{n} can fit in:\r\n" + outputMessage);
            }
            else
            {
                Console.WriteLine($"{n} can't fit in any type");
            }
        }
    }
}
using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        char wantedChar = 'p';
        bool foundMatchInText = false;

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] == wantedChar)
            {
                foundMatchInText = true;
                if (i + count > text.Length - 1)
                {
                    count = text.Length - i - 1;
                }
                string matchedString = text.Substring(i, count+1);
                Console.WriteLine(matchedString);
                i += count;
            }
        }

        if (!foundMatchInText)
        {
            Console.WriteLine("no");
        }
    }
}

namespace _04.Max_Seq_of_Equal_Elements
{
    using System.Linq;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();
            File.Delete("output.txt");

            int maxStart = 0;
            int maxLength = 1;
            int currentStart = 0;
            int currentLength = 1;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] == elements[currentStart])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLength = 1;
                }
            }

            for (int i = maxStart; i < maxStart + maxLength; i++)
            {
                File.AppendAllText("output.txt", $"{elements[i]} ");
            }
        }
    }
}

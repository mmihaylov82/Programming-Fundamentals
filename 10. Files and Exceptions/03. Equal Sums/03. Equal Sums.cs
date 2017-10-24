namespace _03.Equal_Sums
{
    using System.Linq;
    using System.IO;

    class Program
    {
        static void Main()
        {
            int[] inputArray = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

            bool equalSums = false;
            int equalSumsElement = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (ArraySum(inputArray, 0, i - 1) == ArraySum(inputArray, i + 1, inputArray.Length - 1))
                {
                    equalSums = true;
                    equalSumsElement = i;
                }
            }
            if (equalSums)
            {
                File.WriteAllText("output.txt", equalSumsElement.ToString());
            }
            else
            {
                File.WriteAllText("output.txt", "no");
            }
        }

        static int ArraySum(int[] inputArray, int start, int end)
        {
            int sumOfElements = 0;
            for (int i = start; i <= end; i++)
            {
                sumOfElements += inputArray[i];
            }
            return sumOfElements;
        }
    }
}

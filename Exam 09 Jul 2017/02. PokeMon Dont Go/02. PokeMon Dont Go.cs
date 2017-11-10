using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PokeMon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputArgs = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sumOfRemovedElements = 0;
            int removedElement = 0;

            while (true)
            {
                if (inputArgs.Count == 0)
                {
                    break;
                }
                int currentIndex = int.Parse(Console.ReadLine());
                removedElement = ReturnRemovedElement(inputArgs, currentIndex);
                sumOfRemovedElements += removedElement;
                ReCalculateList(inputArgs, removedElement);
            }

            Console.WriteLine(sumOfRemovedElements);
        }

        static void ReCalculateList(List<int> inputArgs, int removedElement)
        {
            for (int i = 0; i < inputArgs.Count; i++)
            {
                if (inputArgs[i] <= removedElement)
                {
                    inputArgs[i] += removedElement;
                }
                else
                {
                    inputArgs[i] -= removedElement;
                }
            }
            return;
        }

        static int ReturnRemovedElement(List<int> inputArgs, int currentIndex)
        {
            int elementToRemove = 0;
            if (currentIndex < 0)
            {
                elementToRemove = inputArgs.First();
                int lastElement = inputArgs.Last();
                inputArgs[0] = lastElement;
            }
            else if (currentIndex > inputArgs.Count - 1)
            {
                elementToRemove = inputArgs.Last();
                int firstElement = inputArgs.First();
                inputArgs[inputArgs.Count - 1] = firstElement;
            }
            else
            {
                elementToRemove = inputArgs[currentIndex];
                inputArgs.RemoveAt(currentIndex);
            }
            return elementToRemove;
        }
    }
}

using System;
using System.Linq;

namespace BinarySearch
{
//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

    class BinarySearch
    {
        private static void PrintArray(int[] printArray)
        {
            for (int i = 0; i < printArray.Length; i++)
            {
                Console.Write(printArray[i]);
                if (i < printArray.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int[] sampleArray = { 15, 3, 1, 4, 2, 5, 8, 21, 13, 10 };
            Array.Sort(sampleArray);
            PrintArray(sampleArray);
            Console.Write("Select element:");
            int k = int.Parse(Console.ReadLine());
            int maxPosition = sampleArray.Length - 1;
            int minPosition = 0;
            int middlePosition = 0;
            int index = 0;
            do
            {
                middlePosition = (minPosition + maxPosition) / 2;
                if (sampleArray[middlePosition] < k)
                {
                    minPosition = middlePosition + 1;
                }
                else if (sampleArray[middlePosition] > k)
                {
                    maxPosition = middlePosition - 1;
                }
                else
                {
                    index = middlePosition;
                    Console.WriteLine("Index:{0}", index);
                    break;
                }   
            }
            while (maxPosition >= minPosition);
            if (index == 0 && sampleArray[middlePosition] != k)
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}

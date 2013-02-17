using System;
using System.Linq;

namespace MaxFrequentElement
{
//Write a program that finds the most frequent number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

    class MaxFrequentElement
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
            int n = 13;
            int[] sampleArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //int[] sampleArray = { 1, 1, 1, 4, 1, 3, 4, 1, 1, 2, 4, 9, 3 };
            PrintArray(sampleArray);
            int count = 0;
            int maxCount = 0;
            int element = 0;
            int maxCountElement = 0;
            for (int i = 0; i < n; i++)
            {
                count = 0;
                element = sampleArray[i];
                for (int j = 0; j < sampleArray.Length; j++)
                {
                    if (element == sampleArray[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxCountElement = element;
                }
            }
            Console.WriteLine("Number {0} appears {1} times",maxCountElement,maxCount);
        }
    }
}

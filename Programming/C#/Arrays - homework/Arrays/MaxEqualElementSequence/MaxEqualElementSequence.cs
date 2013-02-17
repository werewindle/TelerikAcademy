using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxEqualElementSequence
{
//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

    class MaxEqualElementSequence
    {
        private static void PrintArray(List<int> printArray)
        {
            foreach (int num in printArray)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            List<int> sampleArray = new List<int>() { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            List<int> resultsArray = new List<int>();
            PrintArray(sampleArray);
            int starPosition = 0;
            int endPosition = 0;
            int count = 0;
            int maxCount =0;
            //Find max element
            for (int i = 1; i < sampleArray.Count; i++)
            {
                if (sampleArray[i - 1] == sampleArray[i])
                {
                    count++;
                    if (maxCount <= count)
                    {
                        maxCount = count;
                        starPosition = i - maxCount;
                        endPosition = starPosition + maxCount;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = starPosition; i <= endPosition; i++)
            {
                resultsArray.Add(sampleArray[i]);
            }
            PrintArray(resultsArray);
        }
    }
}

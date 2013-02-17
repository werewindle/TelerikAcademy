using System;
using System.Linq;

namespace FindSequenceWithGivenSumS
{
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

    class FindSequenceWithGivenSumS
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
            int currentStartPosition = 0;
            int endPosition = 0;
            int sum = 0;
            int[] sampleArray = { 4, 3, 1, 4, 2, 5, 8 };
            PrintArray(sampleArray);
            int s = 11;
            Console.WriteLine("Sum = {0}",s);
            for (int i = 0; i < sampleArray.Length; i++)
            {
                if (sum == 0)
                {
                    currentStartPosition = i;
                }
                sum += sampleArray[i];

                if (sum > s)
                {
                    sum = 0;
                    i = i -1;
                }

                if (sum == s)
                {
                    endPosition = i;
                    break;
                }
            }
            for (int i = currentStartPosition; i <= endPosition; i++)
            {
                Console.Write(sampleArray[i]);
                if (i < endPosition)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }
}

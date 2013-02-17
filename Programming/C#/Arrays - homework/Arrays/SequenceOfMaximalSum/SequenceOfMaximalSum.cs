using System;
using System.Linq;

namespace SequenceOfMaximalSum
{
//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

    class SequenceOfMaximalSum
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
            int[] sampleArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            //int[] sampleArray = { 2, 3, 6, 2, -2, -1, -6, 4, 8, -8 };
            //int[] sampleArray = { 2, 3, 6, 2, 2, -1, 6, 4, 8, 8 };
            //int[] sampleArray = { -2, -3, -6, -2, -2, -1, -6, -4, -8, -8 };
            PrintArray(sampleArray);
            int currentStartPosition = 0;
            int endPosition = 0;
            int sum = 0;
            int maxSum = int.MinValue;
            
            for (int i = 0; i < sampleArray.Length; i++)
            {
                sum += sampleArray[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    endPosition = i;
                }
                if( sampleArray[i] >= sum)
                {
                    sum = sampleArray[i];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        endPosition = i;
                    }
                    currentStartPosition = i;
                } 
            }
            if (currentStartPosition > endPosition) // Check for single element
            {
                currentStartPosition = endPosition;
            }
            Console.WriteLine("Max sum = {0}",maxSum);
            for (int i = currentStartPosition; i <= endPosition; i++)
            {
                Console.Write(sampleArray[i]);
                if (i < endPosition )
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }
}

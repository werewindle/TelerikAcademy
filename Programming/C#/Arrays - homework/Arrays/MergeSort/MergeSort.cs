using System;
using System.Linq;

namespace MergeSort
{
//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

    class MergeSort
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
        static int[] MergeArrays(int[] leftArray, int[] rightArray)
        {
            int[] result = new int[leftArray.Length + rightArray.Length];

            int leftArrayIndex = 0;
            int rightArrayIndex = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (rightArrayIndex == rightArray.Length || ((leftArrayIndex < leftArray.Length) && (leftArray[leftArrayIndex] <= rightArray[rightArrayIndex])))
                {
                    result[i] = leftArray[leftArrayIndex];
                    leftArrayIndex++;
                }
                else if (leftArrayIndex == leftArray.Length || ((rightArrayIndex < rightArray.Length) && (rightArray[rightArrayIndex] <= leftArray[leftArrayIndex])))
                {
                    result[i] = rightArray[rightArrayIndex];
                    rightArrayIndex++;
                }
            }

            return result;
        }

        static int[] MergeSortFunc(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int middle = array.Length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[array.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                leftArray[i] = array[i];
            }

            for (int i = middle, j = 0; i < array.Length; i++, j++)
            {
                rightArray[j] = array[i];
            }

            leftArray = MergeSortFunc(leftArray);
            rightArray = MergeSortFunc(rightArray);

            return MergeArrays(leftArray, rightArray);
        }
        static void Main()
        {
            int[] sampleArray = { 1, 8, 3, 4, 7, 2, 6 };
            Console.WriteLine("Given Array");
            PrintArray(sampleArray);
            int[] finalArray = MergeSortFunc(sampleArray);
            Console.WriteLine("Sorted Array");
            PrintArray(finalArray);
        }
    }
}

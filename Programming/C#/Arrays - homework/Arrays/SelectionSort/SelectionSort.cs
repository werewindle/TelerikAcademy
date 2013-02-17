using System;
using System.Linq;

namespace SelectionSort
{
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm:
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

    class SelectionSort
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
            int[] sampleArray = { 1, 3, 5, 7, 9, 19, 5, 4 ,4,5,6,9,10};
            Console.WriteLine("Given Array");
            PrintArray(sampleArray);
            int min;
            int tempValue = 0;

            for (int j = 0; j < n - 1; j++)
            {
                min = j;
                for (int i = j + 1; i < n; i++)
                {
                    if (sampleArray[i] < sampleArray[min])
                    {
                        min = i;
                    }
                }
                if (min != j)
                {
                    tempValue = sampleArray[j];
                    sampleArray[j] = sampleArray[min];
                    sampleArray[min] = tempValue;
                }
            }
            Console.WriteLine("Sorted Array");
            PrintArray(sampleArray);
        }
    }
}

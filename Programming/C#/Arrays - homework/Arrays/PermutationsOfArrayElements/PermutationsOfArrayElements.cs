using System;
using System.Linq;

namespace PermutationsOfArrayElements
{
//* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//Example: n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

    class PermutationsOfArrayElements
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

        private static void Swap(ref int first,ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        private static void Permutations(int[] array, int current, int length)
        {
            if (current == length -1)
            {
                PrintArray(array);
            }
            else
            {
                for (int i = current; i < length; i++)
                {
                    Swap(ref array[i], ref array[current]);
                    Permutations(array, current + 1, length);
                    Swap(ref array[i], ref array[current]);
                }
            }

        }

        static void Main()
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            int[] sampleArray = new int[n];

            for (int i = 1; i <= n; i++)
            {
                sampleArray[i - 1] = i;
            }
            Permutations(sampleArray, 0, sampleArray.Length);
        }
    }
}

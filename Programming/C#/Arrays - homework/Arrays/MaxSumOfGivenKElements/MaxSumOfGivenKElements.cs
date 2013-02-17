using System;
using System.Linq;

namespace MaxSumOfGivenKElements
{
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

    class MaxSumOfGivenKElements
    {
        static void Main()
        {
            Console.Write("Array length N:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Number of elements to sum K:");
            int k = int.Parse(Console.ReadLine());
            int[] sampleArray = new int[n];
            int maxSum = 0;
            //Initialize Array
            for (int i = 0; i < sampleArray.Length; i++)
            {
                Console.Write("Array element {0}:", i);
                sampleArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sampleArray);
            for (int i = n -1 ; i > ((n -1) - k); i--)
            {
                maxSum += sampleArray[i];
                Console.Write(sampleArray[i]);
                if (i > (n -2))
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum={0}", maxSum);
        }
    }
}
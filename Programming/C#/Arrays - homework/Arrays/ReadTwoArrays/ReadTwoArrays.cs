using System;
using System.Linq;

namespace ReadTwoArrays
{
//Write a program that reads two arrays from the console and compares them element by element.

    class ReadTwoArrays
    {
        static void Main()
        {
            Console.Write("Arrays lenght N:");
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("FirstArray[{0}]: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("SecondArray[{0}]:", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("FirstArray[{0}]:{1} = SecondArray[{0}]:{2}? {3}", i, firstArray[i], secondArray[i], firstArray[i] == secondArray[i]);
            }
        }
    }
}

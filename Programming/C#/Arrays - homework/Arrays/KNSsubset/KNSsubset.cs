using System;
using System.Collections.Generic;
using System.Linq;

namespace KNSsubset
{
//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.

    class KNSsubset
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
            Console.Write("Array lengt N: ");
            int n = int.Parse(Console.ReadLine());
            //Initialize array
            int[] sampleArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}:", i);
                sampleArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Number of elements to sum K:");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Search for sum s:");
            int s = int.Parse(Console.ReadLine());
            int[] tempArray = new int[sampleArray.Length];
            int binNumber = (int)Math.Pow(2, sampleArray.Length) - 1;
            int tempBin = 0;
            int sum =0;
            int count = 0;
            List<int> resultList = new List<int>();

            //Use Binary number
            for (int i = 1; i <= binNumber; i++)
            {
                //Temp array with number converted to binary
                tempBin = i;
                for (int l = 0; l < tempArray.Length; l++)
                {
                    tempArray[l] = tempBin % 2;
                    tempBin = tempBin / 2;
                }
                count = 0;
                //Count 1 in the number
                for (int l = 0; l < tempArray.Length; l++)
                {
                    if (tempArray[l] == 1)
                    {
                        count++;
                    }
                }
                sum = 0;
                if (k == count)
                {
                    resultList.Clear();
                    //Sum elements
                    for (int j = 0; j <= sampleArray.Length; j++)
                    {
                        int mask = 1 << j;
                        int iAndMask = i & mask;
                        int bit = iAndMask >> j;
                        if (bit == 1)
                        {
                            sum += sampleArray[j];
                            resultList.Add(sampleArray[j]);
                        }
                    }
                    //Check for S
                    if (sum == s)

                    {
                        break;
                    }
                }
            }
            if (sum!=0)
            {
                Console.WriteLine("Sum = {0}", sum);
                Console.Write("Elements:");
                PrintArray(resultList);
            }
            else
            {
                Console.WriteLine("Sum = {0}", s);
                Console.WriteLine("Not found");
            }
        }
    }
}

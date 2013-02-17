using System;
using System.Linq;
using System.Collections.Generic;

namespace SubsetOfKElements
{
//* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

    class SubsetOfKElements
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
            //int k = int.Parse(Console.ReadLine());
            List<int> sampleArray = new List<int>() { -2, 1, 2, 4, -3, 5, -2, 6 };
            Console.WriteLine("Given Array");
            PrintArray(sampleArray);
            int s = 14;
            Console.WriteLine("S= {0}", s);
            List<int> resultList = ExistingSubset(sampleArray, s);
            if (ExistingSubset(sampleArray, s) == null)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                PrintArray(resultList);
            }
        }

        private static List<int> ExistingSubset(List<int> sampleArray, int s)
        {
            int[] tempArray = new int[sampleArray.Count];
            int binNumber = (int)Math.Pow(2, sampleArray.Count) - 1;
            int tempBin = 0;
            int sum = 0;
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
                //Sum elements
                resultList.Clear();
                for (int j = 0; j <= sampleArray.Count; j++)
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
            if (sum == s)
            {
                return resultList;
            }
            else
            {
                return null;
            }
        }
    }
}

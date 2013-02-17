using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintArrayOfMaxSequence
{
//* Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order.
//Print the remaining sorted array. Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

    class PrintArrayOfMaxSequence
    {
        private static void ExistingSubset(List<int> sampleArray)
        {
            int[] tempArray = new int[sampleArray.Count];
            int binNumber = (int)Math.Pow(2, sampleArray.Count) - 1;
            int tempBin = 0;
            int maxCount = 0;
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
                //Add subset elements
                List<int> tempList = new List<int>();
                for (int j = 0; j <= sampleArray.Count; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = i & mask;
                    int bit = iAndMask >> j;
                    if (bit == 1)
                    {
                        tempList.Add(sampleArray[j]);
                    }
                }
                //Check for new array
                if (count > maxCount && IsSorted(tempList))
                {
                    resultList = tempList; 
                    maxCount = count;
                }
            }
            PrintArray(resultList);
        }

        private static bool IsSorted(List<int> printList)
        {
            bool isSorted = true;

            for (int i = 0; i < printList.Count - 1; i++)
            {
                if (printList[i] >= printList[i + 1])
                {
                    isSorted = false;
                }
            }
            return isSorted;
        }

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
            List<int> sampleArray = new List<int>() { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            //List<int> sampleArray = new List<int>() { 1, 2, 1, 1, 1 };
            Console.WriteLine("Input Array");
            PrintArray(sampleArray);
            Console.WriteLine("Sorted subset Array");
            ExistingSubset(sampleArray);
        }
    }
}

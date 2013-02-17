using System;
using System.Linq;

namespace QuickSort
{
//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

    class QuickSort
    {
        private static void PrintArray(string[] printArray)
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
        public static string[] QuickSortFunc( string[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = (left+right)/2;
            string tempValue = "";
            while (i < j - 1)
            {
                while (pivot < j)
                {
                    if (string.Compare(array[pivot] , array[j]) > 0)
                    {
                        tempValue = array[pivot];
                        array[pivot] = array[j];
                        array[j] = tempValue;
                        pivot = j;
                    }
                    else
                    {
                        j--;
                    }
                }
                while (pivot > i)
                {
                    if (string.Compare(array[pivot] , array[i]) < 0)
                    {
                        tempValue = array[pivot];
                        array[pivot] = array[i];
                        array[i] = tempValue;
                        pivot = i;
                    }
                    else
                    {
                        i++;
                    }
                }

            }
            if (i > left)
            {
                QuickSortFunc(array,left,i);
            }
            if (j < right)
            { 
                QuickSortFunc(array,j,right);
            }
            return array;
        }
        static void Main()
        {

            string[] sampleArray = { "zbc", "abcd", "c", "abd", "ad", "kabc","jjcf","fmkz" };
            Console.WriteLine("Given Array");
            PrintArray(sampleArray);
            string[] resultArray = QuickSortFunc(sampleArray,0,sampleArray.Length-1);
            Console.WriteLine("Sorted Array");
            PrintArray(resultArray);
        }
    }
}

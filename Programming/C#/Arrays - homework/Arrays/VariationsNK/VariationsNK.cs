using System;
using System.Linq;

namespace VariationsNK
{
//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

    class VariationsNK
    {
        private static void PrintArray(int [] resultArray)
        {
            foreach (int num in resultArray)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();
        }

        private static void Variations(int n, int k)
        {
            int[] resultArray = new int[k];
            int currentPostion = resultArray.Length - 1;
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = 1;
            }
            while (currentPostion >= 0)
            {
                while (resultArray[currentPostion] <= n)
                {
                    currentPostion = resultArray.Length - 1;
                    PrintArray(resultArray);
                    resultArray[currentPostion] += 1;
                }
                currentPostion--;
                if (currentPostion >= 0)
                {
                    resultArray[currentPostion] += 1;
                    for (int i = currentPostion + 1; i < resultArray.Length; i++)
                    {
                        resultArray[i] = 1;
                    }
                }
            }
        }
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            Variations(n, k);
        }
    }
}

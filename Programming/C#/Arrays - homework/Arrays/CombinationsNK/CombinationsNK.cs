using System;
using System.Linq;

namespace CombinationsNK
{
//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

    class CombinationsNK
    {

        private static void PrintArray(int[] resultArray)
        {
            foreach (int num in resultArray)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();
        }

        private static void Combinations(int n, int k)
        {
            
            int[] resultArray = new int[k];
            int currentPostion = resultArray.Length - 1;
            int lastPostion = resultArray.Length - 1;
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = i + 1;
            }
            while (resultArray[0] <= ((n -k)+1))
            {
                currentPostion = lastPostion;
                resultArray[currentPostion] = resultArray[lastPostion -1] + 1;
                while (resultArray[currentPostion] <= n) 
                {
                    PrintArray(resultArray);
                    resultArray[currentPostion] += 1;
                }
                currentPostion--;
                if (currentPostion >= 0)
                {
                    for (int i = 0; i < lastPostion; i++)
                    {
                        resultArray[i] += 1;
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
            Combinations(n, k);
        }
    }

}

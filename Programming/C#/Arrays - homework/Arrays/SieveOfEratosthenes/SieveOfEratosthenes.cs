using System;
using System.Linq;

namespace SieveOfEratosthenes
{
//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
    
    class SieveOfEratosthenes
    {
        private static int[] SieveOfErathosthenesFunc(int n)
        {

            int[] sampleArray = new int[n-1];
            for (int i = 0, j = 2; i < sampleArray.Length; i++, j++)
            {
                sampleArray[i] = j;
            }
            for (int i = 2; i < (int)Math.Sqrt(n - 1); i++)
            {
                for (int j = (2 * i) - 2; j < sampleArray.Length; j += i)
                {
                    sampleArray[j] = 0;
                }
            }
            return sampleArray;
        }
        static void Main()
        {
            //int n = 100; //Input Value
            int n = 10000000; //Input Value
            int[] resultArray = SieveOfErathosthenesFunc(n);
            for (int k = 0; k < resultArray.Length; k++)
            {
                if (resultArray[k] != 0)
                {
                    Console.Write(resultArray[k] + ",");
                }
            }
            Console.WriteLine();
        }
  
        
    }
}

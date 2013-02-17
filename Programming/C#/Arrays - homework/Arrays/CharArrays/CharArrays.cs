using System;
using System.Linq;

namespace CharArrays
{
//Write a program that compares two char arrays lexicographically (letter by letter).

    class CharArrays
    {
        static void Main()
        {
            ////First test - First array is lexicographically earlier
            //char[] firstArray = { 'a', 'a', 'a' };
            //char[] secondArray = { 'a', 'b', 'a', 'a', 'a' };
            //Second Test - Second array is lexicographically earlier
            char[] firstArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            char[] secondArray = { 'a', 'b', 'a', 'a', 'a' };
            //Third Test - Both arrays are equal
            //char[] firstArray = { 'a', 'b', 'a' };
            //char[] secondArray = { 'a', 'b', 'a' };
            int firstArrayPriority = 0;
            int secondArrayPriority = 0;
            string biggestArray =  (firstArray.Length >= secondArray.Length)?"firstArray":"secondArray";
            if (biggestArray == "firstArray")
	        {
		         for (int i = 0; i < firstArray.Length; i++)
                    {
                        if (i > secondArray.Length - 1)
                        {
                            break;
                        }
                        else
                        {
                            if (firstArray[i]<secondArray[i])
                            {
                                secondArrayPriority++;
                            }
                            else if (firstArray[i] > secondArray[i])
                            {
                                firstArrayPriority++;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
	        }
            if (biggestArray == "secondArray" )
            {
                for (int i = 0; i < secondArray.Length; i++)
                    {
                        if (i > firstArray.Length - 1)
                        {
                            break;
                        }
                        else
                        {
                            if (firstArray[i]<secondArray[i])
                            {
                                secondArrayPriority++;
                            }
                            else if (firstArray[i] > secondArray[i])
                            {
                                firstArrayPriority++;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
            }
            if (firstArrayPriority < secondArrayPriority)
            {
                Console.WriteLine("First Array is lexicographically earlier");
            }
            else if (firstArrayPriority > secondArrayPriority)
            {
                Console.WriteLine("Second Array is lexicographically earlier");
            }
            else
            {
                Console.WriteLine("Both Arrays are lexicographically equal");
            }
        }
    }
}

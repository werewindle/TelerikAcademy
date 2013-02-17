using System;
using System.Collections.Generic;
using System.Linq;

namespace FindWordLettersIndexes
{
//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

    class FindWordLettersIndexes
    {
        static void Main()
        {
            char[] charsArray = new char[26];
            List<char> tempCharList = new List<char>();
            for (int i = 0; i < charsArray.Length; i++)
            {
                charsArray[i] = (char)(65+i);
            }
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            tempCharList.AddRange(word.ToString().ToUpper().ToCharArray());
            int maxPosition = charsArray.Length - 1;
            int minPosition = 0;
            int middlePosition = 0;
            int index = 0;
            for (int k = 0; k < tempCharList.Count; k++)
            {
                maxPosition = charsArray.Length - 1;
                minPosition = 0;
                middlePosition = 0;
                for (int i = 0; i < charsArray.Length; i++)
			    {
                    middlePosition = (minPosition + maxPosition) / 2;
                    if (charsArray[middlePosition] < tempCharList[k])
                    {
                        minPosition = middlePosition + 1;
                    }
                    else if (charsArray[middlePosition] > tempCharList[k])
                    {
                        maxPosition = middlePosition - 1;
                    }
                    else
                    {
                        index = middlePosition;
                        Console.WriteLine("Letter:{0} ,Index:{1}",tempCharList[k], index + 1);
                        break;
                    }
			    }
            }
            
        }
    }
}

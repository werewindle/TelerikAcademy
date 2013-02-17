using System;
using System.Linq;

namespace AllocateArray
{

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.

    class AllocateArray
    {
        static void Main()
        {
            int[] array = new int[20];
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = index*5;
            }
            Console.WriteLine("Array with 20 elements:");
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine("Array[{0}]: {1}",index,array[index]);
            }
        }
    }
}
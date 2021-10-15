using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    class ArrayToSubArray
    {
        public static void GetSubArray(int[] array, int size)
        {
            List<int[]> result = new List<int[]> { };
            int[] tempArray = new int[size];
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[counter] = array[i];
                counter++;
                if(counter == size)
                {
                    counter = 0;
                    int[] subArray = new int[size];
                    tempArray.CopyTo(subArray, size);
                    Array.Copy(tempArray, subArray, size);
                    result.Add(subArray);
                }
            }
        }
    }
}

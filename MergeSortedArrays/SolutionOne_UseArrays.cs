using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.MergeSortedArrays
{
    internal class SolutionOne_UseArrays
    {
        public static int[] MergeAndPreserveSorting(int[] array1, int[] array2)
        {

            // if both arrays are empty, simply return empty array
            if(!array1.Any() && !array2.Any())
                return array1;

            // if first array is empty return second array which is already sorted
            if(!array1.Any())
                return array2;

            // if second array is empty return first array which is already sorted
            if (!array2.Any()) 
                return array1;


            // first Array's index
            var i = 0;
            // second Array's index
            var j = 0;
            // merged array's index
            var k = 0;

            // resulting array having length of array1 + array2
            var mergedArray = new int[array1.Length + array2.Length];

            //while both arrays have same number elements to traverse
            while(i < array1.Length && j < array2.Length)
            {
                //first array's element is smaller, fill it in resulting array, increment pointers to indices of array1 and mergedArray
                if (array1[i] < array2[j])
                {
                    mergedArray[k] = array1[i];
                    i++;
                    k++;
                }
                else //second array's element is smaller, fill it in resulting array, increment pointers to indices of array2 and mergedArray
                {
                    mergedArray[k] = array2[j];
                    j++; 
                    k++;
                }
            }

            // loop and fill if there are still some elements remaining to be traversed in array1
            while(i < array1.Length)
            {
                mergedArray[k] = array1[i];
                i++;
                k++;
            }

            // loop and fill if there are still some elements remaining to be traversed in array2
            while (j < array2.Length)
            {
                mergedArray[k] = array2[j];
                j++;
                k++;
            }

            return mergedArray;
        }
    }
}


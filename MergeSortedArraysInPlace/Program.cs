using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.MergeSortedArraysInPlace
{
    internal class Program
    {
        static int[] Array1 = [2, 0];
        static int[] Array2 = [1];

        public static void Main(string[] args)
        {
            Console.WriteLine("Merge Sorted Arrays");

            MergeSortedArrays(ref Array1, 1, Array2, 1);

            Console.Write("Merged Array - [ ");
            foreach (var item in Array1)
            {
                Console.Write(item + " ");
            }
            Console.Write("]");
        }

        public static void MergeSortedArrays(ref int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
                return;

            int fillAtIndex = (m + n) - 1;

            while (m > 0 && n > 0)
            {
                int firstArrElement = nums1[m - 1];
                int secondArrElement = nums2[n - 1];

                if (firstArrElement > secondArrElement)
                {
                    nums1[fillAtIndex] = firstArrElement;
                    m--;
                    fillAtIndex--;
                }
                else
                {
                    nums1[fillAtIndex] = secondArrElement;
                    n--;
                    fillAtIndex--;
                }
            }

            while (n > 0)
            {
                nums1[fillAtIndex] = nums2[n - 1];
                n--;
                fillAtIndex--;
            }
        }
    }
}

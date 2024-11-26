//// Question -Given two arrays arr1[] and arr2[] of size m and n respectively, the task is to determine whether arr2[] is a subset of arr1[].
//// Both arrays are not sorted, and elements are distinct.

////Examples:

////Input: arr1[] = { 11, 1, 13, 21, 3, 7 }, arr2[] = { 11, 3, 7, 1 }
////Output: Yes


////Input: arr1[] = { 1, 2, 3, 4, 5, 6 }, arr2[] = { 1, 2, 4 } 
////Output: Yes


////Input: arr1[] = { 10, 5, 2, 23, 19 }, arr2[] = { 19, 5, 3 } 
////Output: No

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.CheckIfArrayIsSubsetOfAnotherArray
//{
//    internal class Program
//    {
//        static int[] Nums1 = [11, 1, 13, 21, 3, 7];
//        static int[] Nums2 = [11, 3, 7, 1];

//        //static int[] Nums1 = [1, 2, 3, 4, 5, 6];
//        //static int[] Nums2 = [1, 2, 4];

//        //static int[] Nums1 = [10, 5, 2, 23, 19];
//        //static int[] Nums2 = [19, 5, 3];

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Determine if second array is subset of the first array");

//            Console.Write("Input Array1 - [");
//            foreach (var item in Nums1)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.Write("]\n");

//            Console.Write("Input Array2 - [");
//            foreach (var item in Nums2)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.Write("]\n");

//            //var output = SolutionOne_Naive.CheckForArraySubset(Nums1, Nums2);

//            var output = SolutionTwo_Efficient.CheckForArraySubset(Nums1, Nums2);


//            Console.WriteLine("Output - {0}", output == true ? "Yes" : "No");

//        }
//    }
//}


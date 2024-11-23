//// Question - Given an integer array nums, find the subarray with the largest sum, and return its sum.

//// Example 1:
////Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
////Output: 6
////Explanation: The subarray[4, -1, 2, 1] has the largest sum 6.

////Example 2:

////Input: nums = [1]
////Output: 1
////Explanation: The subarray[1] has the largest sum 1.
////Example 3:

////Input: nums = [5, 4, -1, 7, 8]
////Output: 23
////Explanation: The subarray[5, 4, -1, 7, 8] has the largest sum 23.

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.FindMaximumSumSubarray
//{
//    internal class Program
//    {
//        //static int[] Nums = [5, 4, -1, 7, 8];
//        //static int[] Nums = [2, 3, -8, 7, -1, 2, 3];
//        //static int[] Nums = [];
//        static int[] Nums = [-1, -4];

//        public static void Main(string[] args)
//        {
//            Console.Write("\nFind maximum sum subarray - [ ");
//            foreach (var item in Nums)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.Write("]\n");

//            // Naive approach Time Complexity - O(n^2) Space Complexity - O(1)
//            //var maximumSum = SolutionOne_Naive.FindMaximumSumInSubarray(Nums);

//            // Better approach using Kadane's algorithm Time Complexity - O(n) Space Complexity - O(1)
//            var maximumSum = SolutionTwo_KadanesAlgo.FindMaximumSumInSubarray(Nums);

//            Console.Write($"Maximum sum in a subarray = {maximumSum}");

//        }

//    }
//}

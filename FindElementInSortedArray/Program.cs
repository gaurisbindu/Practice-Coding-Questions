//// Question - Given a sorted array of integers and an integer called target, find the element that equals the target and return its index.
//// If the element is not found, return -1.

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.FindElementInSortedArray
//{
//    internal partial class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Find element in sorted Arrays");
//            var nums = new int[5] { 1, 2, 3, 4, 5 };
//            int target = 2;

//            Console.Write("Input - [");
//            foreach (var item in nums)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.Write("]\n");

//            Console.WriteLine("targe - " + target);

//            // O(N)
//            //var result = SolutionOne_Naive.FindElementInArray(nums, target);

//            // O(logN)
//            var result = SolutionTwo_Efficient.FindElementInArray(nums, target);

//            Console.WriteLine("Result - " + result);

//            Console.ReadLine();
//        }
//    }
//}

//Question - Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

//Example 1:

//Input: nums = [1,2,3,4,5,6,7], k = 3
//Output: [5,6,7,1,2,3,4]
//Explanation:
//rotate 1 steps to the right: [7,1,2,3,4,5,6]
//rotate 2 steps to the right: [6,7,1,2,3,4,5]
//rotate 3 steps to the right: [5,6,7,1,2,3,4]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.RotateArrayByGivenSteps
{
    internal class Program
    {
        static int[] Nums = [1, 2, 3, 4, 5, 6, 7];
        static int k = 3;

        public static void Main(string[] args)
        {
            Console.WriteLine("Given an integer array nums, rotate the array to the right by k steps, where k is non-negative");
            Console.Write("Input - [");
            foreach (var item in Nums)
            {
                Console.Write(item + ", ");
            }
            Console.Write("]\n");

            //var result = SolutionOne.RotateArrayByGivenSteps(Nums, 3);

            var result = SolutionTwo_Efficient.RotateArrayByGivenSteps(Nums, 3);

            Console.Write("Output - [");
            foreach (var item in result)
            {
                Console.Write(item + ", ");
            }
            Console.Write("]\n");
        }
    }
}

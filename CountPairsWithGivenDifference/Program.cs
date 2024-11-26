//Question - Given an array arr[] and a positive integer k, the task is to count all pairs (i, j)
//such that i < j and absolute value of (arr[i] – arr[j]) is equal to k.

//Examples: 

//Input: arr[] = { 1, 4, 1, 4, 5 }, k = 3
//Output: 4
//Explanation: There are 4 pairs with absolute difference 3, the pairs are {1, 4}, { 1, 4}, { 1, 4}
//and {4, 1} 

//Input: arr[] = {8, 16, 12, 16, 4, 0}, k = 4
//Output: 5
//Explanation: There are 5 pairs with absolute difference 4, the pairs are {8, 12}, { 8, 4}, { 16, 12}, { 12, 16}, { 4, 0}.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.CountPairsWithGivenDifference
{
    internal class Program
    {
        static int[] Nums = [1, 4, 1, 4, 5];
        static int TargetDifference = 3;

        //static int[] Nums = [8, 16, 12, 16, 4, 0];
        //static int TargetDifference = 4;

        public static void Main(string[] args)
        {
            Console.WriteLine("Determine if second array is subset of the first array");

            Console.Write($"Input \n Target Differnce - {TargetDifference}");
            Console.Write("\nArray - [");
            foreach (var item in Nums)
            {
                Console.Write(item + ", ");
            }
            Console.Write("]\n");

            //var output = SolutionOne_Naive.PairsWithGivenDifference(Nums, TargetDifference);

            //var output = SolutionTwo_Efficient.PairsWithGivenDifference(Nums, TargetDifference);

            var output = SolutionThree_Efficient.PairsWithGivenDifference(Nums, TargetDifference);



            Console.WriteLine($"Output - {output}");

        }
    }
}

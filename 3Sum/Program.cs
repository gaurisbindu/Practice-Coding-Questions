using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions._3Sum
{
    internal class Program
    {
        static int[] Nums = [-1, 0, 1, 2, -1, -4];

        public static void Main(string[] args)
        {
            Console.WriteLine("Given an array - Find and return unique triplet such that addition of them is 0");
            Console.Write("Input - [");
            foreach (var item in Nums)
            {
                Console.Write(item + ", ");
            }
            Console.Write("]\n");

            var result = SolutionOne_Naive.ThreeSum(Nums);

            Console.Write("Output - [");
            foreach (var item in result)
            {
                Console.Write($"[{item[0]}, {item[1]}, {item[2]}] ");
            }
            Console.Write("]\n");
        }
    }
}

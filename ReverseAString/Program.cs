//Question - Given a string revers the string and print
// For Ex - "My name is Gauri" this string should be printed as "iruaG si eman yM"

using Practice_Coding_Questions.MergeSortedArrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.ReverseAString
{
    internal class Program
    {
        static string sample = "gauri";

        public static void Main(string[] args)
        {
            Console.WriteLine("Reverse a string");

            Console.WriteLine("Original String - " + sample);

            //Using arrays BigO(n)
            var result = SolutionOne_UseArrays.Reverse(sample);
            
            Console.Write("\nReversed string using Arrays - ");
            Console.WriteLine(result);

            //Using recursion  BigO(n)
            result = SolutionTwo_UseRecursion.Reverse(sample);

            Console.Write("\nReversed string using Recursion - ");
            Console.WriteLine(result);
        }

    }
}

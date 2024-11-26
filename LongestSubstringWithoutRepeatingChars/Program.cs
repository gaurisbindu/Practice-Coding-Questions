//Question - Given a string s, find the length of the longest substring without repeating characters.

//Example 1:

//Input: s = "abcabcbb"
//Output: 3
//Explanation: The answer is "abc", with the length of 3.
//Example 2:

//Input: s = "bbbbb"
//Output: 1
//Explanation: The answer is "b", with the length of 1.
//Example 3:

//Input: s = "pwwkew"
//Output: 3
//Explanation: The answer is "wke", with the length of 3.
//Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

using Practice_Coding_Questions.CountPairsWithGivenDifference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.LongestSubstringWithoutRepeatingChars
{
    internal class Program
    {
        public static string Input  = "abcabcbb";

        public static void Main(string[] args)
        {
            Console.WriteLine("Find the longest substring with non repeating characters");
            Console.WriteLine($"Input - {Input}");

            var output = SolutionTwo_Efficient.FindLongestSubstring(Input);

            Console.WriteLine($"Output - {output}");

        }
    }

}

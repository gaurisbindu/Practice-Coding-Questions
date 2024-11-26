using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.LongestSubstringWithoutRepeatingChars
{
    internal class SolutionTwo_Efficient
    {
        // This solution is implmeneted using Sliding Window pattern
        // Initialize :
        // 1. 2 pointers (left & right) for the  array traversal.
        // 2. A hashset to save unique characters to achieve time complexity of O(1) on inserts
        // 3. A variable to store maxLength
        // Due to sliding window, use the while loop. loop until right pointer reach its end.
        // Insid ethe loop, if char was not in hashset, add it and move right pointer ahead.
        // Calculate max length to maximum of previous length and current length.
        // If char was already in the hashset, remove it from hashset, move left pointer ahead.
        // Return maxLentgh once you are out of the loop


        public static int FindLongestSubstring(string input)
        {
            int left = 0;
            int right = 0;
            int maxLength = 0;
            HashSet<char> words = new();

            while(right < input.Length)
            {
                if (!words.Contains(input[right]))
                {
                    words.Add(input[right]);
                    right++;
                    maxLength = Math.Max(maxLength, right - left);
                }
                else
                {
                    words.Remove(input[left]);
                    left++;
                }


            }

            return maxLength;
        }
    }
}

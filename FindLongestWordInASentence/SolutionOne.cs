using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.FindLongestWordInASentence
{
    internal class SolutionOne
    {
        public static string FindLongestWord(string sentence)
        {
            string longestWord = string.Empty;

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                var wordWithoutSpecialChars = Regex.Replace(words[i], "[^A-Za-z]", "");

                if(i== 0)
                    longestWord = wordWithoutSpecialChars;

                if (longestWord.Length < words[i].Length)
                {
                    longestWord = wordWithoutSpecialChars;
                }
            }

            return longestWord;
        }
    }
}

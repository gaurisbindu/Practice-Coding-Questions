using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.ReverseAString
{
    internal class SolutionOne_UseArrays
    {
        public static string Reverse(string sample)
        {
            var result = string.Empty;

            //check input
            if(string.IsNullOrWhiteSpace(sample) || sample.Length < 2) 
                return result;

            for (int i = sample.Length - 1; i >= 0; i--)
            {
                result += sample[i];
            }

            return result;
        }
    }
}

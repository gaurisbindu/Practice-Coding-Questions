using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.ReverseAString
{
    internal class SolutionTwo_UseRecursion
    {

        //0 1 2 3 4
        //----------
        //g a u r i
        //Reverse(gauri)
        //Reverse(auri)
        //Reverse(uri)
        //Reverse(ri)
        //Reverse(i)
        public static string Reverse(string sample)
        {
            if (string.IsNullOrWhiteSpace(sample))
                return string.Empty;
            
            if(sample.Length == 1) 
                return sample;

            var first = sample[0];
            var remaining = sample.Substring(1, sample.Length - 1);

            return Reverse(remaining) + first;
        }
    }
}

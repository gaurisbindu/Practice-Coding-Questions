using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions
{
    internal class SolutionTwo_Efficient
    {
        public static bool DoesArraysContainCommonElements(char[] array1, char[] array2)
        {
            HashSet<int> lookup = new HashSet<int>();

            for (int i = 0; i < array1.Length; i++)
            {
                lookup.Add(array1[i]);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (lookup.Contains(array2[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

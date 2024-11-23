using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions
{
    internal class SolutionOne_Naive
    {
        public static bool DoesArraysContainCommonElements(char[] array1, char[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                        return true;
                }
            }
            return false;
        }
    }
}

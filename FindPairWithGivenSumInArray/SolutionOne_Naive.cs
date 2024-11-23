using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.FindPairWithGivenSumInArray
{
    internal class SolutionOne_Naive
    {
        public static bool FindPairWithGivenSumInArray(int[] numbers, int sum)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] + numbers[j] == sum)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

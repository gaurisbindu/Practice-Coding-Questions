using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.FindPairWithGivenSumInArray
{
    internal class SolutionTwo_Efficient
    {
        public static bool FindPairWithGivenSumInArray(int[] numbers, int sum)
        {
            HashSet<int> compliment = new HashSet<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if(compliment.Contains(numbers[i]))
                    return true;
                compliment.Add(sum - numbers[i]);
            }

            return false;
        }
    }
}

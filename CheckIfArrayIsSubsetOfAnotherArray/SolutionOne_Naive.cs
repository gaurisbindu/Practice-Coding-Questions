using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.CheckIfArrayIsSubsetOfAnotherArray
{
    internal class SolutionOne_Naive
    {
        public static bool CheckForArraySubset(int[] nums1, int[] nums2)
        {
            if (!nums1.Any() && !nums2.Any())
                return true;

            if (!nums1.Any() && nums2.Any())
                return false;

            if (nums1.Any() && !nums2.Any())
                return true;

            int[] foundAlements = new int[nums2.Length];
            var k = 0;
            for (int i = 0; i< nums2.Length; i++)
            {
                for(int j=0; j < nums1.Length; j++)
                {
                    if(nums2[i] == nums1[j])
                    {
                        foundAlements[k] = nums2[i];
                        k++;
                        break;
                    }
                }
            }

            if(k == nums2.Length)
            {
                return true;
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//The idea is to count the frequency of each number in a hash map or dictionary as we go through the array Iterate over the array
//and for each element arr[i], we need another element say complement such that abs(arr[i] – complement) = k. Now, we can have two cases:


// abs(arr[i] – complement) is positive:
//arr[i] – complement = k
//So, complement = arr[i] – k
//abs(arr[i] – complement) is negative: 
//– (arr[i] – complement) = k
//So, complement = arr[i] + k
//So for each element arr[i], we can check if complement (arr[i] + k) or (arr[i] – k) is present in the hash map. If it is, increment the
//count variable by the occurrences of complement in map.

namespace Practice_Coding_Questions.CountPairsWithGivenDifference
{
    internal class SolutionThree_Efficient
    {
        public static int PairsWithGivenDifference(int[] nums, int targetDiff)
        {
            int arrayLength = nums.Length;
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int pairsCount = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (frequency.ContainsKey(nums[i] + targetDiff))
                    pairsCount += frequency[nums[i] + targetDiff];

                if (frequency.ContainsKey(nums[i] - targetDiff))
                    pairsCount += frequency[nums[i] - targetDiff];

                if (frequency.ContainsKey(nums[i]))
                    frequency[nums[i]]++;
                else
                    frequency[nums[i]] = 1;
            }
            return pairsCount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Good_Pairs_1512_
{
    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int pairs = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        pairs += 1;
                    }
                }
            }
            return pairs;
        }
    }
}

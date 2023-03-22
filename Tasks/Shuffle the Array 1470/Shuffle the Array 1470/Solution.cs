using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle_the_Array_1470
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            /*List<int> ShuffleArray = new List<int>();
            for (int i = 0; i < n; i++) {
                ShuffleArray.Add(nums[i]);
                ShuffleArray.Add(nums[i + n]);
            }
            return ShuffleArray.ToArray();*/
            int[] result = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                result[i * 2] = nums[i];
                result[i * 2 + 1] = nums[i + n];
            }
            return result;
           /* int[] result = new int[n * 2];
            int j = 0;
            for (int i = 0; i < n * 2; i += 2)
            {
                result[i] = nums[j];
                result[i + 1] = nums[j + n];
                j++;
            }
            return result;*/
        }
    }
}

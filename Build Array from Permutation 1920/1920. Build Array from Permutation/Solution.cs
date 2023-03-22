using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1920._Build_Array_from_Permutation
{
    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            /*int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++) { 
                result[i] = nums[nums[i]];
            }
            return result;*/
            /*int[] result = new int[nums.Length*2];
            int length = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[i + length] = nums[i];
            }
            return result; */
            //return nums.Select(i => nums[i]).ToArray();
            return nums.Concat(nums).ToArray();
        }
    }
}

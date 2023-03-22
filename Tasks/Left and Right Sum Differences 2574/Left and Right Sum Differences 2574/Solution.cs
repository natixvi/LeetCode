using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum_Differences_2574
{
    public class Solution
    {
        public int[] LeftRigthDifference(int[] nums){

            int[] res = new int[nums.Length];
            int rightSum = 0, leftSum = 0;
            rightSum = nums.Sum();
            for (int i = 0; i < nums.Length; i++)
            {
                rightSum -= nums[i];
                res[i] = Math.Abs(leftSum - rightSum);
                leftSum += nums[i];

            }
            return res;
            
        }








        /*public int[] LeftSum(int[] nums)
        {
            int[] res = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++){
                if (i == 0){
                    res[i] = 0;
                }
                else {
                    for (int j = 0; j < i; j++)
                    {
                        res[i] += nums[j];
                    }
                }
            }
            return res;
        }
        public int[] RightSum(int[] nums)
        {
            int[] res = new int[nums.Length];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                {
                    res[i] = 0;
                }
                else
                {
                    for (int j = nums.Length - 1; j > i; j--)
                    {
                        res[i] += nums[j];
                    }
                }
            }
            return res;
        }*/
    }
}

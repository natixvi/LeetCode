using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProfit
{
    class Solution
    {
        public int MaxProfit(int[] prices)
        {

            int min = prices[0];
            int diff = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
                }

                if (prices[i] - min > diff)
                {
                    diff = prices[i] - min;
                }

            }
            return diff;


        }
    }
}
      

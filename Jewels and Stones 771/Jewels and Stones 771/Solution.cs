using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels_and_Stones_771
{
    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int total = 0;
            foreach (char s in stones) {
                if (jewels.Contains(s)){
                    total++;
                }   
            }
            return total;
        }
    }
}

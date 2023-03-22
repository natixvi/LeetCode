using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011._Final_Value_of_Variable_After_Performing_Operations
{
    public class Solution
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            foreach (string op in operations)
            {
                if (op == "++X" || op == "X++")
                {
                    x += 1;
                }
                else if (op == "--X" || op == "X--")
                {
                    x -= 1;
                }
            }
            return x;
        }
    }
}

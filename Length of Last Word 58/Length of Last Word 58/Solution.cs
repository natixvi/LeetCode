using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word_58
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            
            int len = 0;
            for(int i = s.Length -1; i >= 0; i--)
            {
                if(s[i] != ' ')
                {
                    len++;
                }
                if(s[i] == ' ' && len != 0)
                {
                    break;
                }
                
            }
            return len;
        }
    }
}

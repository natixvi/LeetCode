using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Compress_443
{
    public class Solution
    {
        public int Compress(char[] chars)
        {
            /*string s = string.Empty;
            int i = 1;
            foreach (char c in chars) {
                if (s.Contains(c))
                {
                    i++;
                }
                else {
                    if (i != 1) {
                        s += i;
                        i = 1;
                    }
                    s += c;
                }

            }
            if (i != 1)
            {
                s += i;
            }
            
            return chars.Length;*/
            int i = 0;
            int ptr = 0;

            while (i < chars.Length)
            {
                int count = 1;
                char ch = chars[i];
                i++;

                while (i < chars.Length && chars[i] == ch)
                {
                    count++;
                    i++;
                }

                chars[ptr++] = ch;

                if (count > 1)
                {
                    foreach (var item in count.ToString().ToCharArray())
                    {
                        chars[ptr++] = item;
                    }
                }
            }

            return ptr;

        }
    }
}

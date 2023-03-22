using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Digits_That_Divide_a_Number_2520
{
    public class Solution{
        public int CountDigits(int num){
            /* int total = 0;
             foreach (char c in num.ToString()) {
                 if (num % (c - '0') == 0) {
                     total++;

                 }
             }
             return total;*/

            return num.ToString().Count(x => num % Convert.ToInt32(x.ToString()) == 0); //toString() drugi raz poniewaz jeśli zamienimy char metoda ToInt32 (bez zamiany na string) to wynik bedzie w kodzie ascii!
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defeanging_an_IP_Address_1108
{
    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
           
        }
    }
}

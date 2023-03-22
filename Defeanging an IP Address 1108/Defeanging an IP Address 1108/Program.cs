using System.Net;

namespace Defeanging_an_IP_Address_1108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "1.1.1.1";
            Solution solution = new Solution();
            string res = solution.DefangIPaddr(address);
            Console.WriteLine(res);
        }
    }
}
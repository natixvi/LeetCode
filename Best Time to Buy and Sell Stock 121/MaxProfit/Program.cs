using System.Diagnostics;

namespace MaxProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 1,2};
            Solution solution = new Solution();
            
            Console.WriteLine(solution.MaxProfit(prices));

        }
    }
}
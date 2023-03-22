namespace Jewels_and_Stones_771
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string jewels = "z", stones = "ZZ";
          Solution solution = new Solution();
            int total = solution.NumJewelsInStones(jewels, stones);
            Console.WriteLine(total);

        }
    }
}
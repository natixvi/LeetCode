namespace Shuffle_the_Array_1470
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int n = 4;
            Solution solution = new Solution();
            int[] res = solution.Shuffle(nums, n);
            foreach (int r in res) { 
                Console.Write(r + " ");
            }
        }
    }
}
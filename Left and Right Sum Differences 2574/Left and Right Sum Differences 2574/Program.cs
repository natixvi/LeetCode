namespace Left_and_Right_Sum_Differences_2574
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 10, 4, 8, 3 };
            int[] res = solution.LeftRigthDifference(nums);
            foreach (int r in res) { 
                Console.Write(r + "  ");
            }
        }
    }
}
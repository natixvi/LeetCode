namespace _1920._Build_Array_from_Permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] nums = { 5, 0, 1, 2, 3, 4 };
            Solution solution = new Solution();

            int[] res = solution.BuildArray(nums);
            for (int i = 0; i < res.Length; i++) {
                Console.Write(res[i] + " ");
            }*/
            int[] nums = { 1, 3, 2, 1 };
            Solution solution = new Solution();

            int[] res = solution.BuildArray(nums);
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
    }
}
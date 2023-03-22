namespace _2011._Final_Value_of_Variable_After_Performing_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int res = solution.FinalValueAfterOperations(new string[] { "X++", "++X", "--X", "X--" });
            Console.WriteLine(res);
        }
    }
}
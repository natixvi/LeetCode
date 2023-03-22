namespace Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string haystack = "leetcode", needle = "leeto";
            Solution solution = new Solution();
            int res = solution.StrStr(haystack, needle);
            Console.WriteLine(res);
        }
    }
}
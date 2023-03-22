namespace String_Compress_443
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = {'a', 'a', 'b', 'b', 'c', 'c', 'c'};
            Solution solution = new Solution();
            int res = solution.Compress(chars);
            foreach (char c in chars)
            {
                Console.Write(c + "  ");
            }
            Console.WriteLine(res);
        }
    }
}
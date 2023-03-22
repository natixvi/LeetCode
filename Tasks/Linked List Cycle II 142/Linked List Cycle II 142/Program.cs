using System.Net.Http.Headers;

namespace Linked_List_Cycle_II_142
{
    internal class Program
    {
        static void Main(string[] args)

        {   
            ListNode ln4 = new ListNode(-4);
            ListNode ln3 = new ListNode(0);
            ListNode ln2 = new ListNode(2);
            ListNode ln1 = new ListNode(3);

            ln1.next = ln2;
            ln2.next = ln3;
            ln3.next = ln4;
            ln4.next = ln2;
            

            Solution solution = new Solution();
            ListNode res = solution.DetectCycle(ln1);
            Console.WriteLine(res.val);

        }
    }
}
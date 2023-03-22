using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Cycle_II_142
{
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            /* ListNode slow = head;
             ListNode fast = head;

             while(fast.next != null)   
             {

                 if (slow == fast) {
                     return slow;
                 }
                 slow = slow.next;
                 fast = fast.next.next;

             }
             return null;*/
            HashSet<ListNode> hs = new HashSet<ListNode>();

            ListNode node = head;

            while (node != null)
            {
                if (!hs.Add(node)) return node;

                node = node.next;
            }

            return null;


        }
    }
}

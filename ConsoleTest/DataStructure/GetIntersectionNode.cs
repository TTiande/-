using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{//160.相交链表
    class GetIntersectionNode
    {
        public ListNode getIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode tempA = headA;
            ListNode tempB = headB;
            Dictionary<ListNode, int> res = new Dictionary<ListNode, int>();
            while (tempA != null)
            {
                if (!res.ContainsKey(tempA))
                {
                    res.Add(tempA, tempA.val);
                }
                tempA = tempA.next;
            }
            while (tempB != null)
            {
                if (res.ContainsKey(tempB))
                {
                    return tempB;
                }
                tempB = tempB.next;
            }
            return null;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}

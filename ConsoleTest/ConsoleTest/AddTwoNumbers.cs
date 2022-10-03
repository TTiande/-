using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class AddTwoNumbers
    {//两数相加
        /// <summary>
        ///// int[] a = new int[3] { 2, 4, 3 };
        //    int[] b = new int[3] { 5, 6, 4 };
        //    ListNode Head1 = null, tail1 = null,Head2 = null, tail2 = null;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (Head1 == null) Head1 = tail1 = new ListNode(a[i]);
        //        else { tail1.next = new ListNode(a[i]); tail1 = tail1.next; }
        //        if (Head2 == null) Head2 = tail2 = new ListNode(b[i]);
        //        else { tail2.next = new ListNode(b[i]); tail2 = tail2.next; }
        //    }
        //    ListNode result=AddTwoNumbers(Head1, Head2);
        //    while (result != null) {
        //        Console.WriteLine(result.val);
        //        result=result.next;
        //    }
        /// </summary>

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            //设定头指针、尾指针
            ListNode head = null, tail = null;
            ListNode pointer = null;
            while (l1 != null || l2 != null)
            {
                int temp = carry;
                if (l1 != null)
                {
                    temp += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    temp += l2.val;
                    l2 = l2.next;
                }
                carry = temp / 10;
                if (head == null) tail = head = new ListNode(temp % 10);
                else
                {
                    tail.next = new ListNode(temp % 10);
                    tail = tail.next;
                }
            }
            if (carry > 0) tail.next = new ListNode(carry);
            return head;
        }
    }
}

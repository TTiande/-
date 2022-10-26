using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class DeleteDuplicates
    {//删除排序链表中的重复元素。
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
        public ListNode deleteDuplicates(ListNode head)
        {
            ListNode pointer = new ListNode();
            pointer = head;//head是首元节点
            List<int> num = new List<int>();
            try
            {
                if (pointer == null || pointer.next == null) return head;
                num.Add(pointer.val);
                while (pointer.next != null && pointer != null)
                {
                    if (num.Contains(pointer.next.val))
                    {
                        bool ctr = true;
                        ListNode temp = pointer.next;
                        while (ctr)
                        {
                            if (!num.Contains(temp.val))
                            {
                                pointer.next = temp;
                                pointer = pointer.next;
                                num.Add(pointer.val);
                                ctr = false;
                            }
                            else
                            {
                                if (temp.next != null)
                                    temp = temp.next;
                                else
                                {
                                    ctr = false;
                                    pointer.next = null;
                                }

                            }
                        }
                        // if(pointer.next.next!=null){

                        //     pointer.next=pointer.next.next;
                        //     pointer=pointer.next;
                        //     num.Add(pointer.val);
                        // }
                        // else{
                        //     pointer.next=null;
                        //     break; 
                        // }              
                    }
                    else
                    {
                        pointer = pointer.next;
                        num.Add(pointer.val);
                    }
                }
            }
            catch (Exception ee)
            {
                throw ee;
            }
            return head;
        }
        
    }
}

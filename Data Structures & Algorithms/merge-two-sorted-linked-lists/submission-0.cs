/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        
        ListNode head;

        if (list1.val <= list2.val) 
        {
            head = new ListNode(list1.val);
            list1 = list1.next;
        }
        else
        {
            head = new ListNode(list2.val);
            list2 = list2.next;
        }

        var tail = head;

        while (list1 != null && list2 != null) 
        {
            if (list1.val <= list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            } 
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }

        if (list1 != null) 
        {
            tail.next = list1;
        }
        else if (list2 != null) 
        {
            tail.next = list2;
        }

        return head;
    }
}
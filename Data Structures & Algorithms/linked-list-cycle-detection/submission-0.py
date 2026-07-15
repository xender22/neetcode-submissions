# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        tmp = head

        while tmp is not None and head is not None and tmp.next is not None:
            head = head.next
            tmp = tmp.next.next

            if head is tmp:
                return True;
            
        return False;
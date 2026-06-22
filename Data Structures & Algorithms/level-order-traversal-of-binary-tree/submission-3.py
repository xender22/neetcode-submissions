# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        result = []
        q = deque()

        if root:
            q.append(root)
        
        while len(q) > 0:
            curr_lvl = []
            q_len = len(q)

            for i in range(q_len):
                curr = q.popleft()
                curr_lvl.append(curr.val)

                if curr.left:
                    q.append(curr.left)
                if curr.right:
                    q.append(curr.right)

            result.append(curr_lvl)
        return result




        
        
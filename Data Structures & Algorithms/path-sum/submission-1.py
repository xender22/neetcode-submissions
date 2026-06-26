# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def hasPathSum(self, root: Optional[TreeNode], targetSum: int) -> bool:

        curr_sum = 0

        def backtrack(root: Optional[TreeNode], curr_sum: int, targetSum: int):

            if not root:
                return False            
            curr_sum += root.val
            
            if not root.left and not root.right and curr_sum == targetSum:
                return True
            if backtrack(root.left, curr_sum, targetSum):
                return True
            if backtrack(root.right, curr_sum, targetSum):
                return True

            curr_sum -= root.val
            return False
        
        result = backtrack(root, curr_sum, targetSum)
        return result

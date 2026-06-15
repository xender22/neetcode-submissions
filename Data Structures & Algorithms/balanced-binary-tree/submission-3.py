# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:

    def treeSize(self, root: Optional[TreeNode]) -> int:
        if root == None: 
            return 0

        return 1 + max(self.treeSize(root.left), self.treeSize(root.right))




    def isBalanced(self, root: Optional[TreeNode]) -> bool:
        
        if root == None:
            return True

        l = self.treeSize(root.left)
        r = self.treeSize(root.right)

        if abs(l - r) > 1:
            return False

        return self.isBalanced(root.left) and self.isBalanced(root.right)
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {

    public List<int> InorderTraversal(TreeNode root) 
    {
        List<int> result = new List<int>();

        void Dfs(TreeNode root) 
        {
            if (root == null)
                return;
            Dfs(root.left);
            result.Add(root.val);
            Dfs(root.right);
        }

        Dfs(root);

        return result;
    }
}
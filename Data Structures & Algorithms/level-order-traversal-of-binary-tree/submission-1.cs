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
    public List<List<int>> LevelOrder(TreeNode root) 
    {
        var q = new Queue<TreeNode>();
        var result = new List<List<int>>();

        if (root != null)
            q.Enqueue(root);
        
        while (q.Count > 0) 
        {
            var currStack = new List<int>();
            var qCount  = q.Count;
            for (var i = 0; i < qCount; i++)
            {
                var curr = q.Dequeue();

                currStack.Add(curr.val);

                if (curr.left != null)
                    q.Enqueue(curr.left);
                if (curr.right != null)
                    q.Enqueue(curr.right);
                
                
            }
            result.Add(currStack);
        }

        return result;
    }
}

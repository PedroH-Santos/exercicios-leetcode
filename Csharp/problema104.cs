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
public class Solution104
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) { return 0; }
        int countLeft = 0;
        if (root.left != null)
        {
            countLeft = MaxDepth(root.left);
        }
        int countRight = 0;
        if (root.right != null)
        {
            countRight = MaxDepth(root.right);
        }
        return 1 + Math.Max(countLeft, countRight);
    }
}
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
 
public class Solution100
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {

        bool sameLeft = false;
        bool sameRight = false;
        if (p == null && q == null) { return true; }
        if (p == null) { return false; }
        if (q == null) { return false; }

        if (p.left == null && q.left == null)
        {
            sameLeft = true;
        }
        if (p.right == null && q.right == null)
        {
            sameRight = true;
        }
        if (q.left != null && p.left != null)
        {
            sameLeft = IsSameTree(p.left, q.left);
        }
        if (q.right != null && p.right != null)
        {
            sameRight = IsSameTree(p.right, q.right);
        }
        if (p.val == q.val && sameLeft && sameRight)
        {
            return true;
        }


        return false;

    }
}
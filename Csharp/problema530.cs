


public class Solution530
{
    public int KthSmallest(TreeNode root, int k)
    {
        int solution = 0;
        int count = 0;
        void getSolution(TreeNode root)
        {
            if (root.left != null)
            {
                getSolution(root.left);
            }
            count++;
            if (count == k)
            {
                solution = root.val;
            }
            if (root.right != null)
            {
                getSolution(root.right);
            }
        }
        getSolution(root);
        return solution;
    }



}

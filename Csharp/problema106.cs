
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {

        if (postorder is null || !postorder.Any() ||
           inorder is null || !inorder.Any()) return null;



        TreeNode root = new TreeNode(postorder[postorder.Length - 1]);
        int indexRoot = Array.IndexOf(inorder, postorder[postorder.Length -1]);
        root.left = BuildTree(inorder[0..indexRoot], postorder[0..indexRoot]);
        root.right = BuildTree(inorder[(indexRoot + 1)..], postorder[indexRoot..^1]);

        return root;
    }


}

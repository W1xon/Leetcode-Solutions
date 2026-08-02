using LeetCode.Common;

namespace LeetCode._200_299;
public class _226InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root is null)
            return root;

        (root.left, root.right) = (root.right, root.left);

        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}
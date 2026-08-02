using LeetCode.Common;

namespace LeetCode._100_199;

public class _104MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null)
            return 0;
        int maxLeft = MaxDepth(root.left);
        int maxRight = MaxDepth(root.right);
        return maxLeft > maxRight ? maxLeft + 1 : maxRight + 1;
    }
}
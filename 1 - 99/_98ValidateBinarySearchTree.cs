using LeetCode.Common;

namespace LeetCode._1___99;

public class _98ValidateBinarySearchTree
{
    public bool IsValidBST(TreeNode? node)
    {
        return IsValidBST(node, null, null);
    }

    private bool IsValidBST(TreeNode? node, long? min, long? max)
    {
      
        if (node is null)
            return true;

        if((min is not null && node.val <= min)
           || (max is not null && node.val >= max))
            return false;  
        
        return IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
    }
}
using LeetCode.Common;

namespace LeetCode._100_199;
public class _102BinaryTreeLevelOrderTraversal
{
    public IList<IList<int>> LevelOrder(TreeNode? root)
    {
        List<IList<int>> result = new List<IList<int>>();
        if (root is null) return result;

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            List<int> level = new List<int>();
            for (int i = 0; i < levelSize; i++)
            {
                var currentNode = queue.Dequeue();
                level.Add(currentNode.val);
                if(currentNode.left is not null)
                    queue.Enqueue(currentNode.left);
                if(currentNode.right is not null)
                    queue.Enqueue(currentNode.right);
            }
            result.Add(level);
        }

        return result;
    }
}
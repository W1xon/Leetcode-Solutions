namespace LeetCode.Graphs.Trees;

public class TreeNode(int value, TreeNode? leftNode = null, TreeNode? rightNode = null)
{
    public int Value = value;
    public TreeNode? LeftNode = leftNode;
    public TreeNode? RightNode = rightNode;
    public int Count = 1;
}


public class BinaryTree
{
    public TreeNode? Root;
    
    public void InsertNode(int value)
    {
        if (Root is null)
        {
            TreeNode node = new TreeNode(value);
            Root = node;
            return;
        }

        TreeNode current = Root;
        while (true)
        {
            
            if (value < current.Value)
            {
                if (current.LeftNode is null)
                {
                    current.LeftNode = new TreeNode(value);
                    break;
                }
                current = current.LeftNode;
            }
            else if(value > current.Value)
            {
                if (current.RightNode is null)
                {
                    current.RightNode = new TreeNode(value);
                    break;
                }
                current = current.RightNode;
            }

            else
            {
                // Значения равны зависит от ситуации мы будем прибавлять 
                current.Count++;
                break;
            }
        }
    }

    public void Inorder() =>Inorder(Root);
    public void Preorder() => Preorder(Root);
    public void Postorder() => Postorder(Root);
    public void Search(int value) => Search(Root, value);

    // Реализация с List
    public void BreadthList()
    {
        if (Root is null) return;
        List<TreeNode> nodes = new List<TreeNode>();
        nodes.Add(Root);
        int position = 0;

        while (position < nodes.Count)
        {
            var currentNode = nodes[position];
            Console.Write(currentNode.Value + " ");
            if(currentNode.LeftNode is not null)
                nodes.Add(currentNode.LeftNode);
            if(currentNode.RightNode is not null)
                nodes.Add(currentNode.RightNode);
            position++;
        }
    }
    
    //Реализация с помощью Queue
    public void BreadthQueue()
    {
        if (Root is null) return;
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(Root);
        while (nodes.Count > 0)
        {
            var currentNode = nodes.Dequeue();
            Console.Write(currentNode.Value + " ");
            if(currentNode.LeftNode is not null)
                nodes.Enqueue(currentNode.LeftNode);
            if(currentNode.RightNode is not null)
                nodes.Enqueue(currentNode.RightNode);
        }
    }

    private void Inorder(TreeNode? node)
    {
        if (node is null)
            return;
        
        Inorder(node.LeftNode);
        Console.Write(node.Value + " ");
        Inorder(node.RightNode);
    }
    private void Preorder(TreeNode? node)
    {
        if (node is null) return;

        Console.Write(node.Value + " ");
        Preorder(node.LeftNode);  
        Preorder(node.RightNode); 
    }

    private void Postorder(TreeNode? node)
    {
        if (node is null) return;

        Postorder(node.LeftNode);  
        Postorder(node.RightNode); 
        Console.Write(node.Value + " ");
    }

    private bool Search(TreeNode? node, int value)
    {
        if (node is null) return false;
        if (node.Value == value) return true;

        if (node.Value > value)
            return Search(node.LeftNode, value);
        else
            return Search(node.RightNode, value);
    }
}

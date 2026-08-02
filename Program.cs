using LeetCode.Graphs.Trees;

namespace LeetCode;

public class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();
        
        tree.InsertNode(4);
        tree.InsertNode(1);
        tree.InsertNode(6);
        tree.InsertNode(-2);
        tree.InsertNode(2);
        tree.InsertNode(7);

        tree.Inorder();
        Console.WriteLine();
        tree.Preorder();
        Console.WriteLine();
        tree.Postorder();
        Console.WriteLine();
        tree.BreadthList();
    }
}

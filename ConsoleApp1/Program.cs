// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

using DSPractice.gfg.Tree;
using DSPractice.gfg.Tree.Problems;
using DSPractice.gfg.Tree.Videos;

internal class Program
{

    private static void Main(string[] args)
    {

        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);
        root.right.left = new Node(6);
        root.right.right = new Node(7);
        root.right.left.right = new Node(8);
        root.right.right.right = new Node(9);

        VerticalWidthOfTree verticalWidthOfTree = new VerticalWidthOfTree();
        Console.WriteLine(verticalWidthOfTree.verticalWidth(root));

        Console.ReadLine();
    }
}
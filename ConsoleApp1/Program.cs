// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using ConsoleApp1.gfg;
using ConsoleApp1.gfg.Array;
using ConsoleApp1.gfg.Array.Matrix;
using ConsoleApp1.gfg.Re_practice;
using ConsoleApp1.gfg.Sorting;

using DSPractice.gfg.Hashing;
using DSPractice.gfg.LinkedList;
using DSPractice.gfg.LinkedList.Problems;
using DSPractice.gfg.LinkedList.Videos;
using DSPractice.gfg.Stack.Video;
using DSPractice.gfg.stringsProblems.Problems;
using DSPractice.gfg.stringsProblems.videos;
using DSPractice.gfg.Tree;
using DSPractice.gfg.Tree.Videos;

internal class Program
{

    private static void Main(string[] args)
    {
        ConvertTreeIntoDoublyLinkedList convertTreeIntoDoublyLinkedList = new ConvertTreeIntoDoublyLinkedList();
        DSPractice.gfg.Tree.Node node = new DSPractice.gfg.Tree.Node(10);
        node.left = new DSPractice.gfg.Tree.Node(5);
        node.right = new DSPractice.gfg.Tree.Node(20);
        node.right.left = new DSPractice.gfg.Tree.Node(30);
        node.right.right = new DSPractice.gfg.Tree.Node(35);

        DoublyNode doublyNode = convertTreeIntoDoublyLinkedList.ConvertToDoubly(node);

        Console.ReadLine();
    }
}
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
using DSPractice.gfg.stringsProblems.Problems;
using DSPractice.gfg.stringsProblems.videos;
using DSPractice.LeetCode_Practice.Array;
using DSPractice.Oops;

internal class Program
{

    private static void Main(string[] args)
    {
        Node head = null;
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 1);
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 2);
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 3);
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 7);
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 16);
        Node head2 = null;
        head2 = SimpleLinkedListImplementation.InsertAtEnd(head2, 2);
        head2 = SimpleLinkedListImplementation.InsertAtEnd(head2, 5);
        head2 = SimpleLinkedListImplementation.InsertAtEnd(head2, 6);

        MergeTwoSortedLinkedList reverseLinkedList = new MergeTwoSortedLinkedList();

        reverseLinkedList.Merge(head, head2);

        Console.ReadLine();
    }
}
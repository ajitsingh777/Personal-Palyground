// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using ConsoleApp1.gfg;
using ConsoleApp1.gfg.Array;
using ConsoleApp1.gfg.Array.Matrix;
using ConsoleApp1.gfg.Re_practice;
using ConsoleApp1.gfg.Sorting;

using DSPractice.gfg.Hashing;
using DSPractice.gfg.LinkedList;
using DSPractice.gfg.LinkedList.Videos;
using DSPractice.gfg.stringsProblems.Problems;
using DSPractice.gfg.stringsProblems.videos;
using DSPractice.LeetCode_Practice.Array;
using DSPractice.Oops;

internal class Program
{

    private static void Main(string[] args)
    {
        Node head = null; ;
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 10);
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 20);
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 30);
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 40);
        head = SimpleLinkedListImplementation.InsertAtEnd(head, 50);
        SimpleLinkedListImplementation.TraverseLinkedList(head);
        Console.ReadLine();
    }
}
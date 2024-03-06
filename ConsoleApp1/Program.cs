// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using DSPractice.Dynamic_Programming;
using DSPractice.gfg.Tree;
using DSPractice.gfg.Tree.Problems;
using DSPractice.gfg.Tree.Videos;
using DSPractice.LCS;
using DSPractice.Sliding_window;

internal class Program
{

    private static void Main(string[] args)
    {
        SlidingWindowProblems slidingWindowProblems = new SlidingWindowProblems();
        var a = slidingWindowProblems.subarraySum(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 15);
        Console.ReadLine();
    }
}
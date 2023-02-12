// See https://aka.ms/new-console-template for more information
using AsyncAwaitProgramming;
using System.Diagnostics;
using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        //Console.BackgroundColor = ConsoleColor.Magenta;
        //Console.ForegroundColor = ConsoleColor.Green;
        //Stopwatch sw = Stopwatch.StartNew();
        //Task<string> eggTask = Task.Run(() => FryEggAsync());
        //Task<string> baconTask = Task.Run(() => FryBaconAsync());
        //Task<string> toastTask = Task.Run(() => PrepareToastAsync());
        //Task<string> eggTask = FryEggAsync();
        //Task<string> baconTask = FryBaconAsync();
        //Task<string> toastTask = PrepareToastAsync();
        //string egg = await eggTask.ConfigureAwait(false);
        //Console.WriteLine(egg);
        //string bacon = await baconTask.ConfigureAwait(false);
        //Console.WriteLine(bacon);
        //string toast = await toastTask.ConfigureAwait(false);
        //Console.WriteLine(toast);
        //Console.WriteLine("breakfast is ready");
        //sw.Stop();
        //Console.WriteLine(sw.Elapsed);

        PatternMachingPractice.PrintLength(x => x.Length);




    }

    internal static async Task<string> FryEggAsync()
    {
        Thread.Sleep(1000);
        return "egg fried";
    }
    internal static async Task<string> FryBaconAsync()
    {
        Thread.Sleep(3000);
        return "bacon fried";
    }
    internal static async Task<string> PrepareToastAsync()
    {
        Thread.Sleep(5000);
        return "Toast prepared";
    }
}
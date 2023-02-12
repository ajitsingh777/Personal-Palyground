
namespace AsyncAwaitProgramming
{
    internal class PatternMachingPractice
    {

        public int MyProperty
        {
            get => 5;
            init => _ = value;
        }
        public void PatternMatchExample1()
        {
            string str = "my name is Ajit";
            if (str is not null)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"string is {str}");


            }
        }

        public static void PrintLength(Func<string, int> lenghtCount)
        {
            int count = lenghtCount("ajit");
            Console.WriteLine(count);
        }

    }
}

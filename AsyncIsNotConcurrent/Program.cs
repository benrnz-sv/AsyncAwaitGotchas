using System;

namespace AsyncIsNotConcurrent
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Async is not concurrent.");

            //new Example5InvokeThenWait().MainMethod();
            //new Solution5InvokeThenWait().MainMethod().Wait();

            //new Example6CallingAsyncMethodsWithoutAwaiting().MainMethod().Wait();

            // new Example7AdvancedScenario().MainMethod();
            new Solution7AdvancedScenario().MainMethod().Wait();

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine(); // Unhandled exceptions above may mean ReadLine is unavailable.
        }
    }
}
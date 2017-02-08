using System;

namespace AsyncIsNotConcurrent
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //new Example5InvokeThenWait().MainMethod();
            //new Solution5InvokeThenWait().MainMethod().Wait();

            new Example6CallingAsyncMethodsWithoutAwaiting().MainMethod().Wait();

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine(); // Unhandled exceptions above may mean ReadLine is unavailable.
        }
    }
}
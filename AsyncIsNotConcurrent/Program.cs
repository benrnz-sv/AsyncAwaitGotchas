using System;

namespace AsyncIsNotConcurrent
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            new Example5().MainMethod();
            // new Example2CatchingExceptions().MainMethod();
            // new SolutionCatchingExceptions().MainMethod().Wait();

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine(); // Unhandled exceptions above may mean ReadLine is unavailable.
        }
    }
}
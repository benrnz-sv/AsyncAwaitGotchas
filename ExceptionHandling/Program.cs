using System;
using System.Diagnostics;

namespace ExceptionHandling
{
    public static class Program
    {
        public static void Main(string[] args)
        {
                // new Example1CatchingExceptions().MainMethod();
                // new Example2CatchingExceptions().MainMethod();
                // new SolutionCatchingExceptions().MainMethod().Wait();

                // new Example3LoggingExceptions().MainMethod().Wait();
                // new Example4LoggingExceptions().MainMethod().Wait();
                new SolutionLoggingExceptions().MainMethod().Wait();

                Console.WriteLine("Press enter to exit.");
                Console.ReadLine(); // Unhandled exceptions above may mean ReadLine is unavailable.
        }
    }
}
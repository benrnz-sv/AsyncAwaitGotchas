using System;
using System.Diagnostics;

namespace ExceptionHandling
{
    public static class Program
    {
        public static void Main(string[] args)
        {
                // new Example1CatchingExceptions().CallThrowExceptionAsync();
                // new Example2CatchingExceptions().CallThrowExceptionAsync();
                // new SolutionCatchingExceptions().CallThrowExceptionAsync().Wait();

                // new Example3LoggingExceptions().CallThrowExceptionAsync().Wait();
                // new Example4LoggingExceptions().CallThrowExceptionAsync().Wait();
                new SolutionLoggingExceptions().CallThrowExceptionAsync().Wait();

                Console.WriteLine("Press enter to exit.");
                Console.ReadLine(); // Unhandled exceptions above may mean ReadLine is unavailable.
        }
    }
}
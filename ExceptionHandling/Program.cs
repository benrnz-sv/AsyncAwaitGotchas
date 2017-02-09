using System;

namespace ExceptionHandling
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exception Handling.");

            // new Example1CatchingExceptions().MainMethod();
            // new Example2CatchingExceptions().MainMethod();
            // new Solution12CatchingExceptions().MainMethod().Wait();

            // new Example3LoggingExceptions().MainMethod().Wait();
            // new Example4LoggingExceptions().MainMethod().Wait();
            new Solution34LoggingExceptions().MainMethod().Wait();

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine(); // Unhandled exceptions above may mean ReadLine is unavailable.
        }
    }
}
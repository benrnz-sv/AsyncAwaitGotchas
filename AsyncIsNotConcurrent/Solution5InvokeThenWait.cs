using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncIsNotConcurrent
{
    public class Solution5InvokeThenWait
    {
        public async Task MainMethod()
        {
            Console.WriteLine("Started.");
            await WorkThenWait();
            Console.WriteLine("Completed.");
        }

        private async Task WorkThenWait()
        {
            Thread.Sleep(1000); // Busy doing lots of synchronous work...
            Console.WriteLine("doing work...");
            await Task.Delay(1000); // Busy doing some asynchronous work...
        }
    }
}
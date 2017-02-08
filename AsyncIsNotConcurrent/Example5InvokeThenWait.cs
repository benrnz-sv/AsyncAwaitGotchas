using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncIsNotConcurrent
{
    public class Example5InvokeThenWait
    {
        public void MainMethod()
        {
            var child = WorkThenWait();
            Console.WriteLine("Started.");
            child.Wait();
            Console.WriteLine("Completed.");
        }

        private async Task WorkThenWait()
        {
            Thread.Sleep(1000);
            Console.WriteLine("doing work...");
            await Task.Delay(1000);
        }
    }
}
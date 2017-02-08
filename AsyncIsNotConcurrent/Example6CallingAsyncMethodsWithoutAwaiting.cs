using System;
using System.Threading.Tasks;

namespace AsyncIsNotConcurrent
{
    public class Example6CallingAsyncMethodsWithoutAwaiting
    {
        public async Task MainMethod()
        {
            Console.WriteLine($"Before {DateTime.Now}");
            Task.Delay(5000);
            Console.WriteLine($"After {DateTime.Now}");
        }
    }
}
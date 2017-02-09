using System;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncIsNotConcurrent
{
    public class Example7AdvancedScenario
    {
        public void MainMethod()
        {
            Console.WriteLine($"Started {DateTime.Now}");
            Parallel.For(0, 10, async i =>
            {
                await Task.Delay(1000);
            });

            Console.WriteLine($"Finished {DateTime.Now}");
        }

        private async Task DoWork(int i)
        {
            await Task.Delay(1000);
        }
    }
}
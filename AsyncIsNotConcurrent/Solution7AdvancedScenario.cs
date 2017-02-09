using System;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncIsNotConcurrent
{
    public class Solution7AdvancedScenario
    {
        public async Task MainMethod()
        {
            Console.WriteLine($"Started {DateTime.Now}");

            var tasks = Enumerable.Range(0, 10)
                .Select(async index => await DoWork(index))
                .AsParallel();

            await Task.WhenAll(tasks);

            Console.WriteLine($"Finished {DateTime.Now}");
        }

        private async Task DoWork(int i)
        {
            await Task.Delay(1000);
        }
    }
}
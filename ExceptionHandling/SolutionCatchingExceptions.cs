using System;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class SolutionCatchingExceptions
    {
        public async Task MainMethod()
        {
            try
            {
                await DoWork();
            }
            catch (Exception)
            {
                Console.WriteLine("Failed.");
            }
        }

        private async Task DoWork()
        {
            throw new NotSupportedException();
        }
    }
}
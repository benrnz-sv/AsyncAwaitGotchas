using System;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class SolutionCatchingExceptions
    {
        public async Task CallThrowExceptionAsync()
        {
            try
            {
                await ThrowExceptionAsync();
            }
            catch (Exception)
            {
                Console.WriteLine("Failed.");
            }
        }

        private async Task ThrowExceptionAsync()
        {
            throw new NotSupportedException();
        }
    }
}
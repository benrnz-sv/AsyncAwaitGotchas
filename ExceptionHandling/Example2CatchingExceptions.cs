using System;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Example2CatchingExceptions
    {
        public void MainMethod()
        {
            try
            {
                DoWork();
            }
            catch (Exception)
            {
                // Handle Exception
                Console.WriteLine("Failed.");
            }
        }

        private async Task DoWork()
        {
            throw new NotSupportedException();
        }
    }
}
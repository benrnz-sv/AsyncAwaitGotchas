using System;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Example2CatchingExceptions
    {
        public void CallThrowExceptionAsync()
        {
            try
            {
                ThrowExceptionAsync();
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
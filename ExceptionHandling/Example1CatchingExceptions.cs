using System;

namespace ExceptionHandling
{
    public class Example1CatchingExceptions
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

        private async void ThrowExceptionAsync()
        {
            throw new NotSupportedException();
        }
    }
}
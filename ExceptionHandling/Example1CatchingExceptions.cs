using System;

namespace ExceptionHandling
{
    public class Example1CatchingExceptions
    {
        public void MainMethod()
        {
            try
            {
                DoWork();
            }
            catch (Exception)
            {
                Console.WriteLine("Failed.");
            }
        }

        private async void DoWork()
        {
            throw new NotSupportedException();
        }
    }
}
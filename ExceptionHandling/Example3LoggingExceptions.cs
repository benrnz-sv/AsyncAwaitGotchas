using System;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Example3LoggingExceptions
    {
        public async Task MainMethod()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            try
            {
                DoWork();
            }
            catch (InvalidOperationException ex)
            {
                // Handle exception
                Console.WriteLine("Special handling for this exception type");
                Console.WriteLine(ex);
            }
        }

        private async void DoWork()
        {
            throw new InvalidOperationException("Critical information here");
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            Console.WriteLine("Unhandled Exception Handler");

            Console.WriteLine(unhandledExceptionEventArgs.ExceptionObject);
            // Always log the exception object itself, not just the Exception Message.
        }
    }
}
using System;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Example4LoggingExceptions
    {
        public async Task CallThrowExceptionAsync()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            await ThrowExceptionAsync();
        }

        private async Task ThrowExceptionAsync()
        {
            throw new InvalidOperationException("Critical information here");
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            Console.WriteLine("Unhandled Exception Handler");

            if (unhandledExceptionEventArgs.ExceptionObject is InvalidOperationException)
            {
                Console.WriteLine("Special handling for this exception type");
                return;
            }

            Console.WriteLine(unhandledExceptionEventArgs.ExceptionObject);
            // Always log the exception object itself, not just the Exception Message.
        }
    }
}
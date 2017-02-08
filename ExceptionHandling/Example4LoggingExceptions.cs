using System;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Example4LoggingExceptions
    {
        public async Task MainMethod()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            await DoWork();
        }

        private async Task DoWork()
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
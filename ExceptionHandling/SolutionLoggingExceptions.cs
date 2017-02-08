using System;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class SolutionLoggingExceptions
    {
        public async Task CallThrowExceptionAsync()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            try
            {
                // Best way
                await ThrowExceptionAsync();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Special handling for this exception type");
            }
        }

        private async Task ThrowExceptionAsync()
        {
            throw new InvalidOperationException("Critical information here");
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            Console.WriteLine("Unhandled Exception Handler");

            // Or you can inspect the actual exception(s) type here
            var exception = unhandledExceptionEventArgs.ExceptionObject as AggregateException;
            if (exception != null && exception.InnerExceptions.OfType<InvalidOperationException>().Any())
            {
                Console.WriteLine("Special handling for this exception type");
                return;
            }

            Console.WriteLine(unhandledExceptionEventArgs.ExceptionObject);
            // Always log the exception object itself, not just the Exception Message.
        }
    }
}
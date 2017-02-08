using System;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Solution34LoggingExceptions
    {
        public async Task MainMethod()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            try
            {
                // Best way
                await DoWork();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Special handling for this exception type");
            }
        }

        private async Task DoWork()
        {
            throw new InvalidOperationException("Critical information here");
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            Console.WriteLine("Unhandled Exception Handler");

            // Or you can inspect the actual exception(s) type here
            var invalidOperationException = unhandledExceptionEventArgs.ExceptionObject;
            var aggregateException = unhandledExceptionEventArgs.ExceptionObject as AggregateException;

            // Check for both possible exception types.
            if (invalidOperationException != null 
                || aggregateException != null && aggregateException.InnerExceptions.OfType<InvalidOperationException>().Any())
            {
                Console.WriteLine("Special handling for this exception type");
                return;
            }

            Console.WriteLine(unhandledExceptionEventArgs.ExceptionObject);
            // Always log the exception object itself, not just the Exception Message.
        }
    }
}
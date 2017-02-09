using System;
using System.Threading.Tasks;

namespace Startup
{
    public static class Program
    {
        private static readonly string Data1 =
            "While Async/Await does simplify and make your code better, developers must be aware of some crucial best practices.";

        private static readonly string Data2 =
            "It can sometimes have seemingly unpredictable results.";

        private static Random Random = new Random(DateTime.Now.Second);

        private const int MaxPause = 4000;

        public static void Main(string[] args)
        {
            StartupDemo().Wait();
            Console.WriteLine();
        }

        private static async Task StartupDemo()
        {
            var sentence1 = Data1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var sentence2 = Data2.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var abort = true;

            do
            {
                Console.Clear();
                abort = await OutputSentence(sentence1);
                if (abort) break;
                Console.WriteLine();
                Console.WriteLine();
                abort = await OutputSentence(sentence2, MaxPause);
            } while (!abort);
        }

        private static async Task<bool> OutputSentence(string[] sentence2, int maxPause = 0)
        {
            await Task.Delay(MaxPause);
            foreach (var word in sentence2)
            {
                Console.Write($"{word} ");
                await Task.Delay(maxPause == 0 ? 2000 : Random.Next(maxPause));
                if (Console.KeyAvailable)
                {
                    return true;
                }
            }

            await Task.Delay(MaxPause);
            return false;
        }
    }
}
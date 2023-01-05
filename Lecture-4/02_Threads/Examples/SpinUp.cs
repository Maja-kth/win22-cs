using SharedResources.Helpers;

namespace _02_Threads.Examples;

internal static class SpinUp
{
    public static void Run()
    {
        for (uint i = 0; i < uint.MaxValue; i++)
        {
            uint counter = i;
            new Thread(() =>
            {
                var worker = new Worker();
                worker.BackgroundWork(null, Thread.CurrentThread, null);
                Thread.Sleep(10000);
            }).Start();
        }

        //for (uint i = 0; i < uint.MaxValue; i++)
        //{
        //    new Thread(() =>
        //    {
        //        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        //        Thread.Sleep(10000);
        //    }).Start();
        //}
    }
}

using SharedResources.Helpers;

namespace _02_Tasks.Examples;

internal static class SpinUp
{
    public static void Run()
    {
        //for (uint i = 0; i < uint.MaxValue; i++)
        //{
        //    uint counter = i;
        //    Task.Run(() =>
        //    {
        //        var worker = new Worker();
        //        worker.BackgroundWork(null, Thread.CurrentThread, Task.CurrentId);
        //        Task.Delay(10000);
        //    });
        //}

        for (uint i = 0; i < uint.MaxValue; i++)
        {
            Task.Run(() =>
            {
                Console.WriteLine($"Task ID: {Task.CurrentId} on Thread ID: {Thread.CurrentThread.ManagedThreadId}");
                Task.Delay(10000);
            });
        }
    }
}

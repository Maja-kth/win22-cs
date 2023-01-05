using SharedResources.Helpers;

namespace _02_Threads.Examples;

internal static class ParallellWork
{
    public static void Run()
    {
        for (int i = 1; i < 10; i++)
        {
            int counter = i;
            new Thread(() =>
            {
                var worker = new Worker();
                worker.BackgroundWork(counter, Thread.CurrentThread, null);
            }).Start();
        }

        for (int i = 1; i < 10; i++)
        {
            var worker = new Worker();
            worker.ForegroundWork(i, Thread.CurrentThread);
        }
    }
}

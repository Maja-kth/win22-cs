using SharedResources.Helpers;

namespace _02_Tasks.Examples;

internal static class ParallellWork
{
    public static void Run()
    {
        for (int i = 1; i < 10; i++)
        {
            int counter = i;
            Task.Run(() =>
            {
                var worker = new Worker();
                worker.BackgroundWork(counter, Thread.CurrentThread, Task.CurrentId);
            });
        }

        for (int i = 1; i < 10; i++)
        {
            var worker = new Worker();
            worker.ForegroundWork(i, Thread.CurrentThread);
        }
    }
}

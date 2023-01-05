using SharedResources.Helpers;

namespace _02_Synchronous.Examples;

internal static class ParallellWork
{
    public static void Run()
    {

        for (int i = 1; i < 10; i++)
        {
            var worker = new Worker();
            worker.BackgroundWork(i, Thread.CurrentThread, null);
        }

        for (int i = 1; i < 10; i++)
        {
            var worker = new Worker();
            worker.ForegroundWork(i, Thread.CurrentThread);
        }

    }
}

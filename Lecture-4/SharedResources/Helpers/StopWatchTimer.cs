using System.Diagnostics;

namespace SharedResources.Helpers;

public static class StopWatchTimer
{
    private static Stopwatch stopwatch = new Stopwatch();

    public static void Start()
    {
        stopwatch.Start();
    }

    public static void Stop()
    {
        stopwatch.Stop();
        ElapsedTime();
    }

    private static void ElapsedTime()
    {
        var ts = stopwatch.Elapsed;
        var elapsedTime = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        Console.WriteLine($"Elapsed Time: {elapsedTime}\n");
    }
}

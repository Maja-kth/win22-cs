using SharedResources.Helpers;

namespace _02_Tasks.Examples;

internal static class ReturnTaskResults
{
    public static void Run()
    {
        var result_taskrun = Task.Run(() =>
        {
            var worker = new Worker();
            var result = worker.DoWorkAndReturn();
            return result;
        }).Result;
        Console.WriteLine($"Task.Run: {result_taskrun}");


        var worker = new Worker();
        var result_formresult = Task.FromResult(worker.DoWorkAndReturn()).Result;
        Console.WriteLine($"Task.FromResult: {result_formresult}");
    }
}

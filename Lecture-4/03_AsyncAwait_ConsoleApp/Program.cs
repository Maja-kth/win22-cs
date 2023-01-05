using _03_AsyncAwait_ConsoleApp.Helpers;

Console.ReadKey();

var worker = new Worker();


var result_2 = await worker.DoLargeWorkAsync();
Console.WriteLine(result_2);

var result_1 = await worker.DoSmallWorkAsync();
Console.WriteLine(result_1);

Console.ReadKey();
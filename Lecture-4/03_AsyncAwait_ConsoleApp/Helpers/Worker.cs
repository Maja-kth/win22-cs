namespace _03_AsyncAwait_ConsoleApp.Helpers
{
    internal class Worker
    {
        private string DoSmallWork(Guid id)
        {
            for (int i = 0; i < 5; i++) { Console.WriteLine("Doing small work..."); }
            return id.ToString();
        }

        private string DoLargeWork(Guid id)
        {
            for (int i = 0; i < 10; i++) { Console.WriteLine("Doing Large work...");  }
            return id.ToString();
        }

        public async Task<string> DoSmallWorkAsync()
        {
            var result = Task.Run(() => DoSmallWork(Guid.NewGuid()));
            return $"SmallWork Result: {result.Result}";
        }

        public async Task<string> DoLargeWorkAsync()
        {
            var result = Task.FromResult(DoLargeWork(Guid.NewGuid()));
            return $"LargeWork Result: {result.Result}";
        }
    }
}

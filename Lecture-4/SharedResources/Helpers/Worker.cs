namespace SharedResources.Helpers
{
    public class Worker
    {
        public void BackgroundWork(int? counter, Thread? currentThread, int? currentTask)
        {
            if(currentTask != null)
                Console.WriteLine($"Background Work {counter} started with Task ID: {currentTask} on Thread ID: {currentThread?.ManagedThreadId}");
            else
                Console.WriteLine($"Background Work {counter} started on Thread ID: {currentThread?.ManagedThreadId}");
    
            for (uint i = 0; i < uint.MaxValue; i++) { }
            Console.WriteLine($"Background Work {counter} finished\n");
        }

        public void ForegroundWork(int? counter, Thread? currentThread)
        {
            Console.WriteLine($"Work {counter} started on Thread ID: {currentThread?.ManagedThreadId}");
            
            for (uint i = 0; i < uint.MaxValue; i++) { }
            Console.WriteLine($"Work {counter} finished\n");
        }






        public string DoWorkAndReturn()
        {
            return Guid.NewGuid().ToString();
        }









    }
}

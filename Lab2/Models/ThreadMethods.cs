using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class ThreadMethods
    {
        public async Task<string> SlowMethod()
        {
            await Task.Delay(2000);
            Console.WriteLine($"SlowMethod nr wątku: {Thread.CurrentThread.ManagedThreadId}");
            return $"SlowMethod nr wątku: {Thread.CurrentThread.ManagedThreadId}";
        }

        public string FastMethod()
        {
            return $"FastMethod nr wątku: {Thread.CurrentThread.ManagedThreadId}";
        }
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;
using Lab2.Models;

namespace Lab2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            #region Zadanie 1

            var clock1 = new Clock();
            clock1.Run();

            var listener1 = new Listener("Listener nr 1");
            listener1.Subscribe(clock1);

            var listener2 = new Listener("Listener nr 2");
            listener2.Subscribe(clock1);

            var listener3 = new Listener("Listener nr 3");
            listener3.Subscribe(clock1);

            #endregion

            #region Drugie zadanie

            var threadMethods = new ThreadMethods();
            Console.WriteLine("Aktualny wątek: {0}", Thread.CurrentThread.ManagedThreadId.ToString());

            var task = Task.Factory.StartNew(ThreadMethods.SlowMethod);
            task.Wait();

            Console.WriteLine(ThreadMethods.FastMethod());

            #endregion

            Console.ReadKey();


            #region Wnioski

            //Synchroniczna
            //Ten sam watek dla obu metod, wywokanie SlowMethod zawiesza program

            //Wersja z Task
            //Program zawiesza sie tak samo jak dla sycnchronicznej, FastMethod wywolane po SlowMethod, nowe watki

            //Asynchroniczna
            //Najpier wykona sie FastMethod

            #endregion
        }
    }
}
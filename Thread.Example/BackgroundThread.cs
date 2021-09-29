using System;
using System.Threading;

namespace ExampleApp
{
    public class BackgroundThread
    {
        public static void Main()
        {
            //Background Thread start here

            Thread t3 = new Thread(MyThread);

            t3.Name = "MyThread";
            t3.Start();

            t3.IsBackground = true;

            Console.WriteLine("Main Thread ends");
        }
        static void MyThread()
        {
            Console.WriteLine($"Thread in progress {Thread.CurrentThread.Name}");
            Thread.Sleep(2000);
            Console.WriteLine($"Thread is complated {Thread.CurrentThread.Name}");
        }

    }
}

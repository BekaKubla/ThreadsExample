using System;
using System.Threading;

namespace ExampleApp
{
    class MultipleThread
    {
        public static void Main()
        {
            //Multiple Thread start here
            Thread t1 = new Thread(Up);
            Thread t2 = new Thread(Down);

            t1.Start();
            t2.Start();
            //Multiple Thread end here
        }
        static void Up()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread 1 , second : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("-----Thread 1 finish-----");
        }
        static void Down()
        {
            for (int i = 7; i > 0; i--)
            {
                Console.WriteLine($"Thread 2 , second : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("-----Thread 2 finish-----");
        }
    }
}

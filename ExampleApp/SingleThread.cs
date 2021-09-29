using System;
using System.Threading;

namespace ExampleApp
{
    class SingleThread
    {

        static void Main(string[] args)
        {
            //Signle Thread start here
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"This is main thread, second {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("-----Main Thread end-----");
            //Single Thread end Here

        }

    }
}

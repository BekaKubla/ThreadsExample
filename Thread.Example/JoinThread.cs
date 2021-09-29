using System;
using System.Threading;

namespace ExampleApp
{
    public class JoinThread
    {
        public static void Main()
        {
            Console.WriteLine("main method start here");

            Thread t1 = new Thread(JoinMethod);

            t1.Start();
            t1.Join();

            Console.WriteLine("Main Method end here");

        }
        public static void JoinMethod()
        {
            Console.WriteLine("start join method");
            Thread.Sleep(1000);
            Console.WriteLine("end join method");
        }
    }

}

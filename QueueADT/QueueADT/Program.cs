using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueADT
{
    class Program
    {
        static void Main(string[] args)
        {
            staticQueueTesting();
            dynamicQueueTesting();
            Console.ReadKey();

        }

        public static void dynamicQueueTesting()
        {
            Random rd = new Random();
            DynamicQueueADT myStaticQueue = new DynamicQueueADT();

            myStaticQueue.Enqueue(rd.Next());
            myStaticQueue.Enqueue(rd.Next());
            myStaticQueue.Enqueue(rd.Next());
            myStaticQueue.Enqueue(rd.Next());
            myStaticQueue.Enqueue(rd.Next());

            Console.WriteLine("");
            myStaticQueue.Print();
            Console.WriteLine("");

            myStaticQueue.Dequeue();

            myStaticQueue.Print();
        }

        public static void staticQueueTesting()
        {
            Random rd = new Random();
            StaticQueueADT myStaticQueue = new StaticQueueADT();

            myStaticQueue.Enqueue(rd.Next());
            myStaticQueue.Enqueue(rd.Next());
            myStaticQueue.Enqueue(rd.Next());
            myStaticQueue.Enqueue(rd.Next());
            myStaticQueue.Enqueue(rd.Next());

            Console.WriteLine("");
            myStaticQueue.Print();
            Console.WriteLine("");

            myStaticQueue.DeQueue();

            myStaticQueue.Print();

        }
    }
}

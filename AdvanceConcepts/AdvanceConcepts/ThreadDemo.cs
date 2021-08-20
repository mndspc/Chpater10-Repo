using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdvanceConcepts
{
    //  This program shows how can create threads
    class ThreadDemo
    {
        public static void PrintNumbers()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Thread1={0}\t",i);
                Thread.Sleep(500);
            }
        }
        public static void PrintNumbers1()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine("Thread2={0}\t", i);
                Thread.Sleep(500);
            }
        }
        static void Main()
        {

            ThreadStart threadStart = new ThreadStart(PrintNumbers);
            Thread thread1 = new Thread(threadStart);
            Thread thread2 = new Thread(PrintNumbers1);
            thread1.Priority = ThreadPriority.Lowest;
            thread2.Priority = ThreadPriority.Highest;
            thread1.Start();
            //thread1.Join();
            thread2.Start();
            Console.ReadLine();
        }
    }
}

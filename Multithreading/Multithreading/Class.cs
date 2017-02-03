using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging; // used this
using System.Text;
using System.Threading;



namespace async
{
    class Class
    {
        public static void FinallyHandler(IAsyncResult iar)
        {
            Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            AsyncResult ar = iar as AsyncResult;
            MD d = ar.AsyncDelegate as MD;
            int result = d.EndInvoke(iar);
            Console.WriteLine("Res is {0}",result);
            Console.WriteLine(((DateTime)ar.AsyncState).ToLongTimeString()); // datetime
            
        }
        public static int MyMethod(int n)
        {
            int sum = 0;
            Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            while (n>0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Num from mymethod {0}",n--);
                Thread.Sleep(500);
                Console.ResetColor();
                sum += n;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Finish MyMethod");
            Console.ResetColor();
            return sum;
        }
    }
}

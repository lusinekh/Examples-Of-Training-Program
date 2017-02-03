using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //used

namespace async
{
    public delegate int MD(int a);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
          
            MD md = Class.MyMethod; 
           
            IAsyncResult iar = md.BeginInvoke(15, Class.FinallyHandler,DateTime.Now);
            int m = 30;
            while (m>0)
            {
              
                Console.WriteLine("Num from Main {0}",m);
                Console.ResetColor();
                Thread.Sleep(700);
                m--;
            }
            
            Console.WriteLine("Finish Main");
          
        }
    }
}

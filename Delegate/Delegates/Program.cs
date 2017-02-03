using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public static void OnCarCrash1(Object o, EventArgs crash)
        {
            if (o is Car)
            {
                Car c = o as Car;
                c.Speed = 0;
                c.IsCrash = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("is this car {0}", c.Name);
                Console.ResetColor();
            }
        }
        public static void OnDanger(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Car close to the maximum speed");
            Console.ResetColor();
        }
        public static void Emergency(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exceed the maximum speed of the car");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
           
            var c1 = new Car("Ford", 89, 250);
            var c2 = new Car("BMW", 120, 180);
          

            c1.RegisterCarCrash(OnCarCrash1);

            for (int i = 0; i < 100; i++)
            {
                c1.accelerate(10);
                c2.accelerate(11);
            }
          
            Console.ReadLine();
        }
    }
}

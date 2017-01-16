using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApplication15
{
    public enum Mast1 : byte
    {
        sev = 3,
        xach,
        sirt,
        cyap





    }

    class Program
    {


        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("enter colors Name or value");
                string s = Console.ReadLine();
                ConsoleColor a = 0;
                int val;
                if (int.TryParse(s, out val))
                {
                    if (Enum.IsDefined(typeof(ConsoleColor), val))
                    {

                        a = (ConsoleColor)val;
                    }

                    else
                        Console.WriteLine("eror enter");

                }

                else
                {
                    if (Enum.IsDefined(typeof(ConsoleColor), s))
                    {

                        a = (ConsoleColor)Enum.Parse(typeof(ConsoleKey), s);
                    }

                    else

                        Console.WriteLine("eror enter");

                }
                Console.BackgroundColor = a;
                Console.Clear();


            }

            while (Console.ReadKey().Key == ConsoleKey.Enter);
        }



    }
}
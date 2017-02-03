using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class Figure
    {
        public int X { get; set; }
        public abstract void Show();
        public Figure(int a = 1)
        {
            X = a;
        }
    }

    class Program
    {
        static void Main()
        {
            Rect rt = new Rect();
            Console.WriteLine(rt.GetPoint() + "\t" + rt.Points + "\t" + rt[0]);
            Figure[] fg = { new Rect(), new Rect(), new Circle(), new Hexagon() };
            for (int i = 0; i < fg.Length; i++)
            {

                if (fg[i] is IPoint)
                {
                    IPoint ip = fg[i] as IPoint;
                    Console.WriteLine(ip.GetPoint());
                }
                else
                {
                    Console.WriteLine("Not found ");
                }
            }
            IPoint[] arr = { new Hexagon(), new Rect(), new Knife(), new Mountian(), new Circle() as IPoint, new Knife() };

           

            foreach (var item in arr)
            {
                if (item == null)
                {
                    
                    Console.WriteLine("ArgumentNullException");
                }
                else
                {
                    Console.WriteLine(item.Points);
                }
            }
            var rty = new Rect();
            rty.Show();
            IShow ish = rty;
            ish.Show();          

        }


    }
}

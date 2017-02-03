using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interface
{
    public class Hexagon : Figure, IPoint
    {
        public override void Show()
        {
            Console.WriteLine("Show From Hexagon");
        }

        public int GetPoint()
        {
            return 6;

        }

        public int Points
        {
            get { return 6; }
        }

        public int this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return 6;
                }
                else
                {
                    return 600;
                }
            }
        }
    }
}

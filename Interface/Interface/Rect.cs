using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Rect : Figure, IPoint, IShow
    {
        public override void Show()
        {
            Console.WriteLine("Show From Rectangle");
        }
        // bacahayt iracum
       
        public int GetPoint()
        {
            return 4;
        }

        public int Points
        {
            get { return 4; }
        }

        public int this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return 4;
                }
                else
                {
                    return 100;
                }
            }
        }
    }
}

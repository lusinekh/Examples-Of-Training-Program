using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Knife : IPoint
    {
        public int GetPoint()
        {
            return 1;
        }

        public int Points
        {
            get { return 1; }
        }

        public int this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return 0;
                }
                else
                {
                    return 1000;
                }
            }
        }
    }
}

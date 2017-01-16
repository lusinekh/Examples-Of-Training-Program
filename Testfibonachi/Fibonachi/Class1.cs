using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
  
        public class Fibonachi1
        {


            private int last = 0;
            private int next = 1;



            private int fib1(int k)
            {
                int fib1 = 0;
                for (int i = 1; i <= k; i++)
                {
                    fib1 = last + next;
                    last = next;
                    next = fib1;

                }
                return fib1;
            }

            public int this[int index]
            {
                set
                {
                    value = (fib1(index));

                }

                get
                {

                    return fib1(index);
                }

            }

                  

    }
}

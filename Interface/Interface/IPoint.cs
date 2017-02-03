using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public interface IPoint
    {
        int GetPoint();
        int Points { get; }
        int this[int i] { get; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal interface IDiff<T> where T : IDiff<T>
    {
        static abstract T operator -(T left, T right);
    }
}

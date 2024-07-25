using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Range<T> where T : IComparable<T>, IDiff<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max) { Min = min; Max = max; }

        public bool IsInRange(T val)
        {
            return (val.CompareTo(Min) >= 0) && (val.CompareTo(Max) <= 0);
        }

        public T Length()
        {
            return Max - Min;
        }
    }
}

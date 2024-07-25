using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class MyNumber : IComparable<MyNumber>, IDiff<MyNumber>
    {
        public int Num {  get; set; }

        public MyNumber(int num)
        {
            Num = num;
        }

        public int CompareTo(MyNumber? other)
        {
            if (other is MyNumber passedNum)
            {
                return Num.CompareTo(passedNum.Num);
            }

            return 1;
        }

        public static MyNumber operator -(MyNumber left, MyNumber right)
        {
            return new MyNumber(left.Num - right.Num);
        }

        public override string ToString()
        {
            return $"number: {Num}";
        }
    }
}

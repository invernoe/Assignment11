namespace Assignment11
{
    internal class Program
    {

        /// <summary>
        /// optimized bubble sort by doing the following:
        /// 1. if there were no swaps in a certain iteration that means the array is asorted and we can exit
        /// 2. we can skip some iterations by tracking where the last swap occurred and terminating inner loop based on last swap index
        /// </summary>
        /// <typeparam name="T">type of array</typeparam>
        /// <param name="a">input array that should be sorted</param>
        public static void bubbleSortOptimized<T>(T[] a) where T : IComparable<T>
        {
            int lastSwap = a.Length - 1;
            for (int i = 1; i < a.Length; i++)
            {
                bool isSwapped = false;
                int currentSwap = -1;
                for (int j = 0; j < lastSwap; j++)
                {
                    if (a[j].CompareTo(a[j + 1]) > 0)
                    {
                        T temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        isSwapped = true;
                        currentSwap = j;
                    }
                }
                if (!isSwapped) return;
                lastSwap = currentSwap;
            }
        }

        static void Main(string[] args)
        {
            #region Question 1
            int[] arr = {64, 34, 25, 12, 22, 11, 90};
            bubbleSortOptimized(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Question 2
            Range<MyNumber> myRange = new Range<MyNumber>(new MyNumber(3), new MyNumber(5));
            
            bool is4InRange = myRange.IsInRange(new MyNumber(4));
            bool is6InRange = myRange.IsInRange(new MyNumber(6));
            Console.WriteLine(is4InRange);
            Console.WriteLine(is6InRange);

            Console.WriteLine(myRange.Length());
            #endregion
        }
    }
}

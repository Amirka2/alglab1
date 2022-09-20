using System;
namespace algorithm_lab1
{
    public class TimSort : Algorithm
    {
        public TimSort(int[] array) : base(array)
        {
        }

        public override void Calculate()
        {
            int minRun = GetMinRun(Array.Length);
        }

        private int GetMinRun(int n)
        {
            int r = 0;
            while(n >= 64)
            {
                r |= n & 1;
                n >>= 1;
            }
            return n + r;
        }
    }
}

using System;
namespace algorithm_lab1
{
    public class Fibonachi : Algorithm
    {
        public Fibonachi(int[] array) : base(array)
        {
        }

        public override void Calculate()
        {
            FibonachiAlg(Array.Length);
        }
        public int FibonachiAlg(int n)
        {
            if (n == 0 || n == 1) return n;

            return FibonachiAlg(n - 1) + FibonachiAlg(n - 2);
        }
    }
}

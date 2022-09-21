using System;
namespace algorithm_lab1
{
    public class Multiplier : Algorithm
    {
        public Multiplier(int[] array) : base(array)
        {
        }

        public override void Calculate()
        {
            int res = 1;
            foreach(int el in Array)
            {
                res *= el;
            }
        }
    }
}

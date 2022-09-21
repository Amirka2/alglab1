using System;
namespace algorithm_lab1
{
    public class Summator : Algorithm
    {
        public Summator(int[] array) : base(array)
        {
        }

        public override void Calculate()
        {
            int res = 0;
            foreach(int el in Array)
            {
                res += el;
            }
        }
    }
}

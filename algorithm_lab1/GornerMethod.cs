using System;
namespace algorithm_lab1
{
    public class GornerMethod : Algorithm
    {
        public GornerMethod(int[] array) : base(array)
        {
        }

        public override void Calculate()
        {
            GornerAlg();
        }

        public double GornerAlg(int i = 0)
        {
            double x = 1.5;
            if (i >= Array.Length)
            {
                return 1;
            }

            return Array[i] + x * GornerAlg(i + 1);
        }
    }
}

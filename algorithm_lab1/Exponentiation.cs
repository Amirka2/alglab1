using System;
namespace algorithm_lab1
{
    public class Exponentiation
    {
        private int StepCount = 0;

        public int Pow(int x, int n)
        {
            int f = 1;
            int count = 0;
            while (count < n)
            {
                f *= x;
                count += 1;
                StepCount += 2;
            }

            return f;
        }
    }
}

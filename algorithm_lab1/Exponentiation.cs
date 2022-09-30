using System;
namespace algorithm_lab1
{
    public class Exponentiation 
    {
        public int StepCount { get; private set; }
        public int X { get; private set; }
        public int N { get; private set; }
        public int Result { get; private set; }


        public Exponentiation(int x, int n) 
        {
            X = x;
            N = n;
        }

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

            Result = f;
            return f;
        }
        public int RecPow(int x, int n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return x;

            StepCount += 2;

            Result = x * RecPow(x, --n);
            return x * RecPow(x, --n);
        }
        public int QuickPow(int x, int n)
        {
            int c = x, k = n, f = 1;
            if (k % 2 == 1)
            {
                f = c;
            }

            do
            {
                StepCount += 2;
                k = k / 2;
                c *= c;
                if (k % 2 == 1)
                {
                    StepCount++;
                    f *= c;
                }
            } while (k != 0);

            Result = f;
            return f;
        }
        public int ClassicQuickPow(int x, int n)
        {
            int c = x, k = n, f = 1;
            
            while (k != 0) 
            {
                if (k % 2 == 0)
                {
                    StepCount += 2;
                    c *= c;
                    k /= 2;
                }
                else
                {
                    StepCount += 2;
                    f *= c;
                    k--;
                }
            }

            Result = f;
            return f;
        }
    }
}

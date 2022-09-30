using System;
namespace algorithm_lab1
{
    public class Euclid
    {
        public static int Result { get; private set; }
        public static int EuclidAlg(int val1, int val2)
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                    val1 -= val2;
                else
                    val2 -= val1;
            }

            int result = Math.Max(val1, val2);
            Result = result;
            return result;
        }
    }
}
